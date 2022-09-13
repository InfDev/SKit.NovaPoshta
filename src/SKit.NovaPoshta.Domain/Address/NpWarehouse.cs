using System;

namespace SKit.NovaPoshta.Domain.Address
{
    /// <summary>
    /// Represents warehouse
    /// See <see href="https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a2322f38-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    public class NpWarehouse : NpRefDescription
    {
        /// <summary>
        /// Warehouse code
        /// </summary>
        public int SiteKey { get; set; }

        /// <summary>
        /// Warehouse description on Russian
        /// </summary>
        public string DescriptionRu { get; set; } = string.Empty;

        /// <summary>
        /// Address in Ukranian
        /// </summary>
        public string ShortAddress { get; set; } = string.Empty;

        /// <summary>
        /// Address in Russian
        /// </summary>
        public string ShortAddressRu { get; set; } = string.Empty;

        /// <summary>
        /// Telephone
        /// </summary>
        public string Phone { get; set; } = string.Empty;

        /// <summary>
        /// REF of warehouse type
        /// </summary>
        public Guid TypeOfWarehouse { get; set; }

        /// <summary>
        /// Warehouse number
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Warehouse city reference
        /// </summary>
        public Guid CityRef { get; set; }

        /// <summary>
        /// Warehouse city name in Ukrainian
        /// </summary>
        public string CityDescription { get; set; } = string.Empty;

        /// <summary>
        /// Warehouse city name in Russian
        /// </summary>
        public string CityDescriptionRu { get; set; } = string.Empty;

        /// <summary>
        /// Settlement reference
        /// </summary>
        public Guid SettlementRef { get; set; }

        /// <summary>
        /// Settlement description
        /// </summary>
        public string SettlementDescription { get; set; } = string.Empty;

        /// <summary>
        /// Settlement area description
        /// </summary>
        public string SettlementAreaDescription { get; set; } = string.Empty;

        /// <summary>
        /// Settlement region description
        /// </summary>
        public string SettlementRegionsDescription { get; set; } = string.Empty;

        /// <summary>
        /// Settlement type description in Ukraine
        /// </summary>
        public string SettlementTypeDescription { get; set; } = string.Empty;

        /// <summary>
        /// Settlement type description in Russian
        /// </summary>
        public string SettlementTypeDescriptionRu { get; set; } = string.Empty;

        /// <summary>
        /// Warehouse location latitude
        /// </summary>
        public decimal Latitude { get; set; }

        /// <summary>
        /// Warehouse location longitude
        /// </summary>
        public decimal Longitude { get; set; }

        /// <summary>
        /// Post finance cashbox availability
        public bool PostFinance { get; set; }

        /// <summary>
        /// Gets or sets Bicycle parking availability
        /// </summary>
        public bool BicycleParking { get; set; }

        /// <summary>
        /// Payment availability
        /// </summary>
        public bool PaymentAccess { get; set; }

        /// <summary>
        /// Warehouse POS terminal availability
        /// </summary>
        public bool POSTerminal { get; set; }

        /// <summary>
        /// International shipping service availability
        /// </summary>
        public bool InternationalShipping { get; set; }

        /// <summary>
        /// Availability of self-service work place
        /// </summary>
        public bool SelfServiceWorkplacesCount { get; set; }

        /// <summary>
        /// All shipment total max weight
        /// </summary>
        public int TotalMaxWeightAllowed { get; set; }

        /// <summary>
        /// One shipment weight max weight
        /// </summary>
        public int PlaceMaxWeightAllowed { get; set; }

        /// <summary>
        /// Maximum dimensions for sending
        /// </summary>
        public NpDimensions SendingLimitationsOnDimensions { get; set; } = new();

        /// <summary>
        /// Maximum dimensions for receiving
        /// </summary>
        public NpDimensions ReceivingLimitationsOnDimensions { get; set; } = new();

        /// <summary>
        /// Shedule of cargo receiving
        /// </summary>
        public NpWeekWorkTime Reception { get; set; } = new();

        /// <summary>
        /// Schedule sending day to day
        /// </summary>
        public NpWeekWorkTime Delivery { get; set; } = new();

        /// <summary>
        /// Warehouse work schedule
        /// </summary>
        public NpWeekWorkTime Schedule { get; set; } = new();

        /// <summary>
        /// Код району
        /// </summary>
        public string DistrictCode { get; set; } = string.Empty;

        /// <summary>
        /// Статус відділення
        /// </summary>
        public string WarehouseStatus { get; set; } = string.Empty;

        /// <summary>
        /// Дата статусу відділення
        /// </summary>
        public DateTime? WarehouseStatusDate { get; set; }

        /// <summary>
        /// Категорія складу
        /// </summary>
        public string CategoryOfWarehouse { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        public string Direct { get; set; } = string.Empty;

        /// <summary>
        /// Область/місто
        /// </summary>
        public string RegionCity { get; set; } = string.Empty;

        /// <summary>
        /// Приналежність відділення до франчайзингової мережі
        /// </summary>
        public bool WarehouseForAgent { get; set; }

        /// <summary>
        /// Максимально допустима оціночна вартість відправлення
        /// </summary>
        public double? MaxDeclaredCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool WorkInMobileAwis { get; set; }

        /// <summary>
        /// Заборона вибору складу в ІД: на цей склад не можна створити документ 
        /// </summary>
        public bool DenyToSelect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool CanGetMoneyTransfer { get; set; }

        /// <summary>
        /// Тип поштомату
        /// </summary>
        public string PostMachineType { get; set; } = string.Empty;

        /// <summary>
        /// Поштовий індекс адреси відділення (складу) Нової Пошти
        /// </summary>
        public string PostalCodeUA { get; set; } = string.Empty;

        /// <summary>
        /// Ознака, що відділення працює тільки на видачу
        /// </summary>
        public bool OnlyReceivingParcel { get; set; }

        /// <summary>
        /// Цифрова адреса складу НП, де дані до слеша - це індекс населеного пункту, а після номер відділення/поштомату
        /// </summary>
        public string WarehouseIndex { get; set; } = string.Empty;
    }
}
