
using SKit.NovaPoshta.Client.Requests.Address;

namespace SKit.NovaPoshta.Client.Requests.Address
{
    /// <summary>
    /// Allow get list of Ukrainian settlements. Represents properties of 'getSettlements' method request of 'Address' model.
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1c42723-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволяє отримати населенні пункти</remarks>
    public class GetSettlementsRequest : NpBaseRequest<GetSettlementsRequestProperties>
    {
        private GetSettlementsRequest()
        {
            modelName = NpApiModels.Address.Name;
            calledMethod = NpApiModels.Address.Methods.getSettlements;
        }

        public GetSettlementsRequest(GetSettlementsRequestProperties properties) : this()
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));
            methodProperties = properties;
        }
    }
}
