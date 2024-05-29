using AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.BuildClassifier;
using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentModels.BuildModel
{
    /// <summary>
    /// Request body to build a new custom document model.
    /// </summary>
    public class BuildDocumentModelRequest
    {
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
        [JsonProperty("buildMode")]
        public DocumentBuildMode? BuildMode { get; set; }

        /// <summary>
        /// Document model description.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Unique document model name.
        /// </summary>
        [JsonProperty("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// List of key-value tag attributes associated with the document model.
        /// </summary>
        [JsonProperty("tags")]
        public string[]? Tags { get; set; }
    }
}
