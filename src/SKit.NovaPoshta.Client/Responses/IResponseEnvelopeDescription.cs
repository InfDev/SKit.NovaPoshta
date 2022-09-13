
namespace SKit.NovaPoshta.Client.Responses
{
    /// <summary>
    /// Represents one of possible 'Nova Poshta' response interface.
    /// Unfortunately this API has no one common response body for all requests. Some times they use string arrays, some times some strange types, which aren't described in documentation.
    /// We add this interface to allow you create your own response envelope to see response errors, warnings, info and other data.
    /// </summary>
    internal interface IResponseEnvelopeDescription
    {
        /// <summary>
        /// Gets or sets response errors list
        /// </summary>
        object? Errors { get; set; }

        /// <summary>
        /// Gets or sets response warning list
        /// </summary>
        object? Warnings { get; set; }

        /// <summary>
        /// Gets or sets response additional information
        /// </summary>
        object? Info { get; set; }

        ///// <summary>
        ///// Gets or sets response errors list
        ///// </summary>
        //IList<object>? Errors { get; set; }

        ///// <summary>
        ///// Gets or sets response warning list
        ///// </summary>
        //IList<object>? Warnings { get; set; }

        ///// <summary>
        ///// Gets or sets response additional information
        ///// </summary>
        //IList<object>? Info { get; set; }
    }
}
