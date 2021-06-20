using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Security.Principal;
using System.Text;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace PuroEscabio
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            string a = "";


        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            using (var stream = new MemoryStream())
            {
                HttpContext.Current.Request.InputStream.Seek(0, SeekOrigin.Begin);
                HttpContext.Current.Request.InputStream.CopyTo(stream);
                string requestBody = Encoding.UTF8.GetString(stream.ToArray());
                if (requestBody != string.Empty)
                {
                    //JObject inputReqObj = JObject.Parse(requestBody);
                    //var UserID = (string)inputReqObj["eUserID"];
                }
            }

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            string a = "";

        }
        protected void Session_End(object sender, EventArgs e)
        {
            string a = "";

        }
        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            if (HttpContext.Current.User != null)
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    if (HttpContext.Current.User.Identity is FormsIdentity)
                    {
                        FormsIdentity id = (FormsIdentity)HttpContext.Current.User.Identity;
                        FormsAuthenticationTicket ticket = id.Ticket;
                        string userData = ticket.UserData;
                        string[] roles = userData.Split(',');
                        HttpContext.Current.User = new GenericPrincipal(id, roles);
                    }
                }
            }
        }

    }
}