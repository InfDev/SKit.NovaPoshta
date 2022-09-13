
namespace SKit.NovaPoshta.Client.Requests.TrackingDocument
{
    /// <summary>
    /// Allow to get recipient city time intervals. Represents 'getTimeIntervals' method from 'Common' model.
    /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a56d5c1c-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволяє отримати часові інтервали для міста одержувача</remarks>
    public class GetStatusDocumentsRequest : NpBaseRequest<GetStatusDocumentsProperties>
    {
        private GetStatusDocumentsRequest()
        {
            modelName = NpApiModels.TrackingDocument.Name;
            calledMethod = NpApiModels.TrackingDocument.Methods.getStatusDocuments;
        }

        public GetStatusDocumentsRequest(GetStatusDocumentsProperties properties) : this()
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));
            methodProperties = properties;
        }
    }
}
