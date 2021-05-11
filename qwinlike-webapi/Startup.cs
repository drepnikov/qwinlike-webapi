using System.Configuration;
using System.Web.Http;
using Owin;

namespace qwinlike_webapi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute("default", "{controller}");
            app.UseWebApi(config);
        }
    }
}