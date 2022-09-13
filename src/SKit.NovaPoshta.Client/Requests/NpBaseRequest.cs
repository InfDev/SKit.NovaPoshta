
namespace SKit.NovaPoshta.Client.Requests
{
    public class NpBaseRequest
    {
        /// <summary>
        /// Gets or sets individual api key
        /// </summary>
        public string apiKey { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets using model name
        /// </summary>
        public string modelName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets called method name
        /// </summary>
        public string calledMethod { get; set; } = string.Empty;

    }

    public class NpBaseRequest<TMethodProperties> : NpBaseRequest where TMethodProperties : class, new()
    {
        /// <summary>
        /// Gets or sets request method properties
        /// </summary>
        public TMethodProperties methodProperties { get; set; } = new TMethodProperties();
    }

}
