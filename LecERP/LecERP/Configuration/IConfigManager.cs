using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP.Configuration
{
    public interface IConfigManager
    {
        string ConfigLocation { get; }
        string GetJsonStringFromLocation();
        Operation<Dictionary<string, object>> ReadConfigSettings();
    }
}
