using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SinglePageDemo.Configuration;

namespace SinglePageDemo.Web.Host.Startup
{
    [DependsOn(
       typeof(SinglePageDemoWebCoreModule))]
    public class SinglePageDemoWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SinglePageDemoWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SinglePageDemoWebHostModule).GetAssembly());
        }
    }
}
