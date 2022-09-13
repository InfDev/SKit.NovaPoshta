
namespace SKit.NovaPoshta.Client.Requests.Common
{
    /// <summary>
    /// Allow to get 'Nova Poshta' service payment forms. Represents 'getPaymentForms' method of 'Common' model.
    /// See <see href="">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволяє отримати платіжні бланки служби «Нова Пошта»</remarks>
    public class GetPaymentFormsRequest : NpBaseRequest<EmptyMethodProperties>
    {
        public GetPaymentFormsRequest()
        {
            modelName = NpApiModels.Common.Name;
            calledMethod = NpApiModels.Common.Methods.getPaymentForms;
        }
    }
}
