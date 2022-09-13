
namespace SKit.NovaPoshta.Client.Requests.Common
{
    /// <summary>
    /// Allow to get possible cargo description. Represents request for 'getCargoDescriptionList' method of 'Common' model.
    /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a697db47-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволити отримати можливий опис вантажу</remarks>
    public class GetCargoDescriptionRequest : NpBaseRequest<GetCargoDescriptionRequestProperties>
    {
        private GetCargoDescriptionRequest()
        {
            modelName = NpApiModels.Common.Name;
            calledMethod = NpApiModels.Common.Methods.getCargoDescriptionList;
        }

        public GetCargoDescriptionRequest(GetCargoDescriptionRequestProperties properties) : this()
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));
            methodProperties = properties;
        }
    }
}
