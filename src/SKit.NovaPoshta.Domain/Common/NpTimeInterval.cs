
namespace SKit.NovaPoshta.Domain.Common
{
    /// <summary>
    /// Represents time interval.
    /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a56d5c1c-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Часовий інтервал</remarks>
    public class NpTimeInterval : INpType
    {
        /// <summary>
        /// Time interval response number
        /// </summary>
        public string Number { get; set; } = String.Empty;

        /// <summary>
        /// Time when interval are available
        /// </summary>
        public string Start { get; set; } = String.Empty;

        /// <summary>
        /// Time when interval begins aren't be available
        /// </summary>
        public string End { get; set; } = String.Empty;
    }
}
