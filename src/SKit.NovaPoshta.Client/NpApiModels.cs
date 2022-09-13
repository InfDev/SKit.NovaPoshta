
namespace SKit.NovaPoshta.Client
{
    /// <summary>
    /// Names of "Nova Poshta" API models with their method names
    /// See <see href="https://developers.novaposhta.ua/documentation">Dоcumentation</see>
    /// </summary>
    /// <remarks>Імена моделей API "Нова Пошта" з їх іменами методів</remarks>
    public static class NpApiModels
    {
        public static class CommonGeneral
        {
            public const string Name = nameof(CommonGeneral);

            public static class Methods
            {
                public const string getMessageCodeText = nameof(getMessageCodeText);
            }
        }

        public static class Common
        {
            public const string Name = nameof(Common);

            public static class Methods
            {
                public const string getTimeIntervals = nameof(getTimeIntervals);
                public const string getCargoTypes = nameof(getCargoTypes);
                public const string getBackwardDeliveryCargoTypes = nameof(getBackwardDeliveryCargoTypes);
                public const string getPalletsList = nameof(getPalletsList);
                public const string getTypesOfPayersForRedelivery = nameof(getTypesOfPayersForRedelivery);
                public const string getPackList = nameof(getPackList);
                public const string getTiresWheelsList = nameof(getTiresWheelsList);
                public const string getCargoDescriptionList = nameof(getCargoDescriptionList);
                public const string getServiceTypes = nameof(getServiceTypes);
                public const string getOwnershipFormsList = nameof(getOwnershipFormsList);

                // Не обнаружено описание на сайте документации
                public const string getTypesOfCounterparties = nameof(getTypesOfCounterparties);
                public const string getTypesOfPayers = nameof(getTypesOfPayers);
                public const string getPaymentForms = nameof(getPaymentForms);
            }
        }

        public static class TrackingDocument
        {
            public const string Name = nameof(TrackingDocument);

            public static class Methods
            {
                public const string getStatusDocuments = nameof(getStatusDocuments);
            }
        }

        public static class Address
        {
            public const string Name = nameof(Address);

            public static class Methods
            {
                public const string searchSettlements = nameof(searchSettlements);
                public const string searchSettlementStreets = nameof(searchSettlementStreets);
                public const string save = nameof(save);
                public const string update = nameof(update);
                public const string delete = nameof(delete);
                public const string getSettlements = nameof(getSettlements);
                public const string getCities = nameof(getCities);
                public const string getAreas = nameof(getAreas);
                public const string getWarehouses = nameof(getWarehouses);
                public const string getWarehouseTypes = nameof(getWarehouseTypes);
                public const string getStreet = nameof(getStreet);
            }
        }

        //public static class AddressGeneral
        //{
        //    public const string Name = nameof(AddressGeneral);

        //    public static class Methods
        //    {
        //        public const string getSettlements = nameof(getSettlements);
        //    }
        //}
    }
}