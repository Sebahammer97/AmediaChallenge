using AmediaChallenge.DatabaseContext;
using AmediaChallenge.Forms;
using AmediaChallenge.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AmediaChallenge.ViewModels
{
    public class AltaUsuarioViewModel
    {
        #region Properties        
        public AltaUsuarioForm Form { get; set; }
        public SelectList UserTypeDropdown { get; set; }
        public List<SelectList> UserTypeSelectList { get; set; }
        #endregion

        #region Ctrs
        public AltaUsuarioViewModel(AmediaDbContext amediaDbContext)
        {
            Form = new AltaUsuarioForm();

            List<UserType> userTypes = amediaDbContext.UserTypes.Where(x => x.is_active).ToList();
            UserTypeDropdown = new SelectList(userTypes, "id_userType", "name");
        }
        #endregion
    }
}
