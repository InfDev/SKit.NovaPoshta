
using SKit.NovaPoshta.Client.Requests.Address;

namespace SKit.NovaPoshta.Client.Requests.Address
{
    /// <summary>
    /// Allows online search of settlement streets. Represents request for 'searchSettlementStreets' method of 'Address' model.
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1329635-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволяє онлайн пошук населених пунктів</remarks>
    public class SearchSettlementStreetsRequest : NpBaseRequest<SearchSettlementStreetsRequestProperties>
    {
        private SearchSettlementStreetsRequest()
        {
            modelName = NpApiModels.Address.Name;
            calledMethod = NpApiModels.Address.Methods.searchSettlementStreets;
        }

        public SearchSettlementStreetsRequest(SearchSettlementStreetsRequestProperties properties) : this()
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));
            methodProperties = properties;
        }
    }
}
