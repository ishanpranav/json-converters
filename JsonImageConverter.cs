// JsonImageConverter.cs
// Copyright (c) 2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT license.

using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace System.Text.Json.Serialization
{
    /// <summary>
    /// Converts an <see cref="Image"/> value to or from JSON.
    /// </summary>
    public class JsonImageConverter : JsonConverter<Image>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonImageConverter"/> class.
        /// </summary>
        public JsonImageConverter() { }

        /// <inheritdoc/>
        public override Image? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            byte[] buffer = reader.GetBytesFromBase64();

            using MemoryStream input = new MemoryStream(buffer);

            return Image.FromStream(input);
        }

        /// <inheritdoc/>
        public override void Write(Utf8JsonWriter writer, Image value, JsonSerializerOptions options)
        {
            using MemoryStream output = new MemoryStream();

            value.Save(output, ImageFormat.Bmp);

            writer.WriteBase64StringValue(output.ToArray());
        }
    }
}
