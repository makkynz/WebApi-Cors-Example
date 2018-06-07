using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace webapi.Controllers
{
    public class PooController : ApiController
    {
        // GET: api/Poo
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Poo/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Poo
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage Post([FromBody]string value)
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "hello");
            return response;
        }

        // PUT: api/Poo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Poo/5
        public void Delete(int id)
        {
        }
    }
}
