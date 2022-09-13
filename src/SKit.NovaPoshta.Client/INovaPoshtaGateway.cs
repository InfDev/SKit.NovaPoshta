
using SKit.NovaPoshta.Client.Requests;
using SKit.NovaPoshta.Client.Responses;

namespace SKit.NovaPoshta.Client
{
    public interface INovaPoshtaGateway
    {                
        Task<IResponseEnvelope<TResponseData>?> Get<TRequest, TResponseData>(TRequest request)
            where TRequest : NpBaseRequest
            where TResponseData : class, INpType, new();

        string GetLastRequestJson();
    }
}
