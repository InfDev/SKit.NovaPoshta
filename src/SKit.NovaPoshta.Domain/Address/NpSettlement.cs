using SKit.NovaPoshta.Domain;

namespace SKit.NovaPoshta.Domain.Address
{
    /// <summary>
    /// Represents Ukrainian settlement.
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1c42723-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    public class NpSettlement : NpBaseRef
    {
        /// <summary>
        /// Settlement type key
        /// </summary>
        public Guid SettlementType { get; set; }

        /// <summary>
        /// Setlltement latitude
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Settlement longitude
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// City name on Ukrainian
        /// </summary>
        public string Description { get; set; } = String.Empty;

        /// <summary>
        /// City name on Russian
        /// </summary>
        public string DescriptionRu { get; set; } = String.Empty;

        /// <summary>
        /// City name translit
        /// </summary>
        public string DescriptionTranslit { get; set; } = String.Empty;

        /// <summary>
        /// Settlement type description on Ukrainian
        /// </summary>
        public string SettlementTypeDescription { get; set; } = String.Empty;

        /// <summary>
        /// Settlement type description on Russian
        /// </summary>
        public string SettlementTypeDescriptionRu { get; set; } = String.Empty;

        /// <summary>
        /// Settlement type name translit
        /// </summary>
        public string SettlementTypeDescriptionTranslit { get; set; } = String.Empty;

        /// <summary>
        /// Settlement type description on English
        /// </summary>
        public string SettlementTypeDescriptionEn { get; set; } = String.Empty;
        /// <summary>
        /// Region unique key
        /// </summary>
        public Guid? Region { get; set; }

        /// <summary>
        /// Settlement region description on Ukrainian
        /// </summary>
        public string RegionDescription { get; set; } = String.Empty;

        /// <summary>
        /// Settlement region description on Russian
        /// </summary>
        public string RegionDescriptionRu { get; set; } = String.Empty;

        /// <summary>
        /// Region description translit
        /// </summary>
        public string RegionsDescriptionTranslit { get; set; } = String.Empty;

        /// <summary>
        /// Area unique key
        /// </summary>
        public Guid Area { get; set; }

        /// <summary>
        /// Settlement area description on Ukrainian
        /// </summary>
        public string AreaDescription { get; set; } = String.Empty;

        /// <summary>
        /// Settlement area description on Russian
        /// </summary>
        public string AreaDescriptionRu { get; set; } = String.Empty;

        /// <summary>
        /// Settlement area description translit
        /// </summary>
        public string AreaDescriptionTranslit { get; set; } = String.Empty;

        /// <summary>
        /// Post Index #1
        /// </summary>
        public string Index1 { get; set; } = String.Empty;

        /// <summary>
        /// Post Index #2
        /// </summary>
        public string Index2 { get; set; } = String.Empty;

        /// <summary>
        /// COATSU settlement index
        /// </summary>
        public string IndexCOATSU1 { get; set; } = String.Empty;

        /// <summary>
        /// Monday is work day
        /// </summary>
        public bool Delivery1 { get; set; }

        /// <summary>
        /// Tuesday is work day
        /// </summary>
        public bool Delivery2 { get; set; }

        /// <summary>
        /// Wednesday is work day
        /// </summary>
        public bool Delivery3 { get; set; }

        /// <summary>
        /// Thursday is work day
        /// </summary>
        public bool Delivery4 { get; set; }

        /// <summary>
        /// Friday is work day
        /// </summary>
        public bool Delivery5 { get; set; }

        /// <summary>
        /// Saturday is work day
        /// </summary>
        public bool Delivery6 { get; set; }

        /// <summary>
        /// Sunday is work day
        /// </summary>
        public bool Delivery7 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool SpecialCashCheck { get; set; }

        /// <summary>
        /// Availability of Warehouses
        /// </summary>
        public bool Warehouse { get; set; }

        /// <summary>
        /// Represents the settlement
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return $"{SettlementTypeDescription} {Description}";
        }
    }
}
