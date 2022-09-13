
namespace SKit.NovaPoshta.Client.Converters
{
    /// <summary>
    /// Allow both string and number values on deserialize.
    /// ТЕСТ НЕ ПРОШЕЛ
    /// </summary>
    public class DecimalJsonConverter : JsonConverter<decimal>
    {
        public override decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                string stringValue = reader.GetString()!;
                if (string.IsNullOrEmpty(stringValue))
                    return default;
                return Convert.ToDecimal(reader.GetString(), System.Globalization.CultureInfo.InvariantCulture);
            }
            else // if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetDecimal();
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value);
        }
    }
}
