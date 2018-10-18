using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP.Configuration
{
    public class ConfigFileManager : IConfigManager
    {
        public string ConfigLocation
        {
            get
            {
                return "ERPConfig.json";
            }
        }

        public Operation<Dictionary<string, object>> ReadConfigSettings()
        {
            Operation<Dictionary<string, object>> res = new Operation<Dictionary<string, object>>();

            Dictionary<string, object> settings = new Dictionary<string, object>();
            try
            {
                string jsonString = GetJsonStringFromLocation();
                settings = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonString);
                if (settings != null)
                {
                    res.Successful = true;
                    res.Value = settings;
                }
            }
            catch (Exception exception)
            {
                res.Fail = exception.Message;
            }
            return res;
        }

        public string GetJsonStringFromLocation()
        {
            return System.IO.File.ReadAllText(ConfigLocation);
        }
    }
}
