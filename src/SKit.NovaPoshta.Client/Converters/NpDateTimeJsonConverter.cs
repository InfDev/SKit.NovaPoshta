using System.Globalization;


namespace SKit.NovaPoshta.Client.Converters
{
    public class NpDateTimeJsonConverter : JsonConverter<DateTime>
    {
        // private static CultureInfo cultureEn = CultureInfo.CreateSpecificCulture("en-US");
        private static CultureInfo cultureUk = CultureInfo.CreateSpecificCulture("uk-UA");

        public override DateTime Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            DateTime result = default(DateTime);
            var input = reader.GetString()!;
            
            if (string.IsNullOrEmpty(input))
                return result;
            
            if (DateTime.TryParse(input, cultureUk, DateTimeStyles.None, out result))
                return result;

            //if (DateTime.TryParseExact(input, "dd-MM-yyyy", cultureUk, DateTimeStyles.None, out result))
            //    return result;

            //if (DateTime.TryParseExact(input, "HH:mm dd.MM.yyyy", cultureUk, DateTimeStyles.None, out result))
            //    return result;

            //if (DateTime.TryParse(input, cultureEn, DateTimeStyles.None, out result))
            //    return result;

            throw new JsonException();
        }

        public override void Write(
            Utf8JsonWriter writer,
            DateTime dateTimeValue,
            JsonSerializerOptions options)
        {
            writer.WriteStringValue(dateTimeValue.ToString("s"));
        }
    }
}
