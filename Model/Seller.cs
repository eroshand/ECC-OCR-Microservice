namespace ECC_OCR_Microservice.Model
{
    public class Seller:Person
    {
        public string SellerType { get; set; }
        public Attorney Attorney { get; set; }
        public Address PropertyAddress { get; set; }
        public Broker Broker { get; set; }
    }
}
