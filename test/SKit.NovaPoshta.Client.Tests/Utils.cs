using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace SKit.NovaPoshta.Client.Tests
{
    internal static class Utils
    {
        public static string ResponseTestsDirectory = Path.Combine(Directory.GetCurrentDirectory(), "./../../../../../assets/responseTests");
        public static string RequestTestsDirectory = Path.Combine(Directory.GetCurrentDirectory(), "./../../../../../assets/RequestTests");
        public static JsonSerializerOptions DefaultsonSerializerOptions;

        static Utils()
        {
            DefaultsonSerializerOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web)
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true,
                // DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                // PropertyNameCaseInsensitive = true,

            };
            if (!Directory.Exists(ResponseTestsDirectory))
                Directory.CreateDirectory(ResponseTestsDirectory);
            if (!Directory.Exists(RequestTestsDirectory))
                Directory.CreateDirectory(RequestTestsDirectory);
        }

        public static void SaveAsJson(this object? obj, string fileName)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentNullException(nameof(fileName));

            var safeFileName = Path.GetFileNameWithoutExtension(fileName) + ".json";
            var path = Path.Combine(ResponseTestsDirectory, safeFileName); 

            var json = JsonSerializer.Serialize(obj, DefaultsonSerializerOptions);
            File.WriteAllText(path, json);
        }

        public static void SaveRequest(string json, string fileName)
        {
            if (json == null)
                throw new ArgumentNullException(nameof(json));
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentNullException(nameof(fileName));

            var safeFileName = Path.GetFileNameWithoutExtension(fileName) + ".json";
            var path = Path.Combine(RequestTestsDirectory, safeFileName);
            File.WriteAllText(path, json);
        }
    }


}
