using System;
using System.Net.Http.Json;
using SKit.NovaPoshta.Client.Requests;
using SKit.NovaPoshta.Client.Requests.Common;
using SKit.NovaPoshta.Client.Responses;
using SKit.NovaPoshta.Domain.Common;

namespace SKit.NovaPoshta.Client.Services
{
    /// <summary>
    /// Represents methods collection for 'Common' model. Contains method to get 'Nova Poshta' service reference books.
    /// See <see href="https://developers.novaposhta.ua/documentation">Dоcumentation</see>
    /// </summary>
    public class NpCommonService : NpBaseService, INpCommonService
    {
        #region Constructor
        public NpCommonService(INovaPoshtaGateway novaPoshtaGateway) : base(novaPoshtaGateway)
        {
        }

        #endregion

        #region Methods

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpMessageCodeText>?> GetMessageCodeTextAsync()
        {
            var response = await Gateway.Get<GetMessageCodeTextRequest, NpMessageCodeText>(new GetMessageCodeTextRequest());
            return response;
        }

        public async Task<IResponseEnvelope<NpTimeInterval>?> GetTimeIntervalsAsync(Guid recipientCityRef, DateTime? dateTime = null)
        {
            var request = new GetTimeIntervalsRequest(new GetTimeIntervalsRequestProperties(recipientCityRef, dateTime));
            return await Gateway.Get<GetTimeIntervalsRequest, NpTimeInterval>(request);
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpCargoType>?> GetCargoTypesAsync()
        {
            var response = await Gateway.Get<GetCargoTypesRequest, NpCargoType>(new GetCargoTypesRequest());
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpCargoType>?> GetBackwardDeliveryCargoTypesAsync()
        {
            var response = await Gateway.Get<GetBackwardDeliveryCargoTypesRequest, NpCargoType>(new GetBackwardDeliveryCargoTypesRequest());
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpPallet>?> GetPalletsListAsync()
        {
            var response = await Gateway.Get<GetPalletsListRequest, NpPallet>(new GetPalletsListRequest());
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpPayerType>?> GetTypesOfPayersAsync()
        {
            var response = await Gateway.Get<GetTypesOfPayersRequest, NpPayerType>(new GetTypesOfPayersRequest());
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpPayerType>?> GetTypesOfPayersForRedeliveryAsync()
        {
            var response = await Gateway.Get<GetTypesOfPayersForRedeliveryRequest, NpPayerType>(new GetTypesOfPayersForRedeliveryRequest());
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpPackageType>?> GetPackListAsync(decimal? length = null, decimal? height = null, decimal? width = null)
        {
            var properties = new GetPackageTypesRequestProperties
            {
                Length = length,
                Height = height,
                Width = width
            };
            var response = await GetPackListAsync(properties);
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpPackageType>?> GetPackListAsync(GetPackageTypesRequestProperties properties)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));
            var request = new GetPackageTypesRequest(properties);
            var response = await Gateway.Get<GetPackageTypesRequest, NpPackageType>(request);
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpTyreWheelType>?> GetTiresWheelsListAsync()
        {
            var response = await Gateway.Get<GetTiresWheelsListRequest, NpTyreWheelType>(new GetTiresWheelsListRequest());
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpCargoDescription>?> GetCargoDescriptionListAsync(int page = 1, string? findByString = null)
        {
            var request = new GetCargoDescriptionRequest(new GetCargoDescriptionRequestProperties
            {
                Page = page,
                FindByString = findByString
            });
            var response = await Gateway.Get<GetCargoDescriptionRequest, NpCargoDescription>(request);
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpServiceType>?> GetServiceTypesAsync()
        {
            var response = await Gateway.Get<GetServiceTypesRequest, NpServiceType>(new GetServiceTypesRequest());
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpCounterpartyType>?> GetTypesOfCounterpartiesAsync()
        {
            var response = await Gateway.Get<GetTypesOfCounterpartiesRequest, NpCounterpartyType>(new GetTypesOfCounterpartiesRequest());
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpPaymentForm>?> GetPaymentFormsAsync()
        {
            var response = await Gateway.Get<GetPaymentFormsRequest, NpPaymentForm>(new GetPaymentFormsRequest());
            return response;
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpOwnershipForm>?> GetOwnershipFormsListAsync()
        {
            var response = await Gateway.Get<GetOwnershipFormsListRequest, NpOwnershipForm>(new GetOwnershipFormsListRequest());
            return response;
        }
        #endregion
    }
}
