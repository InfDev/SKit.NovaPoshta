
namespace SKit.NovaPoshta.Client.Requests.Common
{
    public class GetCargoDescriptionRequestProperties
    {
        /// <summary>
        /// Gets or sets searched cargo description name
        /// </summary>
        public string? FindByString { get; set; }

        /// <summary>
        /// Gets or sets response page number. One page contains 500 items.
        /// </summary>
        public int Page { get; set; } = 1;
    }
}
