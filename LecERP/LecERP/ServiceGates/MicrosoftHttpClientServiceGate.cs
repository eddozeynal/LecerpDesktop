using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace LecERP
{
    class MicrosoftHttpClientServiceGate<T> : IServiceGate<T> where T : new()
    {
        public MicrosoftHttpClientServiceGate(string _URL)
        {
            URL = _URL;
        }
        public MicrosoftHttpClientServiceGate()
        {
            URL = StaticData.CurrentConnectionConfiguration.URL;
        }
        private string URL { get; set; }

        public Operation<T> Get(string Method)
        {
            return Get(Method, new Dictionary<string, object>());
        }

        public Operation<T> Get(string MethodName, Dictionary<string, object> parameters)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(URL + "/" + MethodName).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string responseString = responseContent.ReadAsStringAsync().Result;
                    using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(responseString)))
                    {
                        var serializer = new DataContractJsonSerializer(typeof(Operation<T>));
                        return (Operation<T>)serializer.ReadObject(ms);
                    }
                }
            }
            return null;
        }

        public Operation<T> Post(string MethodName)
        {
            return Post(MethodName, new Dictionary<string, object>());
            
        }

        string SerializeObject(object obj)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T), new DataContractJsonSerializerSettings() { UseSimpleDictionaryFormat = true });
            MemoryStream stream1 = new MemoryStream();
            ser.WriteObject(stream1, obj);
            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            string st = sr.ReadToEnd();
            return st;
        }

        public Operation<T> Post(string MethodName, Dictionary<string, object> parameters)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL + "/");
                string postBody = "{" + '"' + "item" + '"' + ":" + SerializeObject(parameters["item"]) + "}";
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsync(MethodName, new StringContent(postBody, Encoding.UTF8, "application/json")).Result;


                //var content = new FormUrlEncodedContent(parameters);




                //client.BaseAddress = new Uri(URL + "/");

                //List<KeyValuePair<string, string>> k_values = new List<KeyValuePair<string, string>>();
                //Dictionary<string, string> prms_as_string = new Dictionary<string, string>();
                //foreach (string s in parameters.Keys.ToList())
                //{
                //    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T), new DataContractJsonSerializerSettings() { UseSimpleDictionaryFormat = true });
                //    MemoryStream stream1 = new MemoryStream();
                //    ser.WriteObject(stream1, parameters[s]);
                //    stream1.Position = 0;
                //    StreamReader sr = new StreamReader(stream1);
                //    string st = sr.ReadToEnd();
                //    prms_as_string[s] = st;
                //}

                //var content = new FormUrlEncodedContent(prms_as_string);

                ////var buffer = System.Text.Encoding.UTF8.GetBytes(content.ToString());
                ////var byteContent = new ByteArrayContent(buffer);
                ////byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                ////client.DefaultRequestHeaders. = new MediaTypeHeaderValue("application/json");
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                //var response = client.PostAsync(URL + "/" +MethodName,content).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string responseString = responseContent.ReadAsStringAsync().Result;
                    using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(responseString)))
                    {
                        var serializer = new DataContractJsonSerializer(typeof(Operation<T>));
                        return (Operation<T>)serializer.ReadObject(ms);
                    }
                }
            }
            return null;
        }
    }
}
