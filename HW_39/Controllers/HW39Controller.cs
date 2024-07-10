using Microsoft.AspNetCore.Mvc;

namespace HW_39.Controllers
{
    [ApiController]
    [Route("controller")]
    public class HW39Controller //: Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Дима Гей";
        }
        
      
    }
}
