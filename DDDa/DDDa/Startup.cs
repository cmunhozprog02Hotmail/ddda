using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DDDa.Startup))]
namespace DDDa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
