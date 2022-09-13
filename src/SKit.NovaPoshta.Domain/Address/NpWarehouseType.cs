using System;

namespace SKit.NovaPoshta.Domain.Address
{
    /// <summary>
    /// Represents warehouse type
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a2587b53-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    public class NpWarehouseType : NpRefDescription
    {
        /// <summary>
        /// Description of warehouse type  in Russian
        /// </summary>
        public string DescriptionRu { get; set; } = string.Empty;
    }
}
