using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP
{
    internal class ServiceClient
    {
        string URL
        {
            get
            {
                return StaticData.CurrentConnectionConfiguration.URL;
            }
        }
        public Operation<T> Post<T>(string MethodName, Dictionary<string, object> parameters)
        {
            Operation<T> retval = new Operation<T>();
            try
            {
                //var jsonSettings = new Newtonsoft.Json.JsonSerializerSettings();
                //jsonSettings.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.MicrosoftDateFormat;
                //string upData = Newtonsoft.Json.JsonConvert.SerializeObject(parameters,jsonSettings);
                //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL + "/" + MethodName);
                //request.Method = "POST";
                //System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
                //byte[] byteArray = encoding.GetBytes(upData);
                //request.ContentLength = byteArray.Length;
                //request.ContentType = @"application/json";
                //using (Stream dataStream = request.GetRequestStream())
                //{
                //    dataStream.Write(byteArray, 0, byteArray.Length);
                //}
                //using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                //{
                //    Stream stream = response.GetResponseStream();
                //}



                RestClient client = new RestClient(URL);
                RestRequest request = new RestRequest(MethodName, Method.POST)
                {
                    JsonSerializer = NewtonsoftJsonSerializerForRestSharp.Default
                };
                request.AddJsonBody(parameters);
                request.AddHeader("GUID", StaticData.CurrentUser?.LoginSession?.Guid);
                IRestResponse<Operation<T>> response = client.Execute<Operation<T>>(request);
                retval.Successful = true;
                if (response.ResponseStatus == ResponseStatus.Error)
                {
                    retval.Fail = response.ErrorMessage.ToString();
                    retval.Successful = false;
                }
                else
                {
                    retval = response.Data;
                }
            }
            catch (Exception ex)
            {
                retval.Fail = ex.Message;
            }
            return retval;
        }
        public Operation<T> Get<T>(string MethodName, Dictionary<string, object> parameters)
        {


            Operation<T> retval = new Operation<T>();
            try
            {
                RestClient client = new RestClient(URL);
                RestRequest request = new RestRequest(MethodName, Method.GET);
                request.JsonSerializer = NewtonsoftJsonSerializerForRestSharp.Default;
                request.AddHeader("GUID", StaticData.CurrentUser?.LoginSession?.Guid);
                foreach (string key in parameters.Keys.ToList())
                {
                    request.AddParameter(key, parameters[key], ParameterType.UrlSegment);
                }
                var fullUrl = client.BuildUri(request);
                IRestResponse<Operation<T>> response = client.Execute<Operation<T>>(request);
                if (response.ResponseStatus == ResponseStatus.Error)
                {
                    retval.Fail = response.ErrorMessage.ToString();
                    retval.Successful = false;
                }
                else
                {
                    retval = response.Data;
                }

            }
            catch (Exception ex)
            {
                retval.Fail = ex.Message;
            }
            return retval;
        }
        public Operation<T> Post<T>(string MethodName)
        {
            return Post<T>(MethodName, new Dictionary<string, object>());
        }
        public Operation<T> Get<T>(string Method)
        {
            return Get<T>(Method, new Dictionary<string, object>());
        }

    }
}
