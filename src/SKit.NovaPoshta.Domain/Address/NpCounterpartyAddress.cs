
namespace SKit.NovaPoshta.Domain.Address
{
    public class NpCounterpartyAddress
    {
        /// <summary>
        /// Counterparty reference
        /// </summary>
        public Guid CounterpartyRef { get; set; }

        /// <summary>
        /// Street reference
        /// </summary>
        public Guid StreetRef { get; set; }

        /// <summary>
        /// Building number
        /// </summary>
        public string BuildingNumber { get; set; } = String.Empty;

        /// <summary>
        /// Gets or sets flat number
        /// </summary>
        public int Flat { get; set; }

        /// <summary>
        /// Note
        /// </summary>
        public string Note { get; set; } = String.Empty;

    }
}
