
namespace SKit.NovaPoshta.Domain.TrackingDocument
{
    /// <summary>
    /// Represents tracking document.
    /// See <see href="https://developers.novaposhta.ua/view/model/a99d2f28-8512-11ec-8ced-005056b2dbe1/method/a9ae7bc9-8512-11ec-8ced-005056b2dbe1">Dоcumentation</see>
    /// </summary>
    /// <remarks>Состояние груза</remarks>
    public class NpTrackingDocument : INpType
    {
        /// <summary>
        /// Доступність замовлення послуги повернення вантажу
        /// </summary>
        public bool PossibilityCreateReturn { get; set; }

        /// <summary>
        /// Доступність замовлення послуги відмови від вантажу
        /// </summary>
        public bool PossibilityCreateRefusal { get; set; }

        /// <summary>
        /// Доступність замовлення послуги внесення змін в ЕН (єкспрес-накладна)
        /// </summary>
        public bool PossibilityChangeEW { get; set; }

        /// <summary>
        /// Доступність замовлення послуги переадресування
        /// </summary>
        public bool PossibilityCreateRedirecting { get; set; }

        /// <summary>
        /// Номер документу
        /// </summary>
        public string Number { get; set; } = string.Empty;

        /// <summary>
        /// Ознака зворотної доставки: 0 - відсутня ЗД, 1 - наявна ЗД
        /// </summary>
        public int Redelivery { get; set; }

        /// <summary>
        /// Сума зворотної доставки
        /// </summary>
        public double? RedeliverySum { get; set; }

        /// <summary>
        /// Номер ЕН воротної доставки (якщо таку ЕН створено)
        /// </summary>
        public string RedeliveryNum { get; set; } = string.Empty;

        /// <summary>
        /// Ідентифікатор платника зворотної доставки (якщо є зворотна доставка)
        /// </summary>
        public string RedeliveryPayer { get; set; } = string.Empty;

        /// <summary>
        /// Тип ЕН на підставі
        /// </summary>
        public string OwnerDocumentType { get; set; } = string.Empty;

        /// <summary>
        /// Останні зміни типу документу
        /// </summary>
        public string LastCreatedOnTheBasisDocumentType { get; set; } = string.Empty;

        /// <summary>
        /// Останні зміни типe платника
        /// </summary>
        public string LastCreatedOnTheBasisPayerType { get; set; } = string.Empty;

        /// <summary>
        /// Останні зміни, дата створення
        /// </summary>
        public DateTime? LastCreatedOnTheBasisDateTime { get; set; }

        /// <summary>
        /// Останній статус транзакції грошового переказу
        /// </summary>
        public string LastTransactionStatusGM { get; set; } = string.Empty;

        /// <summary>
        /// Останній час та дата транзакції грошового переказу
        /// </summary>
        public DateTime? LastTransactionDateTimeGM { get; set; }

        /// <summary>
        /// Поточне значення суми грошового переказу
        /// </summary>
        public double? LastAmountTransferGM { get; set; }

        /// <summary>
        /// Дата створення ЕН
        /// </summary>
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Вага
        /// </summary>
        public double? DocumentWeight { get; set; }

        /// <summary>
        /// Фактична вага з ЕН
        /// </summary>
        public double? FactualWeight { get; set; }

        /// <summary>
        /// Об'ємна вага з ЕН
        /// </summary>
        public double? VolumeWeight { get; set; }

        /// <summary>
        /// Інформація після контрольного зважування
        /// </summary>
        public double? CheckWeight { get; set; }

        public string CheckWeightMethod { get; set; } = string.Empty;

        /// <summary>
        /// Вартість доставки
        /// </summary>
        public double? DocumentCost { get; set; }

        /// <summary>
        /// Розрахункова вага
        /// </summary>
        public string CalculatedWeight { get; set; } = String.Empty;

        /// <summary>
        /// Вартість доставки до контрольного зважування
        /// </summary>
        public double? SumBeforeCheckWeight { get; set; }

        /// <summary>
        /// Ідентифікатор платника
        /// </summary>
        public string PayerType { get; set; } = string.Empty;

        /// <summary>
        /// Дані ПІБ отримувача з накладної, за умови зазначення номеру телефону
        /// </summary>
        public string? RecipientFullName { get; set; }

        /// <summary>
        /// Дата, коли отримувач забрав вантаж
        /// </summary>
        public DateTime? RecipientDateTime { get; set; }

        /// <summary>
        /// Очікувана дата доставки
        /// </summary>
        public DateTime? ScheduledDeliveryDate { get; set; }

        /// <summary>
        /// Тип оплати
        /// </summary>
        public string PaymentMethod { get; set; } = string.Empty;

        /// <summary>
        /// Опис вантажу
        /// </summary>
        public string CargoDescriptionString { get; set; } = string.Empty;

        /// <summary>
        /// Тип вантажу
        /// </summary>
        public string CargoType { get; set; } = string.Empty;

        /// <summary>
        /// Місто відправника
        /// </summary>
        public string CitySender { get; set; } = string.Empty;

        /// <summary>
        /// CityRecipient
        /// </summary>
        public string CityRecipient { get; set; } = string.Empty;

        /// <summary>
        /// Склад отримувача
        /// </summary>
        public string WarehouseRecipient { get; set; } = string.Empty;

        /// <summary>
        /// Тип контрагенту
        /// </summary>
        public string CounterpartyType { get; set; } = string.Empty;

        /// <summary>
        /// Контроль оплати
        /// </summary>
        public double? AfterpaymentOnGoodsCost { get; set; }

        /// <summary>
        /// Тип доставки
        /// </summary>
        public string ServiceType { get; set; } = string.Empty;

        /// <summary>
        /// Опис причини нерозвезення
        /// </summary>
        public string UndeliveryReasonsSubtypeDescription { get; set; } = string.Empty;

        /// <summary>
        /// Номер відділення отримувача
        /// </summary>
        public int WarehouseRecipientNumber { get; set; }

        /// <summary>
        /// Останні зміни, номер ЕН
        /// </summary>
        public string LastCreatedOnTheBasisNumber { get; set; } = string.Empty;

        /// <summary>
        /// Номер телефону отримувача
        /// </summary>
        public string PhoneRecipient { get; set; } = string.Empty;

        /// <summary>
        /// Дані ПІБ отримувача з накладної, за умови зазначення в запиті номеру телефону
        /// </summary>
        public string RecipientFullNameEW { get; set; } = string.Empty;

        /// <summary>
        /// Ідентифікатор (REF) складу отримувача
        /// </summary>
        public Guid WarehouseRecipientInternetAddressRef { get; set; }

        /// <summary>
        /// Токен торгівельного майданчику
        /// </summary>
        public Guid MarketplacePartnerToken { get; set; }

        /// <summary>
        /// Внутрішній номер замовлення
        /// </summary>
        public string ClientBarcode { get; set; } = string.Empty;

        /// <summary>
        /// Адреса отримувача
        /// </summary>
        public string RecipientAddress { get; set; } = string.Empty;

        /// <summary>
        /// Опис контрагента отримувача
        /// </summary>
        public string CounterpartyRecipientDescription { get; set; } = string.Empty;

        /// <summary>
        /// Тип контрагента відправника
        /// </summary>
        public string CounterpartySenderType { get; set; } = string.Empty;

        /// <summary>
        /// Дата сканування, що призвела до формування статусу
        /// </summary>
        public DateTime? DateScan { get; set; }

        /// <summary>
        /// Статус для інтернет еквайрингу
        /// </summary>
        public string PaymentStatus { get; set; } = string.Empty;

        /// <summary>
        /// Дата оплати для інтернет еквайрингу
        /// </summary>
        public DateTime? PaymentStatusDate { get; set; }

        /// <summary>
        /// Сума до сплати для інтернет еквайрингу
        /// </summary>
        public double? AmountToPay { get; set; }

        /// <summary>
        /// Сплачено через інтернет еквайринг
        /// </summary>
        public double? AmountPaid { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Код статусу
        /// </summary>
        public int StatusCode { get; set; } = 0;

        /// <summary>
        /// Ідентифікатор накладної для інтернет еквайрингу (використовується в робочих цілях)
        /// </summary>
        public Guid RefEW { get; set; }

        /// <summary>
        /// Інформація за нестандартними підтипами зворотної доставки
        /// </summary>
        public string BackwardDeliverySubTypesActions { get; set; } = string.Empty;

        /// <summary>
        /// Інформація за нестандартними підтипами зворотної доставки
        /// </summary>
        public string BackwardDeliverySubTypesServices { get; set; } = string.Empty;

        /// <summary>
        /// Причина нерозвозу
        /// </summary>
        public string UndeliveryReasons { get; set; } = string.Empty;

        /// <summary>
        /// Дата початку платного зберігання
        /// </summary>
        public DateTime? DatePayedKeeping { get; set; }

        /// <summary>
        /// Тип міжнародної доставки
        /// </summary>
        public string InternationalDeliveryType { get; set; } = string.Empty;

        /// <summary>
        /// Кількість місць
        /// </summary>
        public int SeatsAmount { get; set; }

        /// <summary>
        /// Замаскований номер платіжної карти
        /// </summary>
        public string CardMaskedNumber { get; set; } = string.Empty;

        /// <summary>
        /// Статус оплати ЕН
        /// </summary>
        public string ExpressWaybillPaymentStatus { get; set; } = string.Empty;

        /// <summary>
        /// Сума оплати по ЕН
        /// </summary>
        public double? ExpressWaybillAmountToPay { get; set; }

        /// <summary>
        /// Телефон відправника
        /// </summary>
        public string PhoneSender { get; set; } = string.Empty;

        /// <summary>
        /// Оновлена дата відстеження
        /// </summary>
        public DateTime? TrackingUpdateDate { get; set; }

        /// <summary>
        /// Відділення відправника
        /// </summary>
        public string WarehouseSender { get; set; } = string.Empty;

        /// <summary>
        /// Дата повернення вантажу
        /// </summary>
        public DateTime? DateReturnCargo { get; set; }

        /// <summary>
        /// Дата переміщення
        /// </summary>
        public DateTime? DateMoving { get; set; }

        /// <summary>
        /// Дата початку зберігання
        /// </summary>
        public DateTime? DateFirstDayStorage { get; set; }

        /// <summary>
        /// Ідентифікатор міста одержувача
        /// </summary>
        public Guid RefCityRecipient { get; set; }

        /// <summary>
        /// Ідентифікатор міста відправника
        /// </summary>
        public Guid RefCitySender { get; set; }

        /// <summary>
        /// Ідентифікатор населеного пункту одержувача
        /// </summary>
        public Guid RefSettlementRecipient { get; set; }

        /// <summary>
        /// Ідентифікатор міста відправника
        /// </summary>
        public Guid RefSettlementSender { get; set; }

        /// <summary>
        /// Адреса відправника
        /// </summary>
        public string SenderAddress { get; set; } = string.Empty;

        /// <summary>
        /// Повне ім'я відправника
        /// </summary>
        public string SenderFullNameEW { get; set; } = string.Empty;

        /// <summary>
        /// Оголошена вартість
        /// </summary>
        public double? AnnouncedPrice { get; set; }

        /// <summary>
        /// Додаткова інформація
        /// </summary>
        public string AdditionalInformationEW { get; set; } = string.Empty;

        /// <summary>
        /// Фактична дата доставки
        /// </summary>
        public DateTime? ActualDeliveryDate { get; set; }

        /// <summary>
        /// Номер/Ознака бронювання комірки поштомату, за умови доставки до поштомату
        /// </summary>
        public bool PostomatV3CellReservationNumber { get; set; }

        /// <summary>
        /// Номер ЕН на основі
        /// </summary>
        public string OwnerDocumentNumber { get; set; } = string.Empty;

        /// <summary>
        /// Сума комісії за грошовий переказ
        /// </summary>
        public double? LastAmountReceivedCommissionGM { get; set; }

        /// <summary>
        /// Часовий інтервал, якщо було замовлено та тільки для ЕН до адреси
        /// </summary>
        public string DeliveryTimeframe { get; set; } = string.Empty;

        /// <summary>
        /// Створено на основі
        /// </summary>
        public string CreatedOnTheBasis { get; set; } = string.Empty;

        /// <summary>
        /// Дата причини нерозвезення
        /// </summary>
        public DateTime? UndeliveryReasonsDate { get; set; }

        /// <summary>
        /// Ідентифікатор типу відділення одержувача
        /// </summary>
        public Guid RecipientWarehouseTypeRef { get; set; }

        /// <summary>
        /// Ідентифікатор відділення одержувача
        /// </summary>
        public Guid WarehouseRecipientRef { get; set; }

        /// <summary>
        /// Категорія відділення
        /// </summary>
        public string CategoryOfWarehouse { get; set; } = string.Empty;

        /// <summary>
        /// Адреса відділення одержувача
        /// </summary>
        public string WarehouseRecipientAddress { get; set; } = string.Empty;

        /// <summary>
        /// Інтернет адреса відділення відправника
        /// </summary>
        public Guid WarehouseSenderInternetAddressRef { get; set; }

        /// <summary>
        /// Адреса відділення відправника
        /// </summary>
        public string WarehouseSenderAddress { get; set; } = string.Empty;

        /// <summary>
        /// Авіа доставка
        /// </summary>
        public int AviaDelivery { get; set; }

        /// <summary>
        /// ШК пакування типу RedBox
        /// </summary>
        public string BarcodeRedBox { get; set; } = string.Empty;

        /// <summary>
        /// Наявність послуги "Відмова від повернення"
        /// </summary>
        public bool CargoReturnRefusal { get; set; }

        /// <summary>
        /// Днів зберігання вантажу
        /// </summary>
        public string DaysStorageCargo { get; set; } = String.Empty;

        /// <summary>
        /// Пакування
        /// </summary>
        public IList<string> Packaging { get; set; } = new List<string>();

        /// <summary>
        /// Часткове повернення
        /// </summary>
        public IList<string> PartialReturnGoods { get; set; } = new List<string>();

        /// <summary>
        /// Ознака надійної покупки
        /// </summary>
        public bool SecurePayment { get; set; }

        /// <summary>
        /// Доступність можливості зміни виплати грошового переказу на карту
        /// </summary>
        public bool PossibilityChangeCash2Card { get; set; }

        /// <summary>
        /// Доступність зміни інтервалу доставки
        /// </summary>
        public bool PossibilityChangeDeliveryIntervals { get; set; }

        /// <summary>
        /// Доступність можливості подовження термінів зберігання
        /// </summary>
        public bool PossibilityTermExtensio { get; set; }

        /// <summary>
        /// Кількість днів зберігання вантажу
        /// </summary>
        public string StorageAmount { get; set; } = String.Empty;

        /// <summary>
        /// Вартість зберігання
        /// </summary>
        public string StoragePrice { get; set; } = String.Empty;

        /// <summary>
        /// Ознака безкоштовної доставки
        /// </summary>
        public string FreeShipping { get; set; } = String.Empty;

        /// <summary>
        /// Номер карти лояльності отримувача, за наявності
        /// </summary>
        public Guid? LoyaltyCardRecipient { get; set; }
    }
}
