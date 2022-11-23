using AmediaChallenge.DatabaseContext;
using Microsoft.AspNetCore.Mvc;

namespace AmediaChallenge.Controllers
{
    public class BajaUsuarioController : BaseController
    {
        public BajaUsuarioController(AmediaDbContext amediaDbContext) : base(amediaDbContext) { }

        public IActionResult Index()
        {
            return View();
        }

        // GET: AltaUsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            var user = amediaDbContext.Users.FirstOrDefault(x => x.id_user == id);

            if (user == null)
            {
                return NotFound();
            }

            amediaDbContext.Remove(user);
            amediaDbContext.SaveChanges();

            return View();
        }

        // POST: AltaUsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
