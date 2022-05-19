using Newtonsoft.Json;

namespace ECC_OCR_Microservice.Model.PurchaseSale
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PurchaseSaleModel
    {
        public PurchaseSaleModel()
        {
            Borrower = new Borrower();
            Seller = new Seller();
        }
        public Borrower Borrower { get; set; }
        public Seller Seller { get; set; }
    }
}
