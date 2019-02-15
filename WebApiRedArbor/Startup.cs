using Microsoft.Owin;
using Owin;
using RedArbor.Core.Loader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Unity.AspNet.WebApi;


[assembly: OwinStartup(typeof(WebApiRedArbor.Startup))]
namespace WebApiRedArbor
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            ConfigureContainer(config);
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
        public void ConfigureContainer(HttpConfiguration config)
        {
            var container = UnityConfig.Container;
            ModuleLoader.LoadContainer(container);
            var resolver = new UnityDependencyResolver(container);
            config.DependencyResolver = resolver;
        }
    }
}