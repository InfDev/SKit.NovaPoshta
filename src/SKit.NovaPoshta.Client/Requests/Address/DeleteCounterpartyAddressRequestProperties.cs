
namespace SKit.NovaPoshta.Client.Requests.Address
{
    /// <summary>
    /// Alows you to delete the address of the recipient/sender counterparty.
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a177069a-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    public class DeleteCounterpartyAddressRequestProperties
    {
        /// <summary>
        /// Identifier (REF) of the address
        /// </summary>
        public Guid Ref { get; set; }
    }
}
