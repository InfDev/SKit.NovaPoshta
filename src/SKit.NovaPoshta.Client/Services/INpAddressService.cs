using SKit.NovaPoshta.Client.Requests.Address;
using SKit.NovaPoshta.Client.Responses;

namespace SKit.NovaPoshta.Client.Services
{
    /// <summary>
    /// Represents methods collection for 'Address' model.
    /// See <see href="https://developers.novaposhta.ua/documentation">Dоcumentation</see>
    /// </summary>
    public interface INpAddressService : INpBaseService
    {
        /// <summary>
        /// Online search of settlements. Represents method 'searchSettlements' from 'Address' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a0eb83ab-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <param name="settlementName">Locality name or zip code</param>
        /// <param name="page">Response page number</param>
        /// <param name="limit">Response items count</param>
        /// <returns></returns>
        /// <remarks>Пошук населених пунктів</remarks>
        Task<IResponseEnvelope<NpSearchSettlements>?> SearchSettlementsAsync(string settlementName, int page = 1, int limit = 50);

        /// <summary>
        /// Online search of settlement streets. Represents method 'searchSettlementStreets' from 'Address' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1329635-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <param name="settlementRef">Settlement key</param>
        /// <param name="streetName">Street name</param>
        /// <param name="limit">Response items count</param>
        /// <returns></returns>
        /// <remarks>Пошук вулиць у населеному пункті</remarks>
        Task<IResponseEnvelope<NpSearchSettlementStreets>?> SearchSettlementStreetsAsync(Guid settlementRef, string streetName, int limit = 50);

        /// <summary>
        /// Get list of settlements. Represents method 'getSettlements' from 'Address' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1c42723-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <param name="properties">Method properties</param>
        /// <returns></returns>
        /// <remarks>Отримання населених пунктів</remarks>
        Task<IResponseEnvelope<NpSettlement>?> GetSettlementsAsync(GetSettlementsRequestProperties properties);

        /// <summary>
        /// Get list of warehouses. Represents method 'getWarehouses' from 'Address' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a2322f38-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <param name="properties">Method properties</param>
        /// <returns></returns>
        /// <remarks>Отримання відділень/поштоматів «Нова пошта» в розрізі населених пунктів України</remarks>
        Task<IResponseEnvelope<NpWarehouse>?> GetWarehousesAsync(GetWarehousesRequestProperties properties);

        /// <summary>
        /// Get list of areas. Represents method 'getAreas' from 'Address' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a20ee6e4-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <returns></returns>
        /// <remarks>Отримання областей України</remarks>
        Task<IResponseEnvelope<NpArea>?> GetAreasAsync();

        /// <summary>
        /// Get list of warehouse types. Represents method 'getWarehouseTypes' from 'Address' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a2587b53-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <returns></returns>
        /// <remarks>Отримання типів відділень/поштоматів «Нова пошта»</remarks>
        Task<IResponseEnvelope<NpWarehouseType>?> GetWarehouseTypesAsync();

        /// <summary>
        /// Get list of company cities. Represents method 'getCities' from 'Address' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1e6f0a7-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <param name="properties">Method properties</param>
        /// <returns></returns>
        /// <remarks>Завантажує довідник населених пунктів України, де є відділення "Нова Пошта" і можна оформити доставку на відділення, а також доставку за адресою</remarks>
        Task<IResponseEnvelope<NpCity>?> GetCitiesAsync(GetCitiesRequestProperties properties);

        /// <summary>
        /// Get list of company cities. Represents method 'getCities' from 'Address' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1e6f0a7-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <param name="findByString">Search by city name</param>
        /// <param name="cityRef">City identifier</param>
        /// <returns></returns>
        /// <remarks>Завантажує довідник населених пунктів України, де є відділення "Нова Пошта" і можна оформити доставку на відділення, а також доставку за адресою</remarks>
        Task<IResponseEnvelope<NpCity>?> GetCitiesAsync(string? findByString, Guid? cityRefy = null);

        /// <summary>
        /// Get list of city streets. Represents method 'getStreet' from 'Address' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1e6f0a7-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <param name="properties">Method properties</param>
        /// <returns></returns>
        /// <remarks>Завантажує довідник вулиць населеного пункту України</remarks>
        Task<IResponseEnvelope<NpStreet>?> GetStreetAsync(GetStreetRequestProperties properties);

        /// <summary>
        /// Get list of city streets. Represents method 'getStreet' from 'Address' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1e6f0a7-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <param name="findByString">Search by street name</param>
        /// <param name="cityRef">City identifier</param>
        /// <returns></returns>
        /// <remarks>Завантажує довідник вулиць населеного пункту України</remarks>
        Task<IResponseEnvelope<NpStreet>?> GetStreetAsync(Guid cityRef, string? findByString = null);

        /// <summary>
        /// Store the address of the recipient/sender counterparty.
        /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a155d0d9-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <remarks>Зберігти адресу контрагента отримувача/відправника</remarks>
        Task<IResponseEnvelope<NpRefDescription>?> SaveCounterpartyAddressAsync(SaveCounterpartyAddressRequestProperties properties);

        /// <summary>
        /// Update the address of the recipient/sender counterparty.
        /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a19ba934-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <remarks>Оновлення адреси контрагента отримувача/відправника</remarks>
        Task<IResponseEnvelope<NpRefDescription>?> UpdateCounterpartyAddressAsync(UpdateCounterpartyAddressRequestProperties properties);

        /// <summary>
        /// Delete the address of the recipient/sender counterparty.
        /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a177069a-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <remarks>Дозволяє видалити адресу контрагента отримувача/відправника</remarks>
        Task<IResponseEnvelope<NpBaseRef>?> DeleteCounterpartyAddressAsync(Guid addressRef);
    }
}
