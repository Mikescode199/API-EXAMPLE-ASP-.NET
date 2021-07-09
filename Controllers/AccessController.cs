using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Apiexample.Models.WS;

namespace Apiexample.Controllers
{
    public class AccessController : ApiController
    {
        [HttpGet]
        public Reply Hello()
        {
            Reply oR = new Reply();
            oR.result = 1;
            oR.message = "Hello Mike, how's it going?";

            return oR;

        }

    }
}
