using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP
{
    public interface IServiceGate <T> where T : new ()
    {

        Operation<T> Post(string MethodName, Dictionary<string, object> parameters);
        Operation<T> Post(string MethodName);
        Operation<T> Get(string MethodName, Dictionary<string, object> parameters);
        Operation<T> Get(string Method);
    }
}
