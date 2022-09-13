// Source: https://github.com/nogic1008/JsonConverters/tree/main/src/Nogic.JsonConverters

namespace SKit.NovaPoshta.Client.Converters;

/// <summary>Json converter for <see cref="Nullable{T}"/> that treats "" as <see langword="null"/>.</summary>
public class BlankNullableConverterFactory : JsonConverterFactory
{
    /// <summary>Cache of <see cref="Nullable{T}"/> type</summary>
    private static readonly Type _nullableType = typeof(Nullable<>);

    /// <inheritdoc/>
    public override bool CanConvert(Type typeToConvert)
        => typeToConvert.IsGenericType
        && typeToConvert.GetGenericTypeDefinition() == _nullableType;

    /// <inheritdoc/>
    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var valueTypeToConvert = typeToConvert.GetGenericArguments()[0];
        var valueConverter = options.GetConverter(valueTypeToConvert);

        var converterType = GetConverterType(valueTypeToConvert);
        var instance = (JsonConverter?)Activator.CreateInstance(converterType, valueConverter);
        return instance;

        static Type GetConverterType(Type valueTypeToConvert)
            => typeof(BlankNullableConverter<>).MakeGenericType(valueTypeToConvert);
    }
}
