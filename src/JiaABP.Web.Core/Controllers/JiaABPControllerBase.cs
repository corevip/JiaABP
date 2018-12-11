using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace JiaABP.Controllers
{
    public abstract class JiaABPControllerBase: AbpController
    {
        protected JiaABPControllerBase()
        {
            LocalizationSourceName = JiaABPConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
