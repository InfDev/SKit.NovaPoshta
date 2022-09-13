

namespace SKit.NovaPoshta.Client.Tests
{
    internal class Consts
    {
        /// <summary>
        /// Ідентифікатор (REF) області України з довідника областей України (Address/getAreas)
        /// Київська
        /// </summary>
        public const string AreaRef = "dcaadb64-4b33-11e4-ab6d-005056801329";
        
        /// <summary>
        /// Ідентифікатор (REF) населеного пункту
        /// із довідника населених пунктів України (Address/getSettlements),
        /// до яких здійснюється доставка вантажів компанією «Нова пошта».
        /// Київ
        /// </summary>
        public const string SettlementRef = "e718a680-4b33-11e4-ab6d-005056801329";

        /// <summary>
        /// Тип населеного пункту.
        /// Для Києва
        /// </summary>
        public const string SettlementTypeRef = "563ced10-f210-11e3-8c4a-0050568002cf";

        /// <summary>
        /// м. Київ, Київська обл.
        /// </summary>
        public const string CityRef = "8d5a980d-391c-11dd-90d9-001a92567626";
        /// <summary>
        /// Ідентифікатор (REF) відділення в розрізі населених пунктів України
        /// Відд. 25, Київ, вул. М. Тимошенка, 9
        /// </summary>
        public const string WarehouseRef = "1692285a-e1c2-11e3-8c4a-0050568002cf";

        /// <summary>
        /// Ідентифікатор (REF) типу відділення.
        /// Поштове відділення
        /// </summary>
        public const string WarehouseTypeRef = "841339c7-591a-42e2-8233-7a0a00f0ed6f";

    }
}
