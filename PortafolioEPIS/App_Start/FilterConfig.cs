using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jsreport.Binary;
using jsreport.Local;
using jsreport.MVC;

namespace PortafolioEPIS
{
    public class FilterConfig
    {

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new JsReportFilterAttribute(new LocalReporting()
                .UseBinary(JsReportBinary.GetBinary())
                .AsUtility()
                .Create()));
            filters.Add(new HandleErrorAttribute());
        }
    }
}