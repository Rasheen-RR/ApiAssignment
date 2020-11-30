using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAssignment.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAssignment.Controllers
{


    [Route("[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        Utility utility = new Utility();

        [HttpGet]
        public dynamic get()
        {
            return utility.randomInt() ;
        }


        [HttpPost]
        public dynamic post()
        {
            return  utility.randomDouble() ;
        }


        [HttpPut]
        public dynamic put()
        {
            return "Thank you for the new number!";
        }

        [HttpDelete]
        public dynamic delete()
        {
            return utility.randomCharacter();
        }

        [HttpPatch]
        public dynamic patch()
        {
            return DateTime.Now;
        }

        [HttpOptions]
        public dynamic options()
        {
            
            return new  {GET = "Returns a random integer", 
                POST = "Returns a random double",
                PUT = "Returns a string saying 'Thank you for the new number!'",
                DELETE = "Returns a random character",
                PATCH = "Returns the current date" };
        }
    }
}
