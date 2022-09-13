using SKit.NovaPoshta.Domain.Address;
using SKit.NovaPoshta.Client.Responses;
using SKit.NovaPoshta.Client.Services;
using SKit.NovaPoshta.Client.Requests.Address;

namespace SKit.NovaPoshta.Client.Tests
{
    public class ModelAddressTests
    {
        private readonly INpAddressService _npAddressService;

        public ModelAddressTests(INpAddressService npAddressService)
        {
            _npAddressService = npAddressService;
        }

        [Fact]
        public async void SearchSettlements()
        {
            var response = await _npAddressService.SearchSettlementsAsync("Київ", 1, 50);
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "Address-SearchSettlements");
        }

        [Fact]
        public async void SearchSettlementStreets()
        {
            var response = await _npAddressService.SearchSettlementStreetsAsync(new Guid("e718a680-4b33-11e4-ab6d-005056801329"), "Гайдай", 50);
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "Address-SearchSettlementStreets");
        }

        [Fact]
        public async void GetSettlements()
        {
            var properties = new GetSettlementsRequestProperties
            {
                // AreaRef = new Guid("dcaadb64-4b33-11e4-ab6d-005056801329"),
                // Ref = new Guid("e718a680-4b33-11e4-ab6d-005056801329"),
                FindByString = "Київ"
            };
            var response = await _npAddressService.GetSettlementsAsync(properties);
            Utils.SaveRequest(_npAddressService.Gateway.GetLastRequestJson(), "Address-GetSettlementsRequest");
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "Address-GetSettlements");
        }

        [Fact]
        public async void GetWarehouses()
        {
            var properties = new GetWarehousesRequestProperties
            {
                CityName = "Київ",
                WarehouseId = 25
            };
            var response = await _npAddressService.GetWarehousesAsync(properties);
            Utils.SaveRequest(_npAddressService.Gateway.GetLastRequestJson(), "Address-GetWarehousesRequest");
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "Address-GetWarehouses");
        }

        [Fact]
        public async void GetAreas()
        {
            var response = await _npAddressService.GetAreasAsync();
            Utils.SaveRequest(_npAddressService.Gateway.GetLastRequestJson(), "Address-GetAreasRequest");
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "Address-GetAreas");
        }

        [Fact]
        public async void GetWarehouseTypes()
        {
            var response = await _npAddressService.GetWarehouseTypesAsync();
            Utils.SaveRequest(_npAddressService.Gateway.GetLastRequestJson(), "Address-GetWarehouseTypesRequest");
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "Address-GetWarehouseTypes");
        }

        [Fact]
        public async void GetCities()
        {
            var response = await _npAddressService.GetCitiesAsync("Київ");
            Utils.SaveRequest(_npAddressService.Gateway.GetLastRequestJson(), "Address-GetCitiesRequest");
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "Address-GetCities");
        }

        [Fact]
        public async void GetStreet()
        {
            var response = await _npAddressService.GetStreetAsync(new Guid(Consts.CityRef));
            Utils.SaveRequest(_npAddressService.Gateway.GetLastRequestJson(), "Address-GetStreetRequest");
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "Address-GetStreet");
        }
    }
}
