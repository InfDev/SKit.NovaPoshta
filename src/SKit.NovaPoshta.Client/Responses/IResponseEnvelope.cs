
namespace SKit.NovaPoshta.Client.Responses
{
    /// <summary>
    /// Represents base nova poshta response interface
    /// </summary>
    /// <typeparam name="TDataItem"></typeparam>
    public interface IResponseEnvelope<TDataItem> : IBaseResponseEnvelope<TDataItem>
        where TDataItem : class, INpType, new()
    {
        /// <summary>
        /// Gets first data value if response has success result and data has values quantity higher than zero
        /// </summary>
        TDataItem? FirstOrDefault();
    }
}
