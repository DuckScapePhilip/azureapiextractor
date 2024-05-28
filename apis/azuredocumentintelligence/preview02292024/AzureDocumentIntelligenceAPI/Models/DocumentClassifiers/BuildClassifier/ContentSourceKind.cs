﻿using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.BuildClassifier
{
    /// <summary>
    /// The kind of content source. Possible values include: 'azureBlob', 'azureBlobFileList', 'base64', 'url'.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContentSourceKind
    {
        /// <summary>
        /// Files in a path within an Azure Blob Storage container.
        /// </summary>
        [JsonProperty("azureBlob")]
        AzureBlob,

        /// <summary>
        /// A file list specifying individual files in an Azure Blob Storage container.
        /// </summary>
        [JsonProperty("azureBlobFileList")]
        AzureBlobFileList,

        /// <summary>
        /// Content represented via Base64 encoding.
        /// </summary>
        [JsonProperty("base64")]
        Base64,

        /// <summary>
        /// Content at a specific URL.
        /// </summary>
        [JsonProperty("url")]
        Url
    }
}