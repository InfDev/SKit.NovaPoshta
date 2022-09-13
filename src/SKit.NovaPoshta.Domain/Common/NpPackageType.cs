
namespace SKit.NovaPoshta.Domain.Common
{
    /// <summary>
    /// Represents package type.
    /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a6492db4-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Тип упаковки вантажу</remarks>
    public class NpPackageType : NpRefDescription
    {
        /// <summary>
        /// Package type description on Ukrainian.
        /// </summary>
        public string DescriptionRu { get; set; } = string.Empty;

        /// <summary>
        /// Package type length. In millimeters.
        /// </summary>
        public decimal Length { get; set; }

        /// <summary>
        /// Package type height. In millimeters.
        /// </summary>
        public decimal Height { get; set; }

        /// <summary>
        /// Package type width. In millimeters.
        /// </summary>
        public decimal Width { get; set; }

        /// <summary>
        /// Packaging volume.
        /// </summary>
        public decimal VolumetricWeight { get; set; }

        public int PackagingForPlace { get; set; }

        /// <summary>
        /// Type of packing. Unusing.
        /// </summary>
        public string TypeOfPacking { get; set; } = string.Empty;


    }
}
