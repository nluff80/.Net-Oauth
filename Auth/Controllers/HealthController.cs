using System.Web.Http;

namespace Auth.Controllers
{
    public class HealthController : ApiController
    {
        [Route("api/v1/health")]
        public IHttpActionResult Get()
        {
            return Ok("running");
        }
    }
}