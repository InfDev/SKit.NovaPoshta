
namespace SKit.NovaPoshta.Domain.Address
{
    /// <summary>
    /// Represents city street
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a27c20d7-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    public class NpStreet : NpRefDescription
    {
        /// <summary>
        /// Identifier (REF) of the street type
        /// </summary>
        public string StreetsTypeRef { get; set; } = String.Empty;

        /// <summary>
        /// Street type
        /// </summary>
        public string StreetsType { get; set; } = string.Empty;

    }
}
