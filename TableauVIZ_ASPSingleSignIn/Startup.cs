using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TableauVIZ_ASPSingleSignIn.Startup))]
namespace TableauVIZ_ASPSingleSignIn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
