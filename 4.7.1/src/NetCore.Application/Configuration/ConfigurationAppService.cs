using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using NetCore.Configuration.Dto;

namespace NetCore.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : NetCoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
