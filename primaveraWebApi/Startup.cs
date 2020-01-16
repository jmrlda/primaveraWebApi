using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace primaveraWebApi
{
    class Startup
    {
      public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
             name: "DefaultApi",
             routeTemplate: "api/{controller}/{id}",
             defaults: new { id = RouteParameter.Optional }

            );
            config.Formatters.Add(new BsonMediaTypeFormatter());

            //config.Formatters.Add(new BrowserJsonFormatter());
            app.UseWebApi(config);
        }
    }
}
