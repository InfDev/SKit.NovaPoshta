
namespace SKit.NovaPoshta.Client.Requests.Common
{
    /// <summary>
    /// Allow to get list of available pallets. Represents 'getPalletsList' method of 'Common' model. . A monthly update is required.
    /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a5dd575e-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволити отримати список доступних палет (піддонів). Потрібне ежемісячне оновлення</remarks>
    public class GetPalletsListRequest : NpBaseRequest<EmptyMethodProperties>
    {
        public GetPalletsListRequest()
        {
            modelName = NpApiModels.Common.Name;
            calledMethod = NpApiModels.Common.Methods.getPalletsList;
        }
    }
}
