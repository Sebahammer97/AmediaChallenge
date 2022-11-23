namespace AmediaChallenge.Installers
{
    public class ControllerInstaller : IInstaller
    {
        public void InstallServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddControllersWithViews();
        }
    }
}
