using System.Threading.Tasks;
using Abp.Application.Services;
using NetCore.Sessions.Dto;

namespace NetCore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
