
namespace SKit.NovaPoshta.Client.Requests.Address
{
    /// <summary>
    /// Alows you to update the address of the recipient/sender counterparty.
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a19ba934-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволяє оновити адресу контрагента отримувача/відправника</remarks>
    public class UpdateCounterpartyAddressRequest : NpBaseRequest<UpdateCounterpartyAddressRequestProperties>
    {
        private UpdateCounterpartyAddressRequest()
        {
            modelName = NpApiModels.Address.Name;
            calledMethod = NpApiModels.Address.Methods.update;
        }

        public UpdateCounterpartyAddressRequest(UpdateCounterpartyAddressRequestProperties properties) : this()
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));
            methodProperties = properties;
        }
    }
}
