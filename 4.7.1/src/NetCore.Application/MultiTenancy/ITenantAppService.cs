using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NetCore.MultiTenancy.Dto;

namespace NetCore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

