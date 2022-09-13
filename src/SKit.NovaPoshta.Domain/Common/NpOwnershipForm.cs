
namespace SKit.NovaPoshta.Domain.Common
{
    /// <summary>
    /// Represents ownership form.
    /// See <see href="https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a754ff0d-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Форма власності</remarks>
    public class NpOwnershipForm : NpRefDescription
    {
        /// <summary>
        /// Ownership form full name
        /// </summary>
        public string FullName { get; set; } = string.Empty;
    }
}
