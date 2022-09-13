
namespace SKit.NovaPoshta.Client.Requests.Common
{
    public class GetTypesOfPayersForRedeliveryRequest : NpBaseRequest<EmptyMethodProperties>
    {
        public GetTypesOfPayersForRedeliveryRequest()
        {
            modelName = NpApiModels.Common.Name;
            calledMethod = NpApiModels.Common.Methods.getTypesOfPayersForRedelivery;
        }
    }
}
