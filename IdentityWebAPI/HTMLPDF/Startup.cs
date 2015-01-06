using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HTMLPDF.Startup))]
namespace HTMLPDF
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
