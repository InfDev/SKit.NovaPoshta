
namespace SKit.NovaPoshta.Client.Converters
{
    /// <summary>
    /// Allow both string and number values on deserialize.
    /// </summary>
    public class DoubleJsonConverter : JsonConverter<double>
    {
        public override double Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                string stringValue = reader.GetString()!;
                if (string.IsNullOrEmpty(stringValue))
                    return default;
                return Convert.ToDouble(reader.GetString(), System.Globalization.CultureInfo.InvariantCulture);
            }
            else // if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetDouble();
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, double value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value);
        }
    }
}
