using SoapDani.BusinessMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace SoapDani.BusinessAction
{
   public static class WorkersManager

    {
        public WorkersResponse GetAllWorkers()
        {

            var workers = new List<Persona>()
            {
                new Persona()
                {
                    fullName = "Dani Olivo"
                },
                new Persona()
                {
                    fullName = "Marce Palacios"
                }
            };
            return new WorkersResponse()
            {

                Workers = workers
            };
        }

    }
}