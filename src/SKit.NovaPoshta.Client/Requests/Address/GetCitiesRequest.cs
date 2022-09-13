
namespace SKit.NovaPoshta.Client.Requests.Address
{
    /// <summary>
    /// Allows getting of company Cities. Represents request for 'getCities' method of 'Address' model.
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1e6f0a7-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволяє завантажити довідник населених пунктів України, де є відділення "Нова Пошта" і можна оформити доставку на відділення, а також доставку за адресою</remarks>
    public class GetCitiesRequest : NpBaseRequest<GetCitiesRequestProperties>
    {
        private GetCitiesRequest()
        {
            modelName = NpApiModels.Address.Name;
            calledMethod = NpApiModels.Address.Methods.getCities;
        }

        public GetCitiesRequest(GetCitiesRequestProperties properties) : this()
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));
            methodProperties = properties;
        }
    }
}
