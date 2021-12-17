using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // Get api/values
        [Route("api/GetAllEmployees")]
        public IEnumerable<string> GetEmployee()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public string Put(int id, [FromBody]string value)
        {
            return "Put Api Called";
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            return "DeleteApi Called";
        }
    }
}
