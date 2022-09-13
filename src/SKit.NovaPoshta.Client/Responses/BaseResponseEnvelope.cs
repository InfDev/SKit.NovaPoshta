
namespace SKit.NovaPoshta.Client.Responses
{
    /// <summary>
    /// Represents base gateway response envelope
    /// </summary>
    /// <typeparam name="TDataItem">Response Data type</typeparam>
    public abstract class BaseResponseEnvelope<TDataItem> : IResponseEnvelope<TDataItem>, IResponseEnvelopeDescription where TDataItem : class, INpType, new()
    {
        /// <summary>
        /// Gets or sets successfull response or not
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets response Data
        /// </summary>
        public IList<TDataItem>? Data { get; set; }

        /// <summary>
        /// Gets or sets response errors list
        /// </summary>
        public object? Errors { get; set; }

        /// <summary>
        /// Gets or sets response warning list
        /// </summary>
        public object? Warnings { get; set; }

        /// <summary>
        /// Gets or sets response additional information
        /// </summary>
        public object? Info { get; set; }



        ///// <summary>
        ///// Gets or sets response errors list
        ///// </summary>
        //public IList<object>? Errors { get; set; }

        ///// <summary>
        ///// Gets or sets response warning list
        ///// </summary>
        //public IList<object>? Warnings { get; set; }

        ///// <summary>
        ///// Gets or sets response additional information
        ///// </summary>
        //public IList<object>? Info { get; set; }

        /// <summary>
        /// Gets first data value when response has successfull result and data has values quantity higher than zero
        /// </summary>
        //[JsonIgnore]
        //[IgnoreDataMember]
        public TDataItem? FirstOrDefault() => Success && Data?.Count > 0 ? Data[0] : null;
    }
}
