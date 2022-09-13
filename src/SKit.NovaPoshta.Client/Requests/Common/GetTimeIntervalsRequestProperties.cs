
namespace SKit.NovaPoshta.Client.Requests.Common
{
    public class GetTimeIntervalsRequestProperties
    {
        public GetTimeIntervalsRequestProperties()
        {
        }

        public GetTimeIntervalsRequestProperties(Guid settlementRef, DateTime? dateTime)
        {
            RecipientCityRef = settlementRef;
            DateTime = dateTime?.ToString("dd.mm.YYYY");
        }

        /// <summary>
        /// Identifier of the city (SettlementRef) for which time intervals will be obtained
        /// </summary>
        /// <remarks>Ідентифікатор (REF) міста (SettlementRef) для якого будуть отримані часові інтервали</remarks>
        public Guid RecipientCityRef { get; set; }

        /// <summary>
        /// The date on which time intervals will be received (optional parameter) by default is the current date, format dd.mm.YYYY
        /// </summary>
        /// <remarks>Дата на яку будуть отримані часові інтервали (необов'язковий параметр) за замовчанням дорівнює поточній даті, формат dd.mm.YYYY</remarks>
        public string? DateTime { get; set; }
    }
}
