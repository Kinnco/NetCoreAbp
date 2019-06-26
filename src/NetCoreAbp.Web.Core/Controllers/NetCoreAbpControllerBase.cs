using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace NetCoreAbp.Controllers
{
    public abstract class NetCoreAbpControllerBase: AbpController
    {
        protected NetCoreAbpControllerBase()
        {
            LocalizationSourceName = NetCoreAbpConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
