using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using SKit.NovaPoshta.Client.Converters;
using Nogic.JsonConverters;
using Microsoft.Extensions.Options;
using System.Runtime.CompilerServices;
using FluentAssertions;
using BlankNullableConverterFactory = SKit.NovaPoshta.Client.Converters.BlankNullableConverterFactory;

namespace SKit.NovaPoshta.Client.Tests
{
    //    Формат даты и времени
    /// <summary>
    /// ISO 8601 date time parser (ISO 8601-1:2019).
    /// </summary>
    /// <remarks>
    /// Supports extended calendar date (5.2.2.1) and complete (5.4.2.1) calendar date/time of day
    /// representations with optional specification of seconds and fractional seconds.
    ///
    /// Times can be explicitly specified as UTC ("Z" - 5.3.3) or offsets from UTC ("+/-hh:mm" 5.3.4.2).
    /// If unspecified they are considered to be local per spec.
    ///
    /// Examples: (TZD is either "Z" or hh:mm offset from UTC)
    ///
    ///  YYYY-MM-DD               (eg 1997-07-16)
    ///  YYYY-MM-DDThh:mm         (eg 1997-07-16T19:20)
    ///  YYYY-MM-DDThh:mm:ss      (eg 1997-07-16T19:20:30)
    ///  YYYY-MM-DDThh:mm:ss.s    (eg 1997-07-16T19:20:30.45)
    ///  YYYY-MM-DDThh:mmTZD      (eg 1997-07-16T19:20+01:00)
    ///  YYYY-MM-DDThh:mm:ssTZD   (eg 1997-07-16T19:20:3001:00)
    ///  YYYY-MM-DDThh:mm:ss.sTZD (eg 1997-07-16T19:20:30.45Z)
    ///
    /// Generally speaking we always require the "extended" option when one exists (3.1.3.5).
    /// The extended variants have separator characters between components ('-', ':', '.', etc.).
    /// Spaces are not permitted.
    /// </remarks>

    public class JsonConverterTests
    {
        //private const string getStatusDocumentsResponseJsonPath = @".\\..\\..\\..\\..\\..\\assets\\responseSamples\\TrackingDocument-getStatusDocuments.Телефон.json";
        private const string getStatusDocumentsResponseJsonPath = @"./../../../../../assets/responseSamples/TrackingDocument-getStatusDocuments.Телефон.json";
        private string _getStatusDocumentsResponseJson;
        private JsonSerializerOptions options = new();

        public JsonConverterTests()
        {
            var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), getStatusDocumentsResponseJsonPath);
            _getStatusDocumentsResponseJson = File.ReadAllText(jsonPath);
        }

        //void ConvertJson<T>(T value, string json, [CallerArgumentExpression("value")] string? arg = null)
        //{
        //    string typeName = typeof(T).ToString().Split('.')[^1];
        //    Console.WriteLine($"Serialize({arg})");
        //    Console.WriteLine($"  => {JsonSerializer.Serialize(value, options)}");
        //    Console.WriteLine($"Deserialize<{typeName}>({json})");
        //    Console.WriteLine($"  => {JsonSerializer.Deserialize<T>(json, options)}");
        //    Console.WriteLine();
        //}

        [Theory]
        [InlineData("\"2022-09-05T11:01:28\"", "2022-09-05T11:01:28")]
        [InlineData("null", null)]
        [InlineData("\"\"", null)]
        [InlineData("\"2022-09-05 11:01:28\"", "2022-09-05T11:01:28")]
        [InlineData("\"05-09-2022 11:01:28\"", "2022-09-05T11:01:28")]
        [InlineData("\"16:08 02.09.2022\"", "2022-09-02T16:08:00")]
        public void CanDateTimeDeserializeJson(string json, string? expected)
        {
            options = new()
            {
                NumberHandling = JsonNumberHandling.AllowReadingFromString,
                Converters = {
                    new BlankNullableConverterFactory(),
                    new Int32JsonConverter(),
                    new DoubleJsonConverter(),
                    new NpDateTimeJsonConverter()
                }
            };
            DateTime? dtExpected = null;
            if (!string.IsNullOrEmpty(expected))
                dtExpected = DateTime.Parse(expected);
            var dt = JsonSerializer.Deserialize<DateTime?>(json, options);
            dt.Should().Be(dtExpected);
        }

        /// <summary>
        /// Test <see cref="BlankNullableConverter{T}.Read"/>
        /// </summary>
        [Fact]
        public void CanBlankNullableDeserializeJson()
        {
            options = new() { Converters = { new BlankNullableConverterFactory() } };
            AssertDeserialize("1", 1);
            AssertDeserialize("3", TypeCode.Boolean);
            AssertDeserialize("\"2022-01-26T10:00:27+00:00\"", new DateTimeOffset(2022, 1, 26, 10, 0, 27, 0, TimeSpan.Zero));

            void AssertDeserialize<T>(string json, T expected) where T : struct
            {
                JsonSerializer.Deserialize<T?>("null", options).Should().BeNull();
                JsonSerializer.Deserialize<T?>("\"\"", options).Should().BeNull();
                JsonSerializer.Deserialize<T?>(json, options).Should().Be(expected);
            }
        }

        /// <summary>
        /// Test <see cref="Int32JsonConverter.Read"/>
        /// </summary>
        [Theory]
        [InlineData("null", null)]
        [InlineData("\"\"", null)]
        [InlineData("32", 32)]
        [InlineData("\"129\"", 129)]
        public void CanInt32DeserializeJson(string json, int? expected)
        {
            options = new() {
                NumberHandling = JsonNumberHandling.AllowReadingFromString,
                Converters = { 
                    new BlankNullableConverterFactory(),
                    new Int32JsonConverter()
                } 
            };
            JsonSerializer.Deserialize<int?>(json, options).Should().Be(expected);
        }

        /// <summary>
        /// Test <see cref="DoubleJsonConverter.Read"/>
        /// </summary>
        [Theory]
        [InlineData("null", null)]
        [InlineData("\"\"", null)]
        [InlineData("32.5", 32.5)]
        [InlineData("\"129.7\"", 129.7)]
        public void CanDoubleDeserializeJson(string json, double? expected)
        {
            options = new()
            {
                NumberHandling = JsonNumberHandling.AllowReadingFromString,
                Converters = {
                    new BlankNullableConverterFactory(),
                    new DoubleJsonConverter(),
                }
            };
            JsonSerializer.Deserialize<double?>(json, options).Should().Be(expected);
        }

        ///// <summary>
        ///// Test <see cref="DecimalJsonConverter.Read"/>
        ///// </summary>
        //[Theory]
        //[InlineData("null", null)]
        //[InlineData("\"\"", null)]
        //[InlineData("32.5", 32.5)]
        //[InlineData("\"129.7\"", 129.7)]
        //public void CanDecimalDeserializeJson(string json, decimal? expected)
        //{
        //    options = new()
        //    {
        //        NumberHandling = JsonNumberHandling.AllowReadingFromString,
        //        Converters = {
        //            new BlankNullableConverterFactory(),
        //            new DecimalJsonConverter()
        //        }
        //    };
        //    JsonSerializer.Deserialize<decimal?>(json, options).Should().Be(expected);
        //}


    }
}
