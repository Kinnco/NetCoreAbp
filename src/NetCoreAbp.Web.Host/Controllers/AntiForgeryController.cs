using Microsoft.AspNetCore.Antiforgery;
using NetCoreAbp.Controllers;

namespace NetCoreAbp.Web.Host.Controllers
{
    public class AntiForgeryController : NetCoreAbpControllerBase
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
