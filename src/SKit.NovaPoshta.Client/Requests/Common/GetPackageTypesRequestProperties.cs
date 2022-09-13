
namespace SKit.NovaPoshta.Client.Requests.Common
{
    public class GetPackageTypesRequestProperties
    {
        /// <summary>
        /// Gets or sets searching package type length
        /// </summary>
        public decimal? Length { get; set; }

        /// <summary>
        /// Gets or sets searching package type width
        /// </summary>
        public decimal? Width { get; set; }

        /// <summary>
        /// Gets or sets searching package type height
        /// </summary>
        public decimal? Height { get; set; }

        /// <summary>
        /// Gets or sets searching type of packing. This value are empty for all package types, so it's not require to put something here.
        /// </summary>
        public string? TypeOfPacking { get; set; }
    }
}
