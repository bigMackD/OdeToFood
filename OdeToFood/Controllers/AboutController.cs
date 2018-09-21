using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    [Route("about")]
    public class AboutController
    {
        [Route("phone")]
        public string Phone()
        {
            return "1+555+555+555";
        }
        [Route("adress")]
        public string Adress()
        {
            return "USA";
        }
    }
}
