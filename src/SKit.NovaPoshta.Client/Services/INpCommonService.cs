using SKit.NovaPoshta.Client.Requests.Common;
using SKit.NovaPoshta.Client.Responses;

namespace SKit.NovaPoshta.Client.Services
{
    /// <summary>
    /// Represents methods collection for 'Common' and 'CommonGeneral' model.
    /// See <see href="https://developers.novaposhta.ua/documentation">Dоcumentation</see>
    /// </summary>
    public interface INpCommonService : INpBaseService
    {
        /// <summary>
        /// Get existing error descriptions. Represents 'getMessageCodeText' method of 'Common' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a6bce5a1-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <returns>List of error messages.</returns>
        /// <remarks>Отримати існуючи описи помилок</remarks>
        Task<IResponseEnvelope<NpMessageCodeText>?> GetMessageCodeTextAsync();

        /// <summary>
        /// Get list of time intervals. Represents method 'getTimeIntervals' from 'Common' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a56d5c1c-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <param name="recipientCityRef">Recipient city reference.</param>
        /// <param name="dateTime">Time when time intervals will be actual.</param>
        /// <returns>List of time intervals</returns>
        /// <remarks>Отримати часові інтервали для міста одержувача. Ідентифікатор (REF) міста обов’язково. Можна вказати дату на яку будуть отримані часові інтервали (необов'язковий параметр) за замовчанням дорівнює поточній даті, формат dd.mm.YYYY</remarks>
        Task<IResponseEnvelope<NpTimeInterval>?> GetTimeIntervalsAsync(Guid recipientCityRef, DateTime? dateTime = null);

        /// <summary>
        /// Get available cargo types. Reprensents 'getCargoTypes' method of 'Common' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a5912a1e-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <returns>List of cargo types</returns>
        Task<IResponseEnvelope<NpCargoType>?> GetCargoTypesAsync();

        /// <summary>
        /// Get list of available backward delivery cargo types. Represents 'getBackwardDeliveryCargoTypes' method response.
        /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a5b46873-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <returns>List of backward delivery cargo types</returns>
        Task<IResponseEnvelope<NpCargoType>?> GetBackwardDeliveryCargoTypesAsync();

        /// <summary>
        /// Get list of available pallets. Represents 'getPalletsList' method of 'Common' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a5dd575e-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        Task<IResponseEnvelope<NpPallet>?> GetPalletsListAsync();

        /// <summary>
        /// Get list of available payer types. Represents 'getTypesOfPayers' method of 'Common' model.
        /// See <see href="">Dоcumentation?</see>
        /// </summary>
        /// <returns>Array of payer types</returns>
        Task<IResponseEnvelope<NpPayerType>?> GetTypesOfPayersAsync();

        /// <summary>
        /// Get list of redelivery payer types. Represents 'getTypesOfPayersForRedelivery' method of 'Common' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a6247f2f-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        Task<IResponseEnvelope<NpPayerType>?> GetTypesOfPayersForRedeliveryAsync();

        /// <summary>
        /// Allow to get available package types. Represents 'getPackList' method of 'Common' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a6492db4-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <param name="height">Searching package type height</param>
        /// <param name="length">Searching package type length</param>
        /// <param name="width">Searching package type width</param>
        /// <returns>Array of available package types</returns>
        Task<IResponseEnvelope<NpPackageType>?> GetPackListAsync(decimal? length = null, decimal? height = null, decimal? width = null);

        /// <summary>
        /// Allow to get available package types. Represents 'getPackList' method of 'Common' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a6492db4-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <param name="properties">Method properties</param>
        /// <returns>Array of available package types</returns>
        Task<IResponseEnvelope<NpPackageType>?> GetPackListAsync(GetPackageTypesRequestProperties properties);

        /// <summary>
        /// Allow to get available tyre wheel types. Represents 'getTiresWheelsList' of 'Common' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a66fada0-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <returns>Array of available tyres & wheels types</returns>
        Task<IResponseEnvelope<NpTyreWheelType>?> GetTiresWheelsListAsync();

        /// <summary>
        /// Allow to get possible cargo description. Represents 'getCargoDescriptionList' method of 'Common' model.
        /// Searched description must begin like searched description. Search aren't work like 'Contains' method.
        /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a697db47-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <param name="description">Searched cargo description</param>
        /// <param name="page">Response page number. Each page contains 500 items.</param>
        /// <returns>Array of cargo descriptions</returns>
        Task<IResponseEnvelope<NpCargoDescription>?> GetCargoDescriptionListAsync(int page = 1, string? findByString = null);

        /// <summary>
        /// Allow to get possible delivery service types like door - door, warehouse - warehouse and so on. Represents 'getServiceTypes' method of 'Common' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a6e189f7-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <returns>Array of supported delivery service types</returns>
        Task<IResponseEnvelope<NpServiceType>?> GetServiceTypesAsync();

        /// <summary>
        /// Allow to get existing counterparty types. Represents 'getTypesOfCounterparties' method of 'Common' model.
        /// See <see href="">Dоcumentation?</see>
        /// </summary>
        /// <returns>Array of counterparty types</returns>
        Task<IResponseEnvelope<NpCounterpartyType>?> GetTypesOfCounterpartiesAsync();

        /// <summary>
        /// Allow to get 'Nova Poshta' service payment forms. Represents 'getPaymentForms' method of 'Common' model.
        /// See <see href="">Dоcumentation?</see>
        /// </summary>
        /// <returns>Array of payment forms</returns>
        Task<IResponseEnvelope<NpPaymentForm>?> GetPaymentFormsAsync();

        /// <summary>
        /// Allow to get supported ownership forms. Represents 'getOwnershipFormsList' method response of 'Common' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a754ff0d-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <returns>Array of supported ownership forms</returns>
        Task<IResponseEnvelope<NpOwnershipForm>?> GetOwnershipFormsListAsync();
    }
}
