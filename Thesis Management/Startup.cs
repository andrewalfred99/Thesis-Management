using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Thesis_Management.Startup))]
namespace Thesis_Management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
