using System.Web.Http;

namespace Wondercard.Client.Webapi.Controllers
{
    /// <summary>
    ///     Default controller.
    /// </summary>
    public class DefaultController : ApiController
    {
        public IHttpActionResult Get()
        {
            return this.Ok(
            new {
                message = "hello world from wondercard!",
                number = 42
            });
        }
    }
}