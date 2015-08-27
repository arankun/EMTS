using Emts.Common.Logging;
using Emts.Common.TypeMapping;
using Emts.Web.Api;
using Emts.Web.Common;
using System.Web.Http;
using System.Web.Mvc;

namespace App.Web.Api {
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();//AT?: Added for Route Debugging?
            new AutoMapperConfigurator().Configure(
                WebContainerManager.GetAll<IAutoMapperTypeConfigurator>());
        }

        protected void Application_Error() {
            var exception = Server.GetLastError();
            if (exception != null) {
                var log = WebContainerManager.Get<ILogManager>().GetLog(typeof(WebApiApplication));
                log.Error("Unhandled exception.", exception);
            }
        }
    }
}
