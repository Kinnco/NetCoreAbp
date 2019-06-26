using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NetCoreAbp.Roles.Dto;
using NetCoreAbp.Users.Dto;

namespace NetCoreAbp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
