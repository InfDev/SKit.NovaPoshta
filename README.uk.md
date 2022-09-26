Мова: [English](README.md) | [Русский](README.ru.md) | [Українська](README.uk.md)

# SKit.NovaPoshta.Client

Клієнт до веб-сервісів поштово-вантажної компанії "[Нова пошта](https://novaposhta.ua/)".

Пакети у репозиторії [nuget.org](https://www.nuget.org/packages?q=SKit.NovaPoshta).

Загальні обмеження: **API версії 2**, **формат json**, **платформа .NET 6.0+**

![Client](./assets/images/nova-poshta.client.png)

## Реалізація підтримки методів у моделях API 'Нова Пошта'

Під реалізацією методу у клієнті мається на увазі наявність у проекті базового тесту для цього методу та успішний його прохід.
Json-результати запитів знаходяться в підпапках папки assets:

- **responseSamples** - результати запиту з використанням [веб-приложения для разработчиков - developers.novaposhta.ua](https://developers.novaposhta.ua/documentation)
- **responseTestsOutput** - результати тесту у проекті клієнта

Перед методом використовується префікс `+vx.x.x`, где `+` ознака реалізації, `x.x.x` - версія клієнта

### Модель CommonGeneral

- **getMessageCodeText** - отримання існуючих описів помилок

### Модель Common

- +v1.0.0 **getTimeIntervals** - отримання часових інтервалів для міста одержувача
- +v1.0.0 **getCargoTypes** - отримання списку доступних типів вантажів
- +v1.0.0 **getBackwardDeliveryCargoTypes** - отримання списку доступних типів вантажів зворотної доставки
- +v1.0.0 **getPalletsList** - отримання списку доступних палет/піддонів
- +v1.0.0 **getTypesOfPayersForRedelivery** - отримання списку типів платників зворотної доставки
- +v1.0.0 **getPackList** - отримання списку доступних типів пакетів
- +v1.0.0 **getTiresWheelsList** - отримання списку доступних типів шин/колісних дисків
- +v1.0.0 **getCargoDescriptionList** - отримання списку можливого опису вантажу
- +v1.0.0 **getServiceTypes** - отримання списку можливих типів служб доставки, таких як двері-двері, склад-склад і так далі
- +v1.0.0 **getOwnershipFormsList** - отримання списку підтримуваних форм власності

- +v1.0.0 **getTypesOfCounterparties** - отримання списку наявних типів контрагентів
- +v1.0.0 **getTypesOfPayers** - отримання списку доступних типів платників
- +v1.0.0 **getPaymentForms** - отримання списку форм оплати послуги «Нова Пошта»

### TrackingDocument

- +v1.0.0 **GetStatusDocuments** - отримання состояния товарно-транспортних накладних

### Address

- +v1.0.0 **searchSettlements** - пошук населених пунктів
- +v1.0.0 **searchSettlementStreets** - пошук вулиць у населеному пункті
- +v1.0.0 **getAreas** - отримання списку областей
- +v1.0.0 **getSettlements** - отримання списку населених пунктів
- +v1.0.0 **getWarehouseTypes** - отримання списку типів відділень/поштоматів «Нова пошта»
- +v1.0.0 **getWarehouses** - отримання списку відділень/поштоматів «Нова пошта» в розрізі населених пунктів України
- +v1.0.0 **getCities** - отримання довіднику населених пунктів України, де є відділення "Нова Пошта" і можна оформити доставку на відділення, а також доставку за адресою
- +v1.0.0 **getStreet** - отримання довіднику вулиць населеного пункту України

- +v1.0.0 **save** - зберігання адресу контрагента отримувача/відправника
- +v1.0.0 **update** - оновлення адреси контрагента отримувача/відправника
- +v1.0.0 **delete** - видалення адреси контрагента отримувача/відправника

## Початок роботи

### Використання без ін'єкції залежностей

``` csharp
    var npGatewayOptions = new NovaPoshtaGatewayOptions(apiKey: "******");
    var httpClient = new HttpClient();
    INovaPoshtaGateway npGateway = new NovaPoshtaGateway(httpClient, npGatewayOptions);

    INpCommonService npCommonService = new NpCommonService(npGateway);
    // ...
    INpTrackingDocumentService npTrackingDocumentService = new NpTrackingDocumentService(npGateway);
    // ...
    INpAddressService npAddressService = new NpAddressService(npGateway);
    var response = await npAddressService.SearchSettlementsAsync("Київ");
    var dataList = response?.Data;
    var itemCount = dataList?.Count ?? 0;
    // ...
```

### Використання з ін’єкцією залежностей

-- appsettins.json

``` json
{
  "NovaPoshtaGateway": {
    "ApiUrl": "https://api.novaposhta.ua/v2.0/json/",
    "ApiKey": "",
    "TimeoutSec": 15
  }
}
```

-- Startup.cs

``` csharp
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        // ...
        var novaPoshtaGatewayOptions = new NovaPoshtaGatewayOptions();
        configuration.GetSection(NovaPoshtaGatewayOptions.NovaPoshtaGatewaySection).Bind(novaPoshtaGatewayOptions);
        services.AddSingleton<NovaPoshtaGatewayOptions>(novaPoshtaGatewayOptions);

        // Реєстрація спеціалізованої фабрики HttpClient для доступу до веб-сервісів 'Нова Пошта'
        services.AddHttpClient<INovaPoshtaGateway, NovaPoshtaGateway>();

        // Реєстрація сервісів для роботи з методами моделей API 'Нова Пошта'
        services.AddTransient<INpCommonService, NpCommonService>();
        services.AddTransient<INpTrackingDocumentService, NpTrackingDocumentService>();
        services.AddTransient<INpAddressService, NpAddressService>();
        // ...
    }
```
