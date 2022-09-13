
namespace SKit.NovaPoshta.Client.Responses
{
    /// <summary>
    /// Represents base response envelope interface without further information.
    /// </summary>
    /// <typeparam name="TResponse">Response data type</typeparam>
    public interface IBaseResponseEnvelope<TDataItem> where TDataItem: class, INpType, new()
    {
        /// <summary>
        /// Gets or sets successfull response or not
        /// </summary>
        bool Success { get; set; }

        /// <summary>
        /// Gets or sets response body
        /// </summary>
        IList<TDataItem>? Data { get; set; }
    }
}
