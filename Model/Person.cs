using Newtonsoft.Json;

namespace ECC_OCR_Microservice.Model
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public Gender Gender { get; set; }
        public Address Address { get; set; }
        //public MaritalStatus MaritalStatus { get; set; }
        public Contacts Contacts { get; set; }
    }
}
