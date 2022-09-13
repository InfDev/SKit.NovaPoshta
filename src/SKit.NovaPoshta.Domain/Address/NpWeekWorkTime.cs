
namespace SKit.NovaPoshta.Domain.Address
{
    /// <summary>
    /// Represents week work time
    /// </summary>
    public class NpWeekWorkTime
    {
        /// <summary>
        /// Working hours on Monday
        /// </summary>
        public string Monday { get; set; } = string.Empty;

        /// <summary>
        /// Working hours on Tueday
        /// </summary>
        public string Tuesday { get; set; } = string.Empty;

        /// <summary>
        /// Working hours on Wednesday
        /// </summary>
        public string Wednesday { get; set; } = string.Empty;

        /// <summary>
        /// Working hours on Thursday
        /// </summary>
        public string Thursday { get; set; } = string.Empty;

        /// <summary>
        /// Working hours on Friday
        /// </summary>
        public string Friday { get; set; } = string.Empty;

        /// <summary>
        /// Working hours on Saturday
        /// </summary>
        public string Saturday { get; set; } = string.Empty;

        /// <summary>
        /// Working hours on Sunday value
        /// </summary>
        public string Sunday { get; set; } = string.Empty;
    }
}
