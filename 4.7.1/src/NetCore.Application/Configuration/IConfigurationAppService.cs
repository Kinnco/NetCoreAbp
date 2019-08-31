using System.Threading.Tasks;
using NetCore.Configuration.Dto;

namespace NetCore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
