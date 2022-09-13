
namespace SKit.NovaPoshta.Client.Requests.Address
{
    /// <summary>
    /// Allow get list of warehouses. Represents properties of 'getWarehouses' method request of 'Address' model.
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a2322f38-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    public class GetWarehousesRequestProperties
    {
        /// <summary>
        /// Gets or sets warehouses city name
        /// </summary>
        public string? CityName { get; set; }

        /// <summary>
        /// Gets or sets warehouses city reference
        /// </summary>
        public Guid? CityRef { get; set; }

        /// <summary>
        /// Gets or sets language description
        /// </summary>
        public string? Language { get; set; }

        /// <summary>
        /// Get or sets warehouses type reference
        /// </summary>
        public Guid? TypeOfWarehouseRef { get; set; }

        /// <summary>
        /// Gets or sets warehouse id
        /// </summary>
        public int? WarehouseId { get; set; }

        ///// <summary>
        ///// Gets or sets bicycle parking availability. '1' - available, '0' - not available
        ///// </summary>
        //public int BicycleParking { get; set; }

        ///// <summary>
        ///// Gets or sets post finance cashbox availability. '1' - available, '0' - not available
        ///// </summary>
        //public int PostFinance { get; set; }

        ///// <summary>
        ///// Gets or sets POS terminal availability. '1' - available, '0' - not available
        ///// </summary>
        //public int POSTerminal { get; set; }

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
