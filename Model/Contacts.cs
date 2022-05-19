using Newtonsoft.Json;

namespace ECC_OCR_Microservice.Model
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Contacts
    {
        public string CellPhone { get; set; }
        public string WorkPhone { get; set; }
        public string HomePhone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
    }
}
