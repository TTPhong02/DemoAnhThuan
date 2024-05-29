using Abp.Application.Services;
using SinglePageDemo.MultiTenancy.Dto;

namespace SinglePageDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

