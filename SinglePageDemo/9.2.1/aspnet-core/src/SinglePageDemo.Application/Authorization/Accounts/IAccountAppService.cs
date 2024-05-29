using System.Threading.Tasks;
using Abp.Application.Services;
using SinglePageDemo.Authorization.Accounts.Dto;

namespace SinglePageDemo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
