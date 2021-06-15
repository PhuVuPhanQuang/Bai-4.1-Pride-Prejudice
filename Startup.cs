using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bai_4._1_Pride_Prejudice.Startup))]
namespace Bai_4._1_Pride_Prejudice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
