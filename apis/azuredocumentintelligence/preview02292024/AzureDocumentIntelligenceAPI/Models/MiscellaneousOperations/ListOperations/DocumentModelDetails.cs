using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.MiscellaneousOperations.ListOperations
{
    /// <summary>
    /// Document model info.
    /// </summary>
    public class DocumentModelDetails
    {
        /// <summary>
        /// API version used to create this document model.
        /// </summary>
        [JsonProperty("apiVersion")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// Azure Blob Storage file list specifying the training data. Either azureBlobSource or azureBlobFileListSource must be specified.
        /// </summary>
        [JsonProperty("azureBlobFileListSource")]
        public AzureBlobFileListContentSource? AzureBlobFileListSource { get; set; }

        /// <summary>
        /// Azure Blob Storage location containing the training data. Either azureBlobSource or azureBlobFileListSource must be specified.
        /// </summary>
        [JsonProperty("azureBlobSource")]
        public AzureBlobContentSource? AzureBlobSource { get; set; }

        /// <summary>
        /// Custom document model build mode.
        /// </summary>
        [JsonProperty("buildDocument")]
        public DocumentBuildMode? BuildDocument { get; set; }

        /// <summary>
        /// Date and time (UTC) when the document model was created.
        /// </summary>
        [JsonProperty("createdDateTime")]
        public string? CreatedDateTime { get; set; }

        /// <summary>
        /// Document model description.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Supported document types.
        /// </summary>
        [JsonProperty("docTypes")]
        public List<DocumentTypeDetails>? DocTypes { get; set; }

        /// <summary>
        /// Date and time (UTC) when the document model will expire.
        /// </summary>
        [JsonProperty("expirationDateTime")]
        public string? ExpirationDateTime { get; set; }

        /// <summary>
        /// Unique document model name.
        /// </summary>
        [JsonProperty("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// List of key-value tag attributes associated with the document model.
        /// </summary>
        [JsonProperty("tags")]
        public List<object>? Tags { get; set; }

        /// <summary>
        /// List of key-value tag attributes associated with the document model.
        /// </summary>
        [JsonProperty("warning")]
        public Warning[]? Warnings { get; set; }
    }
}
