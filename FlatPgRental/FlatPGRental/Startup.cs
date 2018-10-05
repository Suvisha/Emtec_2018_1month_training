using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlatPGRental.Startup))]
namespace FlatPGRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
