
namespace SKit.NovaPoshta.Client.Requests.Common
{
    /// <summary>
    /// Allow to get recipient city time intervals. Represents 'getTimeIntervals' method from 'Common' model.
    /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a56d5c1c-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволяє отримати часові інтервали для міста одержувача</remarks>
    public class GetTimeIntervalsRequest : NpBaseRequest<GetTimeIntervalsRequestProperties>
    {
        private GetTimeIntervalsRequest()
        {
            modelName = NpApiModels.Common.Name;
            calledMethod = NpApiModels.Common.Methods.getTimeIntervals;
        }

        public GetTimeIntervalsRequest(GetTimeIntervalsRequestProperties properties) : this()
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));
            methodProperties = properties;
        }
    }
}
