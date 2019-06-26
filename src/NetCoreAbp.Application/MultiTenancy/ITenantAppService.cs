using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NetCoreAbp.MultiTenancy.Dto;

namespace NetCoreAbp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

