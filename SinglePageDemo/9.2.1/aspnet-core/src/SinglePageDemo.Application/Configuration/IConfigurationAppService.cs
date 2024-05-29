using System.Threading.Tasks;
using SinglePageDemo.Configuration.Dto;

namespace SinglePageDemo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
