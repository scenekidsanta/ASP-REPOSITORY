using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMusicWiki.Domain.Startup))]
namespace MyMusicWiki.Domain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
