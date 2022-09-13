
using SKit.NovaPoshta.Client.Services;

namespace SKit.NovaPoshta.Client.Tests
{

    public class ModelTrackingDocumentTests
    {
        private readonly INpTrackingDocumentService _npTrackingDocumentService;

        public ModelTrackingDocumentTests(INpTrackingDocumentService npTrackingDocumentService)
        {
            _npTrackingDocumentService = npTrackingDocumentService;
        }

        [Fact]
        public async void GetStatusDocuments()
        {
            var response = await _npTrackingDocumentService.GetStatusDocumentsAsync("20450582687146");
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "TrackingDocument-GetStatusDocumentsResponse");
        }

        [Fact]
        public async void GetStatusDocumentsWithPhone()
        {
            var response = await _npTrackingDocumentService.GetStatusDocumentsAsync("20450582687146", "(099) 069-8001");
            var dataList = response?.Data;
            Assert.True(dataList?.Any());
            Utils.SaveAsJson(response, "TrackingDocument-GetStatusDocuments.Телефон.Response");
        }

    }
}
