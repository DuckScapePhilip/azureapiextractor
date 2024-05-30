using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.MiscellaneousOperations.GetDocumentClassifierBuildOperation
{ 
    /// <summary>
    /// File list in Azure Blob Storage.
    /// </summary>
    public class AzureBlobFileListContentSource
    {
        /// <summary>
        /// Azure Blob Storage container URL.
        /// </summary>
        [JsonProperty("containerUrl")]
        public string ContainerUrl { get; set; } = "";

        /// <summary>
        /// Path to a JSONL file within the container specifying a subset of documents.
        /// </summary>
        [JsonProperty("fileList")]
        public string FileList { get; set; } = "";
    }
}
