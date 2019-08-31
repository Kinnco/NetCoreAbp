using Microsoft.AspNetCore.Antiforgery;
using NetCore.Controllers;

namespace NetCore.Web.Host.Controllers
{
    public class AntiForgeryController : NetCoreControllerBase
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
