using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SinglePageDemo.EntityFrameworkCore;
using SinglePageDemo.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace SinglePageDemo.Web.Tests
{
    [DependsOn(
        typeof(SinglePageDemoWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SinglePageDemoWebTestModule : AbpModule
    {
        public SinglePageDemoWebTestModule(SinglePageDemoEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SinglePageDemoWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SinglePageDemoWebMvcModule).Assembly);
        }
    }
}