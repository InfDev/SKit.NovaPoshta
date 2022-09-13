// Source: https://github.com/dotnet/runtime/blob/main/src/libraries/System.Text.Json/tests/System.Text.Json.Tests/Serialization/CustomConverterTests/CustomConverterTests.Int32.cs

namespace SKit.NovaPoshta.Client.Converters
{
    /// <summary>
    /// Allow both string and number values on deserialize.
    /// </summary>
    public class Int32JsonConverter : JsonConverter<int>
    {
        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                // return Convert.ToInt32(reader.GetString());
                string stringValue = reader.GetString()!;
                if (string.IsNullOrEmpty(stringValue))
                    return default;
                else if (int.TryParse(stringValue, out int value))
                {
                    return value;
                }
            }
            else //if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetInt32();
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value);
        }
    }

}
