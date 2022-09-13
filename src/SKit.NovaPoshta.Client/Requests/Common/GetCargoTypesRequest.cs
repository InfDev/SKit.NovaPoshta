
namespace SKit.NovaPoshta.Client.Requests.Common
{
    /// <summary>
    /// Allow to get list of types of return cargo delivery. A monthly update is required 
    /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a5912a1e-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволити отримати типи зворотної доставки вантажу. Потрібне ежемісячне оновлення</remarks>
    public class GetCargoTypesRequest : NpBaseRequest<EmptyMethodProperties>
    {
        public GetCargoTypesRequest()
        {
            modelName = NpApiModels.Common.Name;
            calledMethod = NpApiModels.Common.Methods.getCargoTypes;
        }
    }
}
