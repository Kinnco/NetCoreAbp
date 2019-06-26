using System.Threading.Tasks;
using Abp.Application.Services;
using NetCoreAbp.Authorization.Accounts.Dto;

namespace NetCoreAbp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
