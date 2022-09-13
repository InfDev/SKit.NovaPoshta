
namespace SKit.NovaPoshta.Client.Requests.Address
{
    /// <summary>
    /// Allow get list of Ukrainian settlements. Represents properties of 'getSettlements' method request of 'Address' model.
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1c42723-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    public class GetSettlementsRequestProperties
    {
        /// <summary>
        /// Gets or sets filtering area reference key
        /// </summary>
        public Guid? AreaRef { get; set; }

        /// <summary>
        /// Gets or sets filtering address reference key
        /// </summary>
        public Guid? Ref { get; set; }

        /// <summary>
        /// Gets or sets filtering region reference key
        /// </summary>
        public Guid? RegionRef { get; set; }

        /// <summary>
        /// Gets or sets settlement name
        /// </summary>
        public string? FindByString { get; set; }

        /// <summary>
        /// Gets or sets settlement warehouses availablity
        /// </summary>
        public bool Warehouse { get; set; } = true;

        /// <summary>
        /// Gets or sets page number. Each page contains 150 settlements
        /// </summary>
        public int Page { get; set; } = 1;

        /// <summary>
        /// Gets or sets response items count
        /// </summary>
        public int Limit { get; set; } = 50;
    }
}
