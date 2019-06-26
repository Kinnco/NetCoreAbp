using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NetCoreAbp.Configuration;

namespace NetCoreAbp.Web.Host.Startup
{
    [DependsOn(
       typeof(NetCoreAbpWebCoreModule))]
    public class NetCoreAbpWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public NetCoreAbpWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NetCoreAbpWebHostModule).GetAssembly());
        }
    }
}
