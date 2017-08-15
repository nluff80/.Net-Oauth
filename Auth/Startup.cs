using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Auth.Config;
using System.Web.Http;

[assembly: OwinStartup(typeof(Auth.Startup))]

namespace Auth
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();
            WebApiConfig.Register(configuration);
            app.UseWebApi(configuration);
        }
    }
}
