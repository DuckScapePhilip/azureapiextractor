using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.MiscellaneousOperations.ListOperations
{
    /// <summary>
    /// Document type info.
    /// </summary>
    public class DocumentTypeDetails
    {
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
        /// Estimated confidence for each field.
        /// </summary>
        [JsonProperty("fieldConfidence")]
        public object? FieldConfidence { get; set; }

        /// <summary>
        /// Description of the document semantic schema using a JSON Schema style syntax.
        /// </summary>
        [JsonProperty("fieldSchema")]
        public List<DocumentFieldSchema>? FieldSchema { get; set; }
    }
}
