
namespace SKit.NovaPoshta.Client.Requests.Address
{
    public class SearchSettlementStreetsRequestProperties
    {
        /// <summary>
        /// Gets or sets settlement key
        /// </summary>
        public Guid SettlementRef { get; set; }

        /// <summary>
        /// Gets or sets street name
        /// </summary>
        public string StreetName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets response items count
        /// </summary>
        public int Limit { get; set; } = 50;

        ///// <summary>
        ///// Gets or sets response page number
        ///// </summary>
        //public int Page { get; set; } = 1;
    }
}
