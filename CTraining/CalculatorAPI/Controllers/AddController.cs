using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculatorAPI.Controllers
{
    public class AddController : ApiController
    {
        [Route(""), HttpGet]
        public int Addition()
        {
            int result;
            result = 2+4;
            return result;
        }
        /*public int Subtraction(int first, int second)
        {
            return adder.Subtraction(first, second);
        }*/
        /*[Route("reuben/Add2"),HttpGet]
        public int Add(int first, int second)
        {
            return adder.Addition(first, second);
        }
        [Route("reuben/Add2"), HttpPost]
        public int Add3(int first, int second)
        {
            return adder.Addition(first, second);
        }*/

    }
}
