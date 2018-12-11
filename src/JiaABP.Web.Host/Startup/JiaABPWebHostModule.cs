using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JiaABP.Configuration;

namespace JiaABP.Web.Host.Startup
{
    [DependsOn(
       typeof(JiaABPWebCoreModule))]
    public class JiaABPWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public JiaABPWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(JiaABPWebHostModule).GetAssembly());
        }
    }
}
