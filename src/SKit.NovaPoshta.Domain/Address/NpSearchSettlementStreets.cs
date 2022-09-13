using SKit.NovaPoshta.Domain;

namespace SKit.NovaPoshta.Domain.Address
{
    /// <summary>
    /// Represents search street response.
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1329635-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Тип результату пошуку населених пунктів</remarks>
    public class NpSearchSettlementStreets: INpType
    {
        /// <summary>
        /// Number addresses
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// Response addresses
        /// </summary>
        public IList<Address> Addresses { get; set; } = new List<Address>();

        /// <summary>
        /// Represents find locality(city) response item
        /// </summary>
        public class Address : INpType
        {
            /// <summary>
            /// Settlement key
            /// </summary>
            public Guid SettlementRef { get; set; }

            /// <summary>
            /// Settlement street key
            /// </summary>
            public Guid SettlementStreetRef { get; set; }


            /// <summary>
            /// Settlement street name in Ukrainian
            /// </summary>
            public string SettlementStreetDescription { get; set; } = string.Empty;

            /// <summary>
            /// Street full description
            /// </summary>
            public string Present { get; set; } = string.Empty;

            /// <summary>
            /// Streets type guid
            /// </summary>
            public Guid StreetsType { get; set; }

            /// <summary>
            /// Settlement street name in Russian
            /// </summary>
            public string StreetsTypeDescription { get; set; } = string.Empty;

            public Coordinates Location { get; set; } = new Coordinates();

            /// <summary>
            /// Settlement street name in Russian
            /// </summary>
            public string StreetsTypeDescriptionRu { get; set; } = string.Empty;

            /// <summary>
            /// Street location. Latitude and longitude on the map
            /// </summary>
            public class Coordinates
            {
                public double lat { get; set; }
                public double lon { get; set; }
            }


            /// <summary>
            /// Returns the settlement street representation
            /// </summary>
            /// <returns>String</returns>
            public override string ToString()
            {
                return $"{SettlementStreetDescription}";
            }
        }
    }
}
