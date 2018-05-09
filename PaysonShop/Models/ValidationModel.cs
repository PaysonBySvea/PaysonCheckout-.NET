using PaysonIntegrationCO2.Models;

namespace PaysonShop.Models
{
    public class ValidationModel : Checkout
    {
        public string MerchantId { get; set; }
        public string ApiKey { get; set; }
    }
}
