using System.Threading.Tasks;
using Abp.Application.Services;
using NetCoreAbp.Sessions.Dto;

namespace NetCoreAbp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
