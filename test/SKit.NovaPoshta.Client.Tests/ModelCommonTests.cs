using SKit.NovaPoshta.Domain.Common;
using SKit.NovaPoshta.Client.Responses;
using SKit.NovaPoshta.Client.Services;

namespace SKit.NovaPoshta.Client.Tests
{
    public class ModelCommonTests
    {
        private readonly INpCommonService _npCommonService;


        public ModelCommonTests(INpCommonService npCommonService)
        {
            _npCommonService = npCommonService;
        }

        [Fact]
        public async void GetMessageCodeText()
        {
            var response = await _npCommonService.GetMessageCodeTextAsync();
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "CommonGeneral-GetMessageCodeTextResponse");
        }

        [Fact]
        public async void GetTimeIntervals()
        {
            var settlementRef = new Guid(Consts.SettlementRef);
            var response = await _npCommonService.GetTimeIntervalsAsync(settlementRef, null);
            Utils.SaveRequest(_npCommonService.Gateway.GetLastRequestJson(), "Common-GetTimeIntervalsRequest");
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "Common-GetTimeIntervalsResponse");
        }

        [Fact]
        public async void GetCargoTypes()
        {
            var response = await _npCommonService.GetCargoTypesAsync();
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "Common-GetCargoTypesResponse");
        }

        [Fact]
        public async void GetBackwardDeliveryCargoTypes()
        {
            var response = await _npCommonService.GetBackwardDeliveryCargoTypesAsync();
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "Common-GetBackwardDeliveryCargoTypesResponse");
        }

        [Fact]
        public async void GetPalletsList()
        {
            var response = await _npCommonService.GetPalletsListAsync();
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "Common-GetPalletsListResponse");
        }

        [Fact]
        public async void GetTypesOfPayers()
        {
            var response = await _npCommonService.GetTypesOfPayersAsync();
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "Common-GetTypesOfPayersResponse");
        }

        [Fact]
        public async void GetTypesOfPayersForRedelivery()
        {
            var response = await _npCommonService.GetTypesOfPayersForRedeliveryAsync();
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "Common-GetTypesOfPayersForRedeliveryResponse");
        }

        [Fact]
        public async void GetPackTypesList()
        {
            var response = await _npCommonService.GetPackListAsync();
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "Common-GetPackListResponse");
        }

        [Fact]
        public async void GetTyresWheelsList()
        {
            var response = await _npCommonService.GetTiresWheelsListAsync();
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "Common-GetTyresWheelsListResponse");
        }

        [Fact]
        public async void GetCargoDescriptionList()
        {
            var response = await _npCommonService.GetCargoDescriptionListAsync();
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "Common-GetCargoDescriptionListResponse");
        }

        [Fact]
        public async void GetServiceTypes()
        {
            var response = await _npCommonService.GetServiceTypesAsync();
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "Common-GetServiceTypesResponse");
        }

        [Fact]
        public async void GetTypesOfCounterparties()
        {
            var response = await _npCommonService.GetTypesOfCounterpartiesAsync();
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "Common-GetTypesOfCounterpartiesResponse");
        }

        [Fact]
        public async void GetPaymentForms()
        {
            var response = await _npCommonService.GetPaymentFormsAsync();
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "Common-GetPaymentFormsResponse");
        }

        [Fact]
        public async void GetOwnershipFormsList()
        {
            var response = await _npCommonService.GetOwnershipFormsListAsync();
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "Common-GetOwnershipFormsListResponse");
        }
    }
}