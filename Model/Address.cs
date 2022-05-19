using Newtonsoft.Json;

namespace ECC_OCR_Microservice.Model
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Address
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string State { get; set; }
    }
}
