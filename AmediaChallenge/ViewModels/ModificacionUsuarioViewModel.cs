using AmediaChallenge.DatabaseContext;
using AmediaChallenge.Forms;
using AmediaChallenge.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AmediaChallenge.ViewModels
{
    public class ModificacionUsuarioViewModel
    {
        #region Properties
        public User User { get; set; }
        public ModificacionUsuarioForm Form { get; set; }
        public SelectList UserTypeDropdown { get; set; }
        public List<SelectList> UserTypeSelectList { get; set; }
        #endregion

        #region Ctrs
        public ModificacionUsuarioViewModel(AmediaDbContext amediaDbContext, int id)
        {
            if (id > 0)
            {
                User = amediaDbContext.Users
                    .Include(x => x.userType)
                    .FirstOrDefault(x => x.id_user == id);

                if (User != null)
                {
                    List<UserType> userTypes = amediaDbContext.UserTypes.Where(x => x.is_active).ToList();
                    UserTypeDropdown = new SelectList(userTypes, "id_userType", "name");

                    Form = new ModificacionUsuarioForm();

                    Form.id_user = User.id_user;
                    Form.Email = User.email;
                    Form.Password = User.password;
                    Form.Name = User.name;
                    Form.Surname = User.surname;
                }
            }
        }
        #endregion
    }
}
