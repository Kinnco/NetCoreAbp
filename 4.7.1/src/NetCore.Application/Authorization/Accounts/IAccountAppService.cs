using System.Threading.Tasks;
using Abp.Application.Services;
using NetCore.Authorization.Accounts.Dto;

namespace NetCore.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
