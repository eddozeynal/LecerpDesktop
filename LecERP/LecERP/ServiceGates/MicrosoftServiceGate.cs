using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP
{
    class MicrosoftServiceGate<T> : IServiceGate<T> where T : new()
    {
        public Operation<T> Get(string Method)
        {
            throw new NotImplementedException();
        }

        public Operation<T> Get(string MethodName, Dictionary<string, object> parameters)
        {
            throw new NotImplementedException();

        }

        public Operation<T> Post(string MethodName)
        {
            throw new NotImplementedException();
        }

        public Operation<T> Post(string MethodName, Dictionary<string, object> parameters)
        {
            throw new NotImplementedException();
        }
    }
}
