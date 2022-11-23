using AmediaChallenge.DatabaseContext;
using AmediaChallenge.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmediaChallenge.Controllers
{
    public class LoginController : BaseController
    {
        public LoginController(AmediaDbContext amediaDbContext) : base(amediaDbContext) { }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm] LoginForm form)
        {
            try
            {
                var user = amediaDbContext.Users
                    .Include(x => x.userType)
                    .FirstOrDefault(x => x.username == form.Username && x.password == form.Password);
                
                if (user != null)
                {
                    if (user.userType.name == "Admin")
                    {
                        return View();
                    }
                    else
                    {
                        return View();
                    }
                }

                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
