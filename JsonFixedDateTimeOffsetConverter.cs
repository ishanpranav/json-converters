// JsonFixedDateTimeOffsetConverter.cs
// Copyright (c) 2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System.Globalization;

namespace System.Text.Json.Serialization
{
    /// <summary>
    /// Converts a <see cref="DateTimeOffset"/> value with a fixed offset to or from JSON.
    /// </summary>
    public class JsonFixedDateTimeOffsetConverter : JsonConverter<DateTimeOffset>
    {
        private readonly TimeSpan _offset;

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonFixedDateTimeOffsetConverter"/> class.
        /// </summary>
        /// <param name="offset">The offset.</param>
        public JsonFixedDateTimeOffsetConverter(TimeSpan offset)
        {
            _offset = offset;
        }

        /// <inheritdoc/>
        public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? text = reader.GetString();

            if (text == null)
            {
                throw new JsonException();
            }
            else
            {
                return new DateTimeOffset(DateTime.Parse(text, CultureInfo.InvariantCulture), _offset);
            }
        }

        /// <inheritdoc/>
        public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value
                .ToOffset(_offset)
                .ToString(format: "yyyy-MM-dd HH:mm:ss"));
        }
    }
}
