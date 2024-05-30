using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.MiscellaneousOperations.GetDocumentClassifierBuildOperation
{
    /// <summary>
    /// Classifier document type info.
    /// </summary>
    public class ClassifierDocumentTypeDetails
    {
        /// <summary>
        /// Azure Blob Storage file list specifying the training data for a classifier document type. Either azureBlobSource or azureBlobFileListSource must be specified.
        /// </summary>
        [JsonProperty("azureBlobFileListSource")]
        public AzureBlobFileListContentSource? AzureBlobFileListSource { get; set; }

        /// <summary>
        /// Azure Blob Storage location containing the training data for a classifier document type. Either azureBlobSource or azureBlobFileListSource must be specified.
        /// </summary>
        [JsonProperty("azureBlobSource")]
        public AzureBlobContentSource? AzureBlobSource { get; set; }

        /// <summary>
        /// Type of training data source.
        /// </summary>
        [JsonProperty("sourceKind")]
        public ContentSourceKind SourceKind { get; set; }
    }
}
