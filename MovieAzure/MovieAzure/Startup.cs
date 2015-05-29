using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieAzure.Startup))]
namespace MovieAzure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
