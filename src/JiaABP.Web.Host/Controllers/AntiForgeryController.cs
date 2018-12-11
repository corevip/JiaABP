using Microsoft.AspNetCore.Antiforgery;
using JiaABP.Controllers;

namespace JiaABP.Web.Host.Controllers
{
    public class AntiForgeryController : JiaABPControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
