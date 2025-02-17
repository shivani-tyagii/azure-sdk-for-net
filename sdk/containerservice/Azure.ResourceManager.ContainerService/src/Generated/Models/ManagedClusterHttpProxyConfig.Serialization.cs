// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterHttpProxyConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(HttpProxy))
            {
                writer.WritePropertyName("httpProxy"u8);
                writer.WriteStringValue(HttpProxy);
            }
            if (Optional.IsDefined(HttpsProxy))
            {
                writer.WritePropertyName("httpsProxy"u8);
                writer.WriteStringValue(HttpsProxy);
            }
            if (Optional.IsCollectionDefined(NoProxy))
            {
                writer.WritePropertyName("noProxy"u8);
                writer.WriteStartArray();
                foreach (var item in NoProxy)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TrustedCA))
            {
                writer.WritePropertyName("trustedCa"u8);
                writer.WriteStringValue(TrustedCA);
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterHttpProxyConfig DeserializeManagedClusterHttpProxyConfig(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> httpProxy = default;
            Optional<string> httpsProxy = default;
            Optional<IList<string>> noProxy = default;
            Optional<IReadOnlyList<string>> effectiveNoProxy = default;
            Optional<string> trustedCA = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("httpProxy"u8))
                {
                    httpProxy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpsProxy"u8))
                {
                    httpsProxy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("noProxy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    noProxy = array;
                    continue;
                }
                if (property.NameEquals("effectiveNoProxy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    effectiveNoProxy = array;
                    continue;
                }
                if (property.NameEquals("trustedCa"u8))
                {
                    trustedCA = property.Value.GetString();
                    continue;
                }
            }
            return new ManagedClusterHttpProxyConfig(httpProxy.Value, httpsProxy.Value, Optional.ToList(noProxy), Optional.ToList(effectiveNoProxy), trustedCA.Value);
        }
    }
}
