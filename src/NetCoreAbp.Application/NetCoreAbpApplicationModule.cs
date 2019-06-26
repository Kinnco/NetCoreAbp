using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NetCoreAbp.Authorization;

namespace NetCoreAbp
{
    [DependsOn(
        typeof(NetCoreAbpCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class NetCoreAbpApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<NetCoreAbpAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(NetCoreAbpApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
