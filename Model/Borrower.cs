using Newtonsoft.Json;

namespace ECC_OCR_Microservice.Model
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Borrower:Person
    {
        public string BorrowerType { get; set; }
        public string CurrentDeedInformation { get; set; }
        public double PurchasePrice { get; set; }
        public double Deposit { get; set; }
        public DateTime CloseDate { get; set; }
        public double LoanAmount { get; set; }
        public DateTime MortgageContigencyDate { get; set; }
        public Attorney Attorney { get; set; }
        public Broker Broker { get; set; }
    }
}
