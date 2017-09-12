using CSA.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CSA.WEB.API.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly ICSAService _service;
        public ValuesController(ICSAService service )
        {
            _service = service;
        }
        // GET api/values
        public async Task< IEnumerable<string>> Get()
        {
            var list= await _service.GetAllClients();
            return list.Select(i => i.Description);
           // return new string[] { "value1", "value2" };
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
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
