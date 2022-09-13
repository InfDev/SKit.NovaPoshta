
namespace SKit.NovaPoshta.Domain.Address
{
    /// <summary>
    /// Represents city
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1e6f0a7-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    public class NpCity : NpRefDescription
    {
        /// <summary>
        /// Warehouse description on Russian
        /// </summary>
        public string DescriptionRu { get; set; } = string.Empty;

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
        /// City area unique key
        /// </summary>
        public Guid Area { get; set; }

        /// <summary>
        /// Settlement type key
        /// </summary>
        public Guid SettlementType { get; set; }

        /// <summary>
        /// A sign that the city belongs to the NP branch network, otherwise it is a partner
        /// </summary>
        public bool IsBranch { get; set; }

        /// <summary>
        /// City code
        /// </summary>
        public int CityID { get; set; }

        /// <summary>
        /// Settlement type description in Ukrainian
        /// </summary>
        public string SettlementTypeDescription { get; set; } = String.Empty;

        /// <summary>
        /// Settlement type description in Russian
        /// </summary>
        public string SettlementTypeDescriptionRu { get; set; } = String.Empty;

        /// <summary>
        /// 
        /// </summary>
        public bool SpecialCashCheck { get; set; }

        /// <summary>
        /// Settlement area description on Ukrainian
        /// </summary>
        public string AreaDescription { get; set; } = String.Empty;

        /// <summary>
        /// Settlement area description on Russian
        /// </summary>
        public string AreaDescriptionRu { get; set; } = String.Empty;
    }
}
