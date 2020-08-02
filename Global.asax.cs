using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace BESTPATH
{
    public class Global : HttpApplication
    {
        protected void Application_BeginRequest(Object sender, EventArgs e)
        {
            switch (Request.Url.Scheme)
            {
                case "https":
                    Response.AddHeader("Strict-Transport-Security", "max-age=300");
                    break;

                case "http":
                    var path = "https://" + Request.Url.Host + Request.Url.PathAndQuery;
                    Response.Status = "301 Moved Permanently";
                    Response.AddHeader("Location", path);
                    break;

            }//end switch

        }//end event

        void Application_Start(object sender, EventArgs e)
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

        }//end event

        void Application_End(object sender, EventArgs e)
        {

        }//end event

        void Application_Error(object sender, EventArgs e)
        {
            Server.ClearError();

        }//end event

    }//end class

}//end namespace
