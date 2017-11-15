using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Common;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Api.Controllers
{
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        public HelloController(IHelloProvider helloProvider)
        {
            _helloprovider = helloProvider;
        }

        IHelloProvider _helloprovider;

        // GET api/values
        [HttpGet]
        public string Get()
        {
            return _helloprovider.Message;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            _helloprovider.Message = value;
        }
    }
}
