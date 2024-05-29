using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SinglePageDemo.Authorization;

namespace SinglePageDemo
{
    [DependsOn(
        typeof(SinglePageDemoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SinglePageDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SinglePageDemoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SinglePageDemoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
