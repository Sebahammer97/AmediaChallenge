using AmediaChallenge.DatabaseContext;
using AmediaChallenge.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AmediaChallenge.Controllers
{
    public class AltaUsuarioController : BaseController
    {
        public AltaUsuarioController(AmediaDbContext amediaDbContext) : base(amediaDbContext) { }

        // GET: AltaUsuarioController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AltaUsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AltaUsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AltaUsuarioForm form)
        {
            try
            {
                var user = amediaDbContext.Users.FirstOrDefault(x => x.username == form.Username || x.email == form.Email);

                if (user == null)
                {
                    user = new Models.User()
                    {
                        username = form.Username,
                        password = form.Password,
                        email = form.Email,
                        name = form.Name,
                        surname = form.Surname
                    };

                    amediaDbContext.Users.Add(user);
                    amediaDbContext.SaveChanges();

                    return View();
                }
                else // Error: Username or Email already exist
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
