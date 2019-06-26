using System.Threading.Tasks;
using NetCoreAbp.Configuration.Dto;

namespace NetCoreAbp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
