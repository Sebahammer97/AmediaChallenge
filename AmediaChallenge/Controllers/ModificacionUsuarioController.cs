using AmediaChallenge.DatabaseContext;
using AmediaChallenge.Forms;
using AmediaChallenge.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AmediaChallenge.Controllers
{
    public class ModificacionUsuarioController : BaseController
    {
        public ModificacionUsuarioController(AmediaDbContext amediaDbContext) : base(amediaDbContext) { }

        public IActionResult Index()
        {
            return View();
        }

        // GET: AltaUsuarioController/Edit/5
        public ActionResult ModificacionUsuario(int id)
        {
            ModificacionUsuarioViewModel viewModel = new ModificacionUsuarioViewModel(amediaDbContext, id);

            return View("ModificacionUsuario", viewModel);
        }

        // POST: AltaUsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ModificacionUsuarioForm form)
        {
            try
            {
                var user = amediaDbContext.Users.FirstOrDefault(x => x.id_user == id);

                if (user != null)
                {
                    user.email = form.Email;
                    user.password = form.Password;
                    user.name = form.Name;
                    user.surname= form.Surname;

                    amediaDbContext.Update(user);
                    amediaDbContext.SaveChanges();
                }
                else
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
