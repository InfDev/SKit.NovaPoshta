
using SKit.NovaPoshta.Client.Requests.Address;

namespace SKit.NovaPoshta.Client.Requests.Address
{
    /// <summary>
    /// Allows online search of settlements. Represents request for 'searchSettlements' method of 'Address' model.
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a0eb83ab-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволяє онлайн пошук населених пунктів</remarks>
    public class SearchSettlementsRequest : NpBaseRequest<SearchSettlementsRequestProperties>
    {
        private SearchSettlementsRequest()
        {
            modelName = NpApiModels.Address.Name;
            calledMethod = NpApiModels.Address.Methods.searchSettlements;
        }

        public SearchSettlementsRequest(SearchSettlementsRequestProperties properties) : this()
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));
            methodProperties = properties;
        }
    }
}
