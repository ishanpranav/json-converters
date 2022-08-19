// JsonStringTimeSpanConverter.cs
// Copyright (c) 2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

namespace System.Text.Json.Serialization
{
    /// <summary>
    /// Converts a <see cref="TimeSpan"/> value with a suffix to or from JSON.
    /// </summary>
    public class JsonStringTimeSpanConverter : JsonConverter<TimeSpan>
    {
        private const string Suffix = "min";

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonStringTimeSpanConverter"/> class.
        /// </summary>
        public JsonStringTimeSpanConverter() { }

        /// <inheritdoc/>
        public override TimeSpan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? text = reader.GetString();

            if (text != null && text.EndsWith(Suffix))
            {
                return TimeSpan.FromMinutes(double.Parse(text.Substring(startIndex: 0, text.Length - Suffix.Length)));
            }
            else
            {
                throw new JsonException();
            }
        }

        /// <inheritdoc/>
        public override void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"{value.Minutes}{Suffix}");
        }
    }
}
