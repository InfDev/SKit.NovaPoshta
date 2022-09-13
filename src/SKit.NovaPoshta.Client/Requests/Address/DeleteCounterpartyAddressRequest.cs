
namespace SKit.NovaPoshta.Client.Requests.Address
{
    /// <summary>
    /// Alows you to delete the address of the recipient/sender counterparty.
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a177069a-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволяє видалити адресу контрагента отримувача/відправника</remarks>
    public class DeleteCounterpartyAddressRequest : NpBaseRequest<DeleteCounterpartyAddressRequestProperties>
    {
        private DeleteCounterpartyAddressRequest()
        {
            modelName = NpApiModels.Address.Name;
            calledMethod = NpApiModels.Address.Methods.delete;
        }

        public DeleteCounterpartyAddressRequest(DeleteCounterpartyAddressRequestProperties properties) : this()
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));
            methodProperties = properties;
        }
    }
}
