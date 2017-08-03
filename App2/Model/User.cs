using Newtonsoft.Json;

namespace App2.Model
{
    public class Id
    {
        [JsonProperty(PropertyName = "$oid")]
        public string id { get; set; }
    }

    public class User
    {
        public Id _id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public MapRoute maproute { get; set; }
    }
   
    public class MapRoute
    {
        public string name { get; set; }
        public int count { get; set; }
    }
}