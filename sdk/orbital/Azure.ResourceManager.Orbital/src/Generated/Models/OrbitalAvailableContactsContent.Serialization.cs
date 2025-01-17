// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Orbital.Models
{
    public partial class OrbitalAvailableContactsContent : IUtf8JsonSerializable, IJsonModel<OrbitalAvailableContactsContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OrbitalAvailableContactsContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OrbitalAvailableContactsContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrbitalAvailableContactsContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OrbitalAvailableContactsContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("contactProfile"u8);
            JsonSerializer.Serialize(writer, ContactProfile);
            writer.WritePropertyName("groundStationName"u8);
            writer.WriteStringValue(GroundStationName);
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartOn, "O");
            writer.WritePropertyName("endTime"u8);
            writer.WriteStringValue(EndOn, "O");
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        OrbitalAvailableContactsContent IJsonModel<OrbitalAvailableContactsContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrbitalAvailableContactsContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OrbitalAvailableContactsContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOrbitalAvailableContactsContent(document.RootElement, options);
        }

        internal static OrbitalAvailableContactsContent DeserializeOrbitalAvailableContactsContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WritableSubResource contactProfile = default;
            string groundStationName = default;
            DateTimeOffset startTime = default;
            DateTimeOffset endTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contactProfile"u8))
                {
                    contactProfile = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("groundStationName"u8))
                {
                    groundStationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OrbitalAvailableContactsContent(contactProfile, groundStationName, startTime, endTime, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OrbitalAvailableContactsContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrbitalAvailableContactsContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OrbitalAvailableContactsContent)} does not support '{options.Format}' format.");
            }
        }

        OrbitalAvailableContactsContent IPersistableModel<OrbitalAvailableContactsContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrbitalAvailableContactsContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOrbitalAvailableContactsContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OrbitalAvailableContactsContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OrbitalAvailableContactsContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
