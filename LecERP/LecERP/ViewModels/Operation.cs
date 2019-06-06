using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP
{
    public class Operation<T> : IBaseOperation
    {
        public bool Successful { get; set; }
        public T Value { get; set; }
        public string Fail { get; set; }
        
    }

    public interface IBaseOperation
    {
        bool Successful { get; set; }
        string Fail { get; set; }
    }

    public class BaseOperation : IBaseOperation
    {
        public bool Successful { get; set; }
        public string Fail { get; set; }
    }
}
