using AmediaChallenge.DatabaseContext;
using AmediaChallenge.Forms;
using AmediaChallenge.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmediaChallenge.Controllers
{
    public class LoginController : BaseController
    {
        public LoginController(AmediaDbContext amediaDbContext) : base(amediaDbContext) { }

        public IActionResult Login()
        {
            LoginViewModel viewModel= new LoginViewModel();

            return View("Login", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Authenticate([FromForm] LoginForm form)
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
                        return View("Admin");
                    }
                    else
                    {
                        return View("Client");
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
