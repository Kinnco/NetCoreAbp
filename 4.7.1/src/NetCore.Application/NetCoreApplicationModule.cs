using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NetCore.Authorization;

namespace NetCore
{
    [DependsOn(
        typeof(NetCoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class NetCoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<NetCoreAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(NetCoreApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
