
namespace SKit.NovaPoshta.Client
{
    /// <summary>
    /// Documentation: https://developers.novaposhta.ua/
    /// </summary>
    public class NovaPoshtaGatewayOptions
    {
        public const string NovaPoshtaGatewaySection = "NovaPoshtaGateway";
        public const string DefaultApiUrl = "https://api.novaposhta.ua/v2.0/json/";

        public NovaPoshtaGatewayOptions(string apiKey, string apiUrl = DefaultApiUrl, int? timeoutSec = null)
        {
            ApiUrl = apiUrl;
            ApiKey = apiKey;
            TimeoutSec = timeoutSec;
        }

        public NovaPoshtaGatewayOptions()
        { }

        public string ApiUrl { get; set; } = DefaultApiUrl;
        public string ApiKey { get; set; } = string.Empty;
        public int? TimeoutSec { get; set; } 
    }
}
