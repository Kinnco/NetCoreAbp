using Abp.Application.Services.Dto;

namespace NetCoreAbp.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

