
namespace SKit.NovaPoshta.Client.Requests.Common
{
    /// <summary>
    /// Allow to get reference book with a description of the list of errors
    /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a6bce5a1-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Дозволяє отримання довідника помилок з описом</remarks>
    public class GetMessageCodeTextRequest : NpBaseRequest<EmptyMethodProperties>
    {
        public GetMessageCodeTextRequest()
        {
            modelName = NpApiModels.CommonGeneral.Name;
            calledMethod = NpApiModels.CommonGeneral.Methods.getMessageCodeText;
        }
    }
}
