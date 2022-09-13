
namespace SKit.NovaPoshta.Client.Requests.Address
{
    /// <summary>
    /// Allow get list of warehouse types. Represents properties of 'getWarehouseTypes' method request of 'Address' model.
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a2587b53-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволяє отримати типи відділень/поштоматів</remarks>
    public class GetWarehouseTypesRequest : NpBaseRequest<EmptyMethodProperties>
    {
        public GetWarehouseTypesRequest()
        {
            modelName = NpApiModels.Address.Name;
            calledMethod = NpApiModels.Address.Methods.getWarehouseTypes;
        }
    }
}
