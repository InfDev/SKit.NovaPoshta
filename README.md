Language: [English](README.md) | [Русский](README.ru.md) | [Українська](README.uk.md)

# SKit.NovaPoshta.Client

Client to the web-services of the postal and cargo company "[Nova Poshta](https://novaposhta.ua/eng/)".

General restrictions: **API version 2**, **json format**, **.NET platform 6.0+**

![Client](./assets/images/nova-poshta.client.png)

## Implementation of method support for 'Nova Poshta' API models

The implementation of a method in the client means the presence in the project of a basic test for this method, its successful passage.
Json query results are located in subfolders of the assets folder:

- **responseSamples** - query results using [the developer web app - developers.novaposhta.ua](https://developers.novaposhta.ua/documentation)
- **responseTestsOutput** - test results in client project

The method is preceded by a prefix `+x.x.x`, where `+` sign of implementation, `x.x.x` - client version

### CommonGeneral model

- **getMessageCodeText** - get existing error descriptions

### Common model

- +v1.0.0 **getTimeIntervals** - getting recipient city time intervals
- +v1.0.0 **getCargoTypes** - get list of available cargo types
- +v1.0.0 **getBackwardDeliveryCargoTypes** - get list of available backward delivery cargo types
- +v1.0.0 **getPalletsList** - getting list of available pallets
- +v1.0.0 **getTypesOfPayersForRedelivery** - getting list of redelivery payer types
- +v1.0.0 **getPackList** - getting list of available package types
- +v1.0.0 **getTiresWheelsList** - getting list of available tyre/wheel types
- +v1.0.0 **getCargoDescriptionList** - getting list of possible cargo description
- +v1.0.0 **getServiceTypes** - getting list of possible delivery service types like door-door, warehouse-warehouse and so on
- +v1.0.0 **getOwnershipFormsList** - getting list of supported ownership forms

- +v1.0.0 **getTypesOfCounterparties** - getting list of existing counterparty types
- +v1.0.0 **getTypesOfPayers** - getting list of available payer types
- +v1.0.0 **getPaymentForms** - getting list of 'Nova Poshta' service payment forms

### TrackingDocument

- +v1.0.0 **GetStatusDocuments** - getting state of waybills

### Address

- +v1.0.0 **searchSettlements** - search for settlements
- +v1.0.0 **searchSettlementStreets** - search for streets in the settlement
- +v1.0.0 **getAreas** - get list of areas
- +v1.0.0 **getSettlements** - get list of settlements
- +v1.0.0 **getWarehouseTypes** - get list of types of warehouses "Nova Poshta"
- +v1.0.0 **getWarehouses** - get list of warehouses "Nova Poshta" of Ukraine settlements
- +v1.0.0 **getCities** - getting a directory of settlements in Ukraine, where there are branches of "Nova Poshta" and you can arrange delivery to the office, as well as delivery to the address
- +v1.0.0 **getStreet** - getting a directory of streets of a settlement in Ukraine

- +v1.0.0 **save** - saving the address of the counterparty of the recipient/sender
- +v1.0.0 **update** - updating the recipient/sender counterparty address
- +v1.0.0 **delete** - deleting the recipient/sender counterparty address

## Getting started

### Use without Dependency Injection

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

### Use with Dependency Injection

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

        // Registration of a specialized HttpClient factory for accessing 'Nova Poshta' web services
        services.AddHttpClient<INovaPoshtaGateway, NovaPoshtaGateway>();

        // Registration of services for working with methods of 'Nova Poshta' API models
        services.AddTransient<INpCommonService, NpCommonService>();
        services.AddTransient<INpTrackingDocumentService, NpTrackingDocumentService>();
        services.AddTransient<INpAddressService, NpAddressService>();
        // ...
    }
```
