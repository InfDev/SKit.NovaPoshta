
namespace SKit.NovaPoshta.Client.Requests.Address
{
    public class SearchSettlementsRequestProperties
    {
        /// <summary>
        /// Gets or sets locality name or zip code
        /// </summary>
        public string CityName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets response items count
        /// </summary>
        public int Limit { get; set; } = 50;


        /// <summary>
        /// Gets or sets response page number
        /// </summary>
        public int Page { get; set; } = 1;
    }
}
