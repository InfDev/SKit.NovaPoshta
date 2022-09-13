
namespace Skit.NovaPoshta.Domain.Address
{
    /// <summary>
    /// Represents workdays interface for some Nova Poshta service items
    /// </summary>
    public interface INpWorkDays
    {
        /// <summary>
        /// Monday is work day
        /// </summary>
        bool Delivery1 { get; set; }

        /// <summary>
        /// Tuesday is work day
        /// </summary>
        bool Delivery2 { get; set; }

        /// <summary>
        /// Wednesday is work day
        /// </summary>
        bool Delivery3 { get; set; }

        /// <summary>
        /// Thursday is work day
        /// </summary>
        bool Delivery4 { get; set; }

        /// <summary>
        /// Friday is work day
        /// </summary>
        bool Delivery5 { get; set; }

        /// <summary>
        /// Saturday is work day
        /// </summary>
        bool Delivery6 { get; set; }

        /// <summary>
        /// Sunday is work day
        /// </summary>
        bool Delivery7 { get; set; }
    }
}
