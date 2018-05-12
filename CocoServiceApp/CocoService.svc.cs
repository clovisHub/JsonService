using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CocoServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CocoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CocoService.svc or CocoService.svc.cs at the Solution Explorer and start debugging.
    public class CocoService : ICocoService
    {
        public string lakisaMutu(string mutu)
        {
            return "Mutu yeyo : "+ mutu;
        }
    }
}
