
using SKit.NovaPoshta.Client.Requests.Address;

namespace SKit.NovaPoshta.Client.Requests.Address
{
    /// <summary>
    /// Allow get list of areas. Represents properties of 'getAreas' method request of 'Address' model.
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a20ee6e4-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволяє отримати населених пунктів</remarks>
    public class GetAreasRequest : NpBaseRequest<EmptyMethodProperties>
    {
        public GetAreasRequest()
        {
            modelName = NpApiModels.Address.Name;
            calledMethod = NpApiModels.Address.Methods.getAreas;
        }
    }
}
