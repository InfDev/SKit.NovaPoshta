using System.Net.Http.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using SKit.NovaPoshta.Client.Converters;
using SKit.NovaPoshta.Client.Requests;
using SKit.NovaPoshta.Client.Requests.Address;
using SKit.NovaPoshta.Client.Requests.Common;
using SKit.NovaPoshta.Client.Responses;
using SKit.NovaPoshta.Domain.Common;

namespace SKit.NovaPoshta.Client.Services
{
    /// <inheritdoc/>
    public class NpAddressService : NpBaseService, INpAddressService
    {
        #region Constructor
        public NpAddressService(INovaPoshtaGateway novaPoshtaGateway) : base(novaPoshtaGateway)
        {
        }

        #endregion

        #region Methods

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpSearchSettlements>?> SearchSettlementsAsync(string settlementName, int page = 1, int limit = 50)
        {
            var request = new SearchSettlementsRequest(new SearchSettlementsRequestProperties
            {
                CityName = settlementName,
                Page = page,
                Limit = limit
            });
            var response = await Gateway.Get<SearchSettlementsRequest, NpSearchSettlements>(request);
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpSearchSettlementStreets>?> SearchSettlementStreetsAsync(Guid settlementRef, string streetName, int limit = 50)
        {
            var request = new SearchSettlementStreetsRequest(new SearchSettlementStreetsRequestProperties
            {
                SettlementRef = settlementRef,
                StreetName = streetName,
                Limit = limit
            });
            var response = await Gateway.Get<SearchSettlementStreetsRequest, NpSearchSettlementStreets>(request);
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpSettlement>?> GetSettlementsAsync(GetSettlementsRequestProperties properties)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));
            var request = new GetSettlementsRequest(properties);
            var response = await Gateway.Get<GetSettlementsRequest, NpSettlement>(request);
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpWarehouse>?> GetWarehousesAsync(GetWarehousesRequestProperties properties)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));
            var request = new GetWarehousesRequest(properties);
            var response = await Gateway.Get<GetWarehousesRequest, NpWarehouse>(request);
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpArea>?> GetAreasAsync()
        {
            var response = await Gateway.Get<GetAreasRequest, NpArea>(new GetAreasRequest());
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpWarehouseType>?> GetWarehouseTypesAsync()
        {
            var response = await Gateway.Get<GetWarehouseTypesRequest, NpWarehouseType>(new GetWarehouseTypesRequest());
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpCity>?> GetCitiesAsync(GetCitiesRequestProperties properties)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));
            var request = new GetCitiesRequest(properties);
            var response = await Gateway.Get<GetCitiesRequest, NpCity>(request);
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpCity>?> GetCitiesAsync(string? findByString, Guid? cityRef = null)
        {
            var properties = new GetCitiesRequestProperties
            {
                FindByString = findByString,
                Ref = cityRef
            };
            return await GetCitiesAsync(properties);
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpStreet>?> GetStreetAsync(GetStreetRequestProperties properties)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));
            var request = new GetStreetRequest(properties);
            var response = await Gateway.Get<GetStreetRequest, NpStreet>(request);
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpStreet>?> GetStreetAsync(Guid cityRef, string? findByString = null)
        {
            var properties = new GetStreetRequestProperties
            {
                FindByString = findByString,
                CityRef = cityRef
            };
            return await GetStreetAsync(properties);
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpRefDescription>?> SaveCounterpartyAddressAsync(SaveCounterpartyAddressRequestProperties properties)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));
            var request = new SaveCounterpartyAddressRequest(properties);
            var response = await Gateway.Get<SaveCounterpartyAddressRequest, NpRefDescription>(request);
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpRefDescription>?> UpdateCounterpartyAddressAsync(UpdateCounterpartyAddressRequestProperties properties)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));
            var request = new UpdateCounterpartyAddressRequest(properties);
            var response = await Gateway.Get<UpdateCounterpartyAddressRequest, NpRefDescription>(request);
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpBaseRef>?> DeleteCounterpartyAddressAsync(Guid addressRef)
        {
            var request = new DeleteCounterpartyAddressRequest(new DeleteCounterpartyAddressRequestProperties {
                Ref = addressRef
            });
            var response = await Gateway.Get<DeleteCounterpartyAddressRequest, NpBaseRef>(request);
            return response;
        }

        #endregion
    }
}
