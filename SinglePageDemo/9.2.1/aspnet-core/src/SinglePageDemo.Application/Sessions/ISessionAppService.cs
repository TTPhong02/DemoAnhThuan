using System.Threading.Tasks;
using Abp.Application.Services;
using SinglePageDemo.Sessions.Dto;

namespace SinglePageDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
