using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SinglePageDemo.Controllers
{
    public abstract class SinglePageDemoControllerBase: AbpController
    {
        protected SinglePageDemoControllerBase()
        {
            LocalizationSourceName = SinglePageDemoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
