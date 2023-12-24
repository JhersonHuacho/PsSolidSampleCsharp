using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ArdalisRating
{
    public class JsonPolicySerializer
    {
        public Policy GetPolicyFromJsonString(string jsonString)
        {
            var policy = JsonConvert.DeserializeObject<Policy>(jsonString, new StringEnumConverter());
            return policy;
        }
    }
}
