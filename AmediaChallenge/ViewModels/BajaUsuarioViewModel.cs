using AmediaChallenge.Forms;

namespace AmediaChallenge.ViewModels
{
    public class BajaUsuarioViewModel
    {
        #region Properties
        public BajaUsuarioForm Form { get; set; }
        #endregion

        #region Ctrs
        public BajaUsuarioViewModel() 
        {
            Form = new BajaUsuarioForm();
        }
        #endregion
    }
}
