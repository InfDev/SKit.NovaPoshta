
namespace SKit.NovaPoshta.Domain.Common
{
    /// <summary>
    /// Represents tyre wheel type.
    /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a66fada0-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Тип вантажу шини-диски</remarks>
    public class NpTyreWheelType : NpRefDescription
    {
        /// <summary>
        /// Tyre wheels type description on Russian.
        /// </summary>
        public string DescriptionRu { get; set; } = string.Empty;

        /// <summary>
        /// Tyre wheels type weight
        /// </summary>
        public decimal Weight { get; set; }

        /// <summary>
        /// Tyre weels type. It's tyres or wheels
        /// </summary>
        public string DescriptionType { get; set; } = string.Empty;
    }
}
