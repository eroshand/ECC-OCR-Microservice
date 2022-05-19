using Newtonsoft.Json;

namespace ECC_OCR_Microservice.Model
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Borrower:Person
    {
        public string BorrowerType { get; set; }  
    }
}
