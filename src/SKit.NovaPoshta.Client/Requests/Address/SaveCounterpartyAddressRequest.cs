
namespace SKit.NovaPoshta.Client.Requests.Address
{
    /// <summary>
    /// Alows you to store the address of the recipient/sender counterparty.
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a155d0d9-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволяє зберігати адресу контрагента отримувача/відправника</remarks>
    public class SaveCounterpartyAddressRequest : NpBaseRequest<SaveCounterpartyAddressRequestProperties>
    {
        private SaveCounterpartyAddressRequest()
        {
            modelName = NpApiModels.Address.Name;
            calledMethod = NpApiModels.Address.Methods.save;
        }

        public SaveCounterpartyAddressRequest(SaveCounterpartyAddressRequestProperties properties) : this()
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));
            methodProperties = properties;
        }
    }
}
