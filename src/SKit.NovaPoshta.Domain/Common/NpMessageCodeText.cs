namespace SKit.NovaPoshta.Domain.Common
{
    /// <summary>
    /// Reprensents error message.
    /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a6bce5a1-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Помилка</remarks>
    public class NpMessageCodeText : INpType
    {
        /// <summary>
        /// Message code
        /// </summary>
        public string MessageCode { get; set; } = string.Empty;

        /// <summary>
        /// Message text on English
        /// </summary>
        public string MessageText { get; set; } = string.Empty;

        /// <summary>
        /// Message text on Russian
        /// </summary>
        public string MessageDescriptionRU { get; set; } = string.Empty;

        /// <summary>
        /// Message text on Ukrainian
        /// </summary>
        public string MessageDescriptionUA { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{MessageCode} - {MessageText}";
        }

        public string DisplayMessage(NpLanguage language) => language switch
        {
            NpLanguage.Ukrainian => MessageDescriptionUA,
            NpLanguage.Russian => MessageDescriptionRU,
            _ => MessageText,
        };
    }
}
