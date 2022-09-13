using SKit.NovaPoshta.Client.Requests;
using SKit.NovaPoshta.Client.Requests.TrackingDocument;
using SKit.NovaPoshta.Client.Responses;

namespace SKit.NovaPoshta.Client.Services
{
    /// <summary>
    /// Represents methods collection for 'TrackingDocument' model.
    /// See <see href="https://developers.novaposhta.ua/view/model/a99d2f28-8512-11ec-8ced-005056b2dbe1/method/a9ae7bc9-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    public interface INpTrackingDocumentService : INpBaseService
    {
        /// <summary>
        /// Getting the status of waybill. Represents method 'getStatusDocuments' from 'TrackingDocument' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a99d2f28-8512-11ec-8ced-005056b2dbe1/method/a9ae7bc9-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <param name="documentNumber">Number of waybill</param>
        /// <param name="phone">Phone number of the recipient/sender.
        /// When you enter a phone number, you can get the following information: sender or recipient data, phone number</param>
        /// <returns></returns>
        /// <remarks>Отримання состояния товарно-транспортної накладної</remarks>
        Task<IResponseEnvelope<NpTrackingDocument>?> GetStatusDocumentsAsync(string documentNumber, string? phone = null);

        /// <summary>
        /// Getting the status of waybills. Represents method 'getStatusDocuments' from 'TrackingDocument' model.
        /// See <see href="https://developers.novaposhta.ua/view/model/a99d2f28-8512-11ec-8ced-005056b2dbe1/method/a9ae7bc9-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
        /// </summary>
        /// <param name="getDocumentsProperties"></param>
        /// <returns></returns>
        /// <remarks>Отримання состояния товарно-транспортних накладних</remarks>
        Task<IResponseEnvelope<NpTrackingDocument>?> GetStatusDocumentsAsync(TrackingDocumentItemSearch[] documents);
    }
}
