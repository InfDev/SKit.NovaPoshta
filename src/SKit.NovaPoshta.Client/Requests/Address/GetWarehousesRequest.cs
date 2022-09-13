
namespace SKit.NovaPoshta.Client.Requests.Address
{
    /// <summary>
    /// Allow get list of warehouses. Represents properties of 'getWarehouses' method request of 'Address' model.
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a2322f38-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволяє отримати відділення/поштомати</remarks>
    public class GetWarehousesRequest : NpBaseRequest<GetWarehousesRequestProperties>
    {
        private GetWarehousesRequest()
        {
            modelName = NpApiModels.Address.Name;
            calledMethod = NpApiModels.Address.Methods.getWarehouses;
        }

        public GetWarehousesRequest(GetWarehousesRequestProperties properties) : this()
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));
            methodProperties = properties;
        }
    }
}
