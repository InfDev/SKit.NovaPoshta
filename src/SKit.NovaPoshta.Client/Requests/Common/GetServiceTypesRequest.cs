
namespace SKit.NovaPoshta.Client.Requests.Common
{
    /// <summary>
    /// Allow to get possible delivery service types like door - door, warehouse - warehouse and so on. Represents 'getServiceTypes' method of 'Common' model.
    /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a6e189f7-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволяє отримати можливі типи послуг доставки, такі як двері - двері, склад - склад і так далі.</remarks>
    public class GetServiceTypesRequest : NpBaseRequest<EmptyMethodProperties>
    {
        public GetServiceTypesRequest()
        {
            modelName = NpApiModels.Common.Name;
            calledMethod = NpApiModels.Common.Methods.getServiceTypes;
        }
    }
}
