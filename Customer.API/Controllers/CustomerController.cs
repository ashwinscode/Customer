using Microsoft.AspNetCore.Mvc;

namespace Customer.API.Controllers
{
    [Route("customer")]
    public class CustomerController : Controller
    {
        public CustomerController()
        {
            
        }

        [HttpGet]
        public string Get(string id)
        {
            return "Name - Get";
        }

        [HttpPost]
        public string Post(string id)
        {
            return "Name - Post";
        }

        [HttpPut]
        public string Update(string id)
        {
            return "Name - Update";
        }

        [HttpDelete]
        public string Delete(string id)
        {
            return "Name - Delete";
        }
    }
}
