namespace ECC_OCR_Microservice.Model
{
    public class Attorney: Person
    {
        public Contacts Contacts { get; set; }
        public Address Address { get; set; }
        public string Company { get; set; }
    }
}
