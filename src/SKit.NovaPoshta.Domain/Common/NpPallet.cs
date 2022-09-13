
namespace SKit.NovaPoshta.Domain.Common
{
    /// <summary>
    /// Represents pallet.
    /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a5dd575e-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Вид палети</remarks>
    public class NpPallet : NpRefDescription
    {
        /// <summary>
        /// Pallet description on Russian.
        /// </summary>
        public string DescriptionRu { get; set; } = String.Empty;

        /// <summary>
        /// Pallet weight
        /// </summary>
        public decimal Weight { get; set; }

    }
}
