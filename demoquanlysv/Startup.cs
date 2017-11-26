using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(demoquanlysv.Startup))]
namespace demoquanlysv
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
