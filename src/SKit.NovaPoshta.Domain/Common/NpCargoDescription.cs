
namespace SKit.NovaPoshta.Domain.Common
{
    /// <summary>
    /// Represents cargo description.
    /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a697db47-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    /// <remarks>Опис вантажу</remarks>
    public class NpCargoDescription : NpRefDescription
    {
        /// <summary>
        /// Cargo description RU
        /// </summary>
        public string DescriptionRu { get; set; } = string.Empty;
    }
}
