using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using NetCoreAbp.Configuration.Dto;

namespace NetCoreAbp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : NetCoreAbpAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
