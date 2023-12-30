using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapDani.BusinessMessage
{
    public class WorkersResponse
    {
        public List<Persona> Workers { get; set;}

        public bool ActionResult { get; set;}

        public  string Error { get; set;}
    }
}