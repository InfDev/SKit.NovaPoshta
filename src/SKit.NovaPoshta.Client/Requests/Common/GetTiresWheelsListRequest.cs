
namespace SKit.NovaPoshta.Client.Requests.Common
{
    /// <summary>
    /// Allow to get available tyre and wheel types. Represents 'getTiresWheelsList' of 'Common' model.
    /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a66fada0-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволяє отримати доступні типи шин і дисків.</remarks>
    public class GetTiresWheelsListRequest : NpBaseRequest<EmptyMethodProperties>
    {
        public GetTiresWheelsListRequest()
        {
            modelName = NpApiModels.Common.Name;
            calledMethod = NpApiModels.Common.Methods.getTiresWheelsList;
        }
    }
}
