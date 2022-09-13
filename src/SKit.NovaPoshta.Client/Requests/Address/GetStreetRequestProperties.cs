
namespace SKit.NovaPoshta.Client.Requests.Address
{
    public class GetStreetRequestProperties
    {
        /// <summary>
        /// Filtering city reference key
        /// </summary>
        public Guid CityRef { get; set; }
        /// <summary>
        /// Name street
        /// </summary>
        public string? FindByString { get; set; }

        /// <summary>
        /// Gets or sets response page number
        /// </summary>
        public int Page { get; set; } = 1;

        /// <summary>
        /// Gets or sets response items count
        /// </summary>
        public int Limit { get; set; } = 50;
    }
}
