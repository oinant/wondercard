using Microsoft.ServiceFabric.Services;
using Wondercard.Client.Webapi;

namespace Wondercard.Client.Gateway
{
    public class WebService : StatelessService
    {
        protected override ICommunicationListener CreateCommunicationListener()
        {
            return new OwinCommunicationListener("api", new Startup());
        }
    }
}