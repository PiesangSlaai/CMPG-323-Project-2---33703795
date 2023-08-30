using CMPG_323_Project_2___33703795.Models;
using Microsoft.AspNetCore.Mvc;

namespace CMPG_323_Project_2___33703795.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Customer> Get()
        {
            using (var context = new cmpg323_Project2_APIContext())
            {
                //get all customer entries
                return context.Customers.ToList();
            }
        }
    }
}