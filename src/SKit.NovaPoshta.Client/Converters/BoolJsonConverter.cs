
using System.Reflection.Metadata.Ecma335;

namespace SKit.NovaPoshta.Client.Converters
{
    public class BoolJsonConverter : JsonConverter<bool>
    {
        public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options) =>
            writer.WriteBooleanValue(value);

        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch(reader.TokenType)
            {
                case JsonTokenType.True: return true;
                case JsonTokenType.False: return false;
                case JsonTokenType.String:
                    var input = reader.GetString();
                    if (bool.TryParse(input, out var b))
                        return b;
                    if (int.TryParse(input, out var c))
                        return c == 0 ? false : true;
                    throw new JsonException();
                case JsonTokenType.Number:
                    return reader.TryGetInt64(out long l) ? Convert.ToBoolean(l) : reader.TryGetDouble(out double d) ? Convert.ToBoolean(d) : false;
                default:
                    throw new JsonException();
            }
        }
    }
}
