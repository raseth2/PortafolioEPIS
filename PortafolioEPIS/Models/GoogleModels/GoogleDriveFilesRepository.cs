using Google.Apis.Auth.OAuth2;
using Google.Apis.Download;
using Google.Apis.Drive.v2;
using Google.Apis.Drive.v2.Data;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Web;
using System.Linq;

namespace PortafolioEPIS.Models.GoogleModels
{
    public class GoogleDriveFilesRepository
    {
        public static string[] Scopes = { Google.Apis.Drive.v3.DriveService.Scope.Drive };
        

        public static Google.Apis.Drive.v3.DriveService GetService_v3()
        {
            UserCredential credential;
            using (var stream = new FileStream(HttpContext.Current.Server.MapPath("~/Imagen/client_secret.json"), FileMode.Open, FileAccess.Read))
            {
                String FolderPath = @"D:\";
                String FilePath = Path.Combine(FolderPath, "DriveServiceCredentials.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(FilePath, true)).Result;
            }

            //Create Drive API service.
            Google.Apis.Drive.v3.DriveService service = new Google.Apis.Drive.v3.DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "GoogleDriveRestAPI-v3",
            });

            return service;
        }
        public static Google.Apis.Drive.v2.DriveService GetService_v2()
        {
            UserCredential credential;
            using (var stream = new FileStream(HttpContext.Current.Server.MapPath("~/Imagen/client_secret.json"), FileMode.Open, FileAccess.Read))
            {
                String FolderPath = @"D:\";
                String FilePath = Path.Combine(FolderPath, "DriveServiceCredentials.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(FilePath, true)).Result;
            }

            //Create Drive API service.
            Google.Apis.Drive.v2.DriveService service = new Google.Apis.Drive.v2.DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "GoogleDriveRestAPI-v2",
            });

            return service;
        }
        public static List<GoogleDriveFiles> GetContainsInFolder(String folderId)
        {
            List<string> ChildList = new List<string>();
            Google.Apis.Drive.v2.DriveService ServiceV2 = GetService_v2();
            ChildrenResource.ListRequest ChildrenIDsRequest = ServiceV2.Children.List(folderId);
            do
            {
                ChildList children = ChildrenIDsRequest.Execute();

                if (children.Items != null && children.Items.Count > 0)
                {
                    foreach (var file in children.Items)
                    {
                        ChildList.Add(file.Id);
                    }
                }
                ChildrenIDsRequest.PageToken = children.NextPageToken;

            } while (!String.IsNullOrEmpty(ChildrenIDsRequest.PageToken));

            //Get All File List
            List<GoogleDriveFiles> AllFileList = GetDriveFiles();
            List<GoogleDriveFiles> Filter_FileList = new List<GoogleDriveFiles>();

            foreach (string Id in ChildList)
            {
                Filter_FileList.Add(AllFileList.Where(x => x.Id == Id).FirstOrDefault());
            }
            return Filter_FileList;
        }
        public static void CreateFolder(string FolderName,string IdCarpeta)
        {
            
            Google.Apis.Drive.v3.DriveService service = GetService_v3();

            Google.Apis.Drive.v3.Data.File FileMetaData = new Google.Apis.Drive.v3.Data.File();

            FileMetaData.Name = FolderName;
            FileMetaData.MimeType = "application/vnd.google-apps.folder";
            FileMetaData.Parents = new List<string>
                    {
                        IdCarpeta
                    };

            Google.Apis.Drive.v3.FilesResource.CreateRequest request;
            
                request = service.Files.Create(FileMetaData);
            request.Fields = "id";
            var file = request.Execute();
            //Console.WriteLine("Folder ID: " + file.Id);
        }
        public static void FileUploadInFolder(string folderId, HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                Google.Apis.Drive.v3.DriveService service = GetService_v3();

                string path = Path.Combine(HttpContext.Current.Server.MapPath("~/GoogleDriveFiles"),
                Path.GetFileName(file.FileName));
                file.SaveAs(path);

                var FileMetaData = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = Path.GetFileName(file.FileName),
                    MimeType = MimeMapping.GetMimeMapping(path),
                    Parents = new List<string>
                    {
                        folderId
                    }
                };

                Google.Apis.Drive.v3.FilesResource.CreateMediaUpload request;
                using (var stream = new System.IO.FileStream(path, System.IO.FileMode.Open))
                {
                    request = service.Files.Create(FileMetaData, stream, FileMetaData.MimeType);
                    request.Fields = "id";
                    request.Upload();
                }
                var file1 = request.ResponseBody;
            }
        }
        public static List<GoogleDriveFiles> GetDriveFiles()
        {
            Google.Apis.Drive.v3.DriveService service = GetService_v3();

            // Define parameters of request.
            Google.Apis.Drive.v3.FilesResource.ListRequest FileListRequest = service.Files.List();
            FileListRequest.Fields = "nextPageToken, files(createdTime, id, name, size, version, trashed, parents)";

            // List files.
            IList<Google.Apis.Drive.v3.Data.File> files = FileListRequest.Execute().Files;
            List<GoogleDriveFiles> FileList = new List<GoogleDriveFiles>();

            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    GoogleDriveFiles File = new GoogleDriveFiles
                    {
                        Id = file.Id,
                        Name = file.Name,
                        Size = file.Size,
                        Version = file.Version,
                        CreatedTime = file.CreatedTime,
                        Parents = file.Parents
                    };
                    FileList.Add(File);
                }
            }
            return FileList;
        }
        public static void FileUpload(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                Google.Apis.Drive.v3.DriveService service = GetService_v3();

                string path = Path.Combine(HttpContext.Current.Server.MapPath("~/GoogleDriveFiles"),
                Path.GetFileName(file.FileName));
                file.SaveAs(path);

                var FileMetaData = new Google.Apis.Drive.v3.Data.File();
                FileMetaData.Name = Path.GetFileName(file.FileName);
                FileMetaData.MimeType = MimeMapping.GetMimeMapping(path);

                Google.Apis.Drive.v3.FilesResource.CreateMediaUpload request;

                using (var stream = new System.IO.FileStream(path, System.IO.FileMode.Open))
                {
                    request = service.Files.Create(FileMetaData, stream, FileMetaData.MimeType);
                    request.Fields = "id";
                    request.Upload();
                }
            }
        }
        public static string DownloadGoogleFile(string fileId)
        {
            Google.Apis.Drive.v3.DriveService service = GetService_v3();

            string FolderPath = System.Web.HttpContext.Current.Server.MapPath("/GoogleDriveFiles/");
            Google.Apis.Drive.v3.FilesResource.GetRequest request = service.Files.Get(fileId);

            string FileName = request.Execute().Name;
            string FilePath = System.IO.Path.Combine(FolderPath, FileName);

            MemoryStream stream1 = new MemoryStream();

            request.MediaDownloader.ProgressChanged += (Google.Apis.Download.IDownloadProgress progress) =>
            {
                switch (progress.Status)
                {
                    case DownloadStatus.Downloading:
                        {
                            //Console.WriteLine(progress.BytesDownloaded);
                            break;
                        }
                    case DownloadStatus.Completed:
                        {
                            //Console.WriteLine("Download complete.");
                            SaveStream(stream1, FilePath);
                            break;
                        }
                    case DownloadStatus.Failed:
                        {
                            //Console.WriteLine("Download failed.");
                            break;
                        }
                }
            };
            request.Download(stream1);
            return FilePath;
        }

        private static void SaveStream(MemoryStream stream, string FilePath)
        {
            using (System.IO.FileStream file = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite))
            {
                stream.WriteTo(file);
            }
        }


        public static void DeleteFile(GoogleDriveFiles files)
        {
            Google.Apis.Drive.v3.DriveService service = GetService_v3();
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                if (files == null)
                    throw new ArgumentNullException(files.Id);

                // Make the request.
                service.Files.Delete(files.Id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Files.Delete failed.", ex);
            }
        }

    }
}