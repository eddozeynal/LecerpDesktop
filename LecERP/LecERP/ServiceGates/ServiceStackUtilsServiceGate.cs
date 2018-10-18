using ServiceStack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace LecERP
{
    class ServiceStackUtilsServiceGate<T> : IServiceGate<T> where T : new()
    {
        public ServiceStackUtilsServiceGate()
        {
            URL = StaticData.CurrentConnectionConfiguration.URL;
        }

        public ServiceStackUtilsServiceGate(string _URL)
        {
            URL = _URL;
        }
        private string URL { get; set; }
        public Operation<T> Get(string Method)
        {
            return Get(Method, new Dictionary<string, object>());
        }

        public Operation<T> Get(string MethodName, Dictionary<string, object> parameters)
        {
            try
            {
                var client = new JsonServiceClient(URL);
                Operation<T> op_response = client.Get<Operation<T>>(MethodName);
                return op_response;
            }
            catch (Exception ex)
            {
                return new Operation<T>() { Fail = ex.Message };
            }
           
        }

        public Operation<T> Post(string MethodName)
        {
            return Post(MethodName, new Dictionary<string, object>());
        }

        public Operation<T> Post(string MethodName, Dictionary<string, object> parameters)
        {
            try
            {
                var client = new JsonServiceClient(URL);
                MemoryStream stream1 = new MemoryStream();
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T), new DataContractJsonSerializerSettings(){ UseSimpleDictionaryFormat = true });
                
                ser.WriteObject(stream1, parameters["item"]);
                stream1.Position = 0;
                StreamReader sr = new StreamReader(stream1);
                string s = sr.ReadToEnd();//new { item = (Item)parameters["item"] }
                //"item": { }
                s = "\"" + s;
                s = "item" + s;
                s = "\":{" + s;
                s = s + "}";
                Operation<T> op_response = client.Post<Operation<T>>(MethodName, new { Item = parameters["item"] });
                return op_response;
            }
            catch (Exception ex)
            {
                return new Operation<T>() { Fail = ex.Message };
            }
        }
    }
}
