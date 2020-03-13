using SalveMariaJf.Models;
using System.Net;
using System.Web.Http;

namespace SalveMariaJf.Controllers
{
    public class SosController : ApiController
    {
        [HttpPost]
        public HttpStatusCode SaveMe(Pessoa pessoa)
        {
            var email = new Email();
            if (email.Send(pessoa))
                return HttpStatusCode.OK;

            return HttpStatusCode.BadRequest;
        }

        [HttpPost]
        public IHttpActionResult Add()
        {
            //Creates a Movie based on the Title
            return Ok();
        }
    }
}
