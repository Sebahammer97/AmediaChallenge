using AmediaChallenge.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace AmediaChallenge.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddDbContext<AmediaDbContext>(opt =>
                opt.UseSqlServer(configuration.GetValue<string>("DbConnectionString"))
            );
        }
    }
}
