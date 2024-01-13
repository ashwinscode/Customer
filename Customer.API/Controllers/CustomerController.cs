using Microsoft.AspNetCore.Mvc;

namespace Customer.API.Controllers
{
    [ApiController]
    [Route("customer")]
    public class CustomerController : Controller
    {
        public CustomerController()
        {
            
        }

        [HttpGet]
        public string CustomerGet()
        {
            return "Name - Get";
        }

        //[HttpPost]
        //public string Post(string id)
        //{
        //    return "Name - Post";
        //}

        //[HttpPut]
        //public string Update(string id)
        //{
        //    return "Name - Update";
        //}

        //[HttpDelete]
        //public string Delete(string id)
        //{
        //    return "Name - Delete";
        //}
    }
}
