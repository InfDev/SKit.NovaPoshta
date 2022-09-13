
namespace SKit.NovaPoshta.Client.Requests.Address
{
    /// <summary>
    /// Allows getting streets of city. Represents request for 'getStreets' method of 'Address' model.
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a27c20d7-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволяє завантажити довідник вулиць населеного пункту України</remarks>
    public class GetStreetRequest : NpBaseRequest<GetStreetRequestProperties>
    {
        private GetStreetRequest()
        {
            modelName = NpApiModels.Address.Name;
            calledMethod = NpApiModels.Address.Methods.getStreet;
        }

        public GetStreetRequest(GetStreetRequestProperties properties) : this()
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));
            methodProperties = properties;
        }
    }
}
