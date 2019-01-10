using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace Artemis.QueryNode.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueryController : ODataController
    {
        public class Foo { public string Name { get; set; } }
        
        public List<Foo> Get()
        {
            return new List<Foo> { new Foo { Name = "value1" } };
        }
    }
}
