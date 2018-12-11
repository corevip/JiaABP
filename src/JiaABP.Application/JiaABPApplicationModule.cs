using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JiaABP.Authorization;

namespace JiaABP
{
    [DependsOn(
        typeof(JiaABPCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class JiaABPApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<JiaABPAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(JiaABPApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
