// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class DynamicThresholdFailingPeriods : IUtf8JsonSerializable, IJsonModel<DynamicThresholdFailingPeriods>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DynamicThresholdFailingPeriods>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DynamicThresholdFailingPeriods>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynamicThresholdFailingPeriods>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DynamicThresholdFailingPeriods)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("numberOfEvaluationPeriods"u8);
            writer.WriteNumberValue(NumberOfEvaluationPeriods);
            writer.WritePropertyName("minFailingPeriodsToAlert"u8);
            writer.WriteNumberValue(MinFailingPeriodsToAlert);
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

        DynamicThresholdFailingPeriods IJsonModel<DynamicThresholdFailingPeriods>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynamicThresholdFailingPeriods>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DynamicThresholdFailingPeriods)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDynamicThresholdFailingPeriods(document.RootElement, options);
        }

        internal static DynamicThresholdFailingPeriods DeserializeDynamicThresholdFailingPeriods(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float numberOfEvaluationPeriods = default;
            float minFailingPeriodsToAlert = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("numberOfEvaluationPeriods"u8))
                {
                    numberOfEvaluationPeriods = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("minFailingPeriodsToAlert"u8))
                {
                    minFailingPeriodsToAlert = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DynamicThresholdFailingPeriods(numberOfEvaluationPeriods, minFailingPeriodsToAlert, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DynamicThresholdFailingPeriods>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynamicThresholdFailingPeriods>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DynamicThresholdFailingPeriods)} does not support '{options.Format}' format.");
            }
        }

        DynamicThresholdFailingPeriods IPersistableModel<DynamicThresholdFailingPeriods>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynamicThresholdFailingPeriods>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDynamicThresholdFailingPeriods(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DynamicThresholdFailingPeriods)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DynamicThresholdFailingPeriods>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
