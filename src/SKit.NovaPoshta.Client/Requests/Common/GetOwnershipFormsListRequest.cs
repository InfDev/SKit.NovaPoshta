
namespace SKit.NovaPoshta.Client.Requests.Common
{
    /// <summary>
    /// Allow to get supported ownership forms. Represents 'getOwnershipFormsList' method response of 'Common' model.
    /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a754ff0d-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволяє отримувати підтримувані форми власності</remarks>
    public class GetOwnershipFormsListRequest : NpBaseRequest<EmptyMethodProperties>
    {
        public GetOwnershipFormsListRequest()
        {
            modelName = NpApiModels.Common.Name;
            calledMethod = NpApiModels.Common.Methods.getOwnershipFormsList;
        }
    }
}
