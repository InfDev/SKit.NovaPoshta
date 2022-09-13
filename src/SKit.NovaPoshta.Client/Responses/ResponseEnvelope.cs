
namespace SKit.NovaPoshta.Client.Responses
{
    /// <summary>
    /// Represents main gateway response envelope.
    /// Each gateway response contains this class fields.
    /// </summary>
    /// <typeparam name="TDataItem">Response Data</typeparam>
    internal class ResponseEnvelope<TDataItem>: BaseResponseEnvelope<TDataItem> where TDataItem : class, INpType, new()
    {
        
    }
}
