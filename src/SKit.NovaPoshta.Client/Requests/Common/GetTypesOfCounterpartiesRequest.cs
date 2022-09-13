
namespace SKit.NovaPoshta.Client.Requests.Common
{
    /// <summary>
    /// Allow to get existing counterparty types. Represents 'getTypesOfCounterparties' method of 'Common' model.
    /// See <see href="">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволяє отримати наявні типи контрагентів</remarks>
    public class GetTypesOfCounterpartiesRequest : NpBaseRequest<EmptyMethodProperties>
    {
        public GetTypesOfCounterpartiesRequest()
        {
            modelName = NpApiModels.Common.Name;
            calledMethod = NpApiModels.Common.Methods.getTypesOfCounterparties;
        }
    }
}
