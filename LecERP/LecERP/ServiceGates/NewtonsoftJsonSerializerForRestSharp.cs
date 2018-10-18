using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace LecERP
{
    class NewtonsoftJsonSerializerForRestSharp : RestSharp.Serializers.ISerializer, RestSharp.Deserializers.IDeserializer
    {
        private Newtonsoft.Json.JsonSerializer serializer;

        public NewtonsoftJsonSerializerForRestSharp(Newtonsoft.Json.JsonSerializer serializer)
        {
            this.serializer = serializer;
        }

        public string ContentType
        {
            get { return "application/json"; } // Probably used for Serialization?
            set { }
        }

        public string DateFormat { get; set; }

        public string Namespace { get; set; }

        public string RootElement { get; set; }

        public string Serialize(object obj)
        {
            using (var stringWriter = new StringWriter())
            {
                using (var jsonTextWriter = new JsonTextWriter(stringWriter))
                {
                    serializer.Serialize(jsonTextWriter, obj);
                    return stringWriter.ToString();
                }
            }
        }

        public T Deserialize<T>(RestSharp.IRestResponse response)
        {
            var content = response.Content;
            using (var stringReader = new StringReader(content))
            {
                using (var jsonTextReader = new JsonTextReader(stringReader))
                {
                    return serializer.Deserialize<T>(jsonTextReader);
                }
            }
        }

        public string Serialize<TEntity>(TEntity entity) where TEntity : class, new()
        {
            throw new NotImplementedException();
        }

        public TEntity Deserialize<TEntity>(string entity) where TEntity : class, new()
        {
            throw new NotImplementedException();
        }

        public static NewtonsoftJsonSerializerForRestSharp Default
        {
            get
            {
                return new NewtonsoftJsonSerializerForRestSharp(new Newtonsoft.Json.JsonSerializer()
                {
                    NullValueHandling = NullValueHandling.Ignore,DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
                });
            }
        }
    }
}
