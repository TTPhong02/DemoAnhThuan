using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SinglePageDemo.Configuration.Dto;

namespace SinglePageDemo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SinglePageDemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
