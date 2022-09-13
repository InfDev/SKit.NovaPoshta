using SKit.NovaPoshta.Domain;

namespace SKit.NovaPoshta.Domain.Address
{
    /// <summary>
    /// Represents settlements search response item.
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a0eb83ab-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Тип результату пошуку населених пунктів</remarks>
    public class NpSearchSettlements: INpType
    {
        /// <summary>
        /// Number of addresses
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// Response addresses
        /// </summary>
        public IList<Address> Addresses { get; set; } = new List<Address>();

        /// <summary>
        /// Represents find locality(city) response item
        /// </summary>
        public class Address : NpBaseRef
        {
            /// <summary>
            /// Number warehouses
            /// </summary>
            public int Warehouses { get; set; }

            /// <summary>
            /// Settlement name
            /// </summary>
            public string MainDescription { get; set; } = string.Empty;

            /// <summary>
            /// Area name
            /// </summary>
            public string Area { get; set; } = string.Empty;

            /// <summary>
            /// Region name
            /// </summary>
            public string Region { get; set; } = string.Empty;

            /// <summary>
            /// Settlement type code like: city, village etc
            /// </summary>
            public string SettlementTypeCode { get; set; } = string.Empty;

            /// <summary>
            /// Delivery city reference guid
            /// </summary>
            public Guid DeliveryCity { get; set; }

            /// <summary>
            /// Returns the settlement representation
            /// </summary>
            /// <returns>String</returns>
            public override string ToString()
            {
                return $"{SettlementTypeCode} {MainDescription}";
            }
        }
    }
}
