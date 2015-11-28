using Owin;

namespace Wondercard.Client.Gateway
{
    public interface IOwinAppBuilder
    {
        void Configuration(IAppBuilder appBuilder);
    }
}