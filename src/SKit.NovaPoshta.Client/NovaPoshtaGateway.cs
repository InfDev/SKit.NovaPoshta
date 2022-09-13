
using SKit.NovaPoshta.Client.Converters;
using SKit.NovaPoshta.Client.Requests;
using SKit.NovaPoshta.Client.Responses;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using static System.Net.WebRequestMethods;

namespace SKit.NovaPoshta.Client
{
    public class NovaPoshtaGateway : INovaPoshtaGateway
    {
        public static bool DefaultThrowsIfNotSuccessHttpStatusCode = true;

        private readonly NovaPoshtaGatewayOptions _gatewayOptions;
        private readonly HttpClient _httpClient;
        private JsonSerializerOptions _postJsonOptions; 
        private object? _lastRequest = null;


        public NovaPoshtaGateway(HttpClient httpClient, NovaPoshtaGatewayOptions gatewayOptions)
        {
            _gatewayOptions = gatewayOptions;
            _httpClient = httpClient;

            // Set timeout
            var seconds = _gatewayOptions.TimeoutSec ?? 0;
            if (seconds <= 0)
                seconds = 100;
            else if (seconds < 15)
                seconds = 15;
            _httpClient.Timeout = TimeSpan.FromSeconds(seconds);

            // Set base address
            _httpClient.BaseAddress = new Uri(_gatewayOptions.ApiUrl);

            _postJsonOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web)
            {
                PropertyNamingPolicy = null,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                Converters = {
                        new NpBoolJsonConverter()
                    }
            };
        }

        /// <summary>
        /// Throws if not 200-299
        /// </summary>
        public bool ThrowsIfNotSuccessHttpStatusCode { get; set; } = DefaultThrowsIfNotSuccessHttpStatusCode;

        public string GetLastRequestJson()
        {
            if (_lastRequest != null)
            {
                ((NpBaseRequest)_lastRequest).apiKey = "****";
                var json = JsonSerializer.Serialize(_lastRequest, _postJsonOptions);
                return json;
            }
            else
                return "{}";
        }


        public async Task<IResponseEnvelope<TDataItem>?> Get<TRequest, TDataItem>(TRequest request) 
            where TRequest : NpBaseRequest
            where TDataItem : class, INpType, new()
        {
            _lastRequest = request;
            request.apiKey = _gatewayOptions.ApiKey;

            var responseMsg = await _httpClient.PostAsJsonAsync(_httpClient.BaseAddress, request, _postJsonOptions);

            //// Обход проблемы в API "Нова пошта":
            //// Политика наименования свойств в запросах смешанная 
            //// (для конверта CamelCase, а для свойств в methodProperties - PascalCase)
            //var json = JsonSerializer.Serialize<TRequest>(request);
            //json = json
            //    .Replace("ApiKey", "apiKey")
            //    .Replace("ModelName", "modelName")
            //    .Replace("CalledMethod", "calledMethod")
            //    .Replace("MethodProperties", "methodProperties");
            //var data = new StringContent(json, Encoding.UTF8, "application/json");
            //var responseMsg = await _httpClient.PostAsync(_httpClient.BaseAddress, data);

            if (ThrowsIfNotSuccessHttpStatusCode)
                responseMsg.EnsureSuccessStatusCode();

            IResponseEnvelope<TDataItem>? responseEnvelope = null;

            if (responseMsg.IsSuccessStatusCode)
            {
                responseEnvelope = await responseMsg.Content.ReadFromJsonAsync<ResponseEnvelope<TDataItem>>(
                    new JsonSerializerOptions(JsonSerializerDefaults.Web) {
                        NumberHandling = JsonNumberHandling.AllowReadingFromString,
                        Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                        // DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                        // PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                        Converters = {
                            new BlankNullableConverterFactory(),
                            new Int32JsonConverter(),
                            new DoubleJsonConverter(),
                            new NpDateTimeJsonConverter(),
                            new BoolJsonConverter()
                        }
                    }
                );
            }
            return responseEnvelope;
        }

    }
}
