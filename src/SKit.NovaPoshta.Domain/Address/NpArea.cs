
namespace SKit.NovaPoshta.Domain.Address
{
    /// <summary>
    /// Represents regions of Ukraine
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a20ee6e4-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    public class NpArea : NpRefDescription
    {
        /// <summary>
        /// Region name in Russian
        /// </summary>
        public string DescriptionRu { get; set; } = String.Empty;

        /// <summary>
        /// REF of the city that is the regional center
        /// </summary>
        public Guid AreasCenter { get; set; }

    }
}
