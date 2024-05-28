using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.BuildClassifier
{
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
