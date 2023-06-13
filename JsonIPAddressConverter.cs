// JsonIPAddressConverter.cs
// Copyright (c) 2021-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System.Net;

namespace System.Text.Json.Serialization
{
    /// <summary>
    /// Converts an <see cref="IPAddress"/> value to or from JSON.
    /// </summary>
    public class JsonIPAddressConverter : JsonConverter<IPAddress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonIPAddressConverter"/> class.
        /// </summary>
        public JsonIPAddressConverter() { }

        /// <inheritdoc/>
        public override IPAddress? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? text = reader.GetString();

            if (text == null)
            {
                return null;
            }
            
            return IPAddress.Parse(text);
        }

        /// <inheritdoc/>
        public override void Write(Utf8JsonWriter writer, IPAddress? value, JsonSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(value.ToString());
            }
        }
    }
}
