using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NetCore.Configuration;

namespace NetCore.Web.Host.Startup
{
    [DependsOn(
       typeof(NetCoreWebCoreModule))]
    public class NetCoreWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public NetCoreWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NetCoreWebHostModule).GetAssembly());
        }
    }
}
