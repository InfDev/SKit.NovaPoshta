using System.Net.Http.Json;
using SKit.NovaPoshta.Client.Requests;
using SKit.NovaPoshta.Client.Requests.Common;
using SKit.NovaPoshta.Client.Requests.TrackingDocument;
using SKit.NovaPoshta.Client.Responses;
using SKit.NovaPoshta.Domain.TrackingDocument;

namespace SKit.NovaPoshta.Client.Services
{
    /// <inheritdoc/>
    public class NpTrackingDocumentService : NpBaseService, INpTrackingDocumentService
    {
        #region Constructor
        public NpTrackingDocumentService(INovaPoshtaGateway novaPoshtaGateway) : base(novaPoshtaGateway)
        {
        }

        #endregion

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpTrackingDocument>?> GetStatusDocumentsAsync(string documentNumber, string? phone = null)
        {
            var documents = new TrackingDocumentItemSearch[] {
                new TrackingDocumentItemSearch { DocumentNumber = documentNumber, Phone = phone }
            };
            var request = new GetStatusDocumentsRequest(new GetStatusDocumentsProperties(documents));
            return await GetStatusDocumentsAsync(documents);
        }

        /// <inheritdoc/>
        public async Task<IResponseEnvelope<NpTrackingDocument>?> GetStatusDocumentsAsync(TrackingDocumentItemSearch[] documents)
        {
            if (documents == null)
                throw new ArgumentNullException(nameof(documents));
            var request = new GetStatusDocumentsRequest(new GetStatusDocumentsProperties(documents));
            var response = await Gateway.Get<GetStatusDocumentsRequest, NpTrackingDocument>(request);
            return response;
        }
    }
}
