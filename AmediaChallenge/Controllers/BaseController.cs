using AmediaChallenge.DatabaseContext;
using Microsoft.AspNetCore.Mvc;

namespace AmediaChallenge.Controllers
{
    public class BaseController : Controller
    {
        protected AmediaDbContext amediaDbContext;

        public BaseController(AmediaDbContext amediaDbContext)
        {
            this.amediaDbContext = amediaDbContext ?? throw new ArgumentNullException(nameof(amediaDbContext));
        }
    }
}
