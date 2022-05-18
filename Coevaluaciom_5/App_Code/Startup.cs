using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Coevaluaciom_5.Startup))]
namespace Coevaluaciom_5
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
