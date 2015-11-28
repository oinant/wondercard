using Owin;

namespace Wondercard.Client.Webapi
{
    public interface IOwinAppBuilder
    {
        void Configuration(IAppBuilder appBuilder);
    }
}