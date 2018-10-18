using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP
{
    public static class GateHandler
    {

        public static IServiceGate<T> GetServiceGate<T>() where T : new()
        {
            return new RestSharpServiceGate<T>();
        }
    }
}
