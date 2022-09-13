
namespace SKit.NovaPoshta.Client.Requests.Common
{
    public class GetTypesOfPayersRequest : NpBaseRequest<EmptyMethodProperties>
    {
        public GetTypesOfPayersRequest()
        {
            modelName = NpApiModels.Common.Name;
            calledMethod = NpApiModels.Common.Methods.getTypesOfPayers;
        }
    }
}
