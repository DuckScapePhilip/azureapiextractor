using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.MiscellaneousOperations.GetDocumentModelBuildOperation
{
    /// <summary>
    /// Description of the field semantic schema using a JSON Schema style syntax.
    /// </summary>
    public class DocumentFieldSchema
    {
        /// <summary>
        /// Field description.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example field content.
        /// </summary>
        [JsonProperty("example")]
        public string? Example { get; set; }

        /// <summary>
        /// Field type schema of each array element.
        /// </summary>
        [JsonProperty("items")]
        public DocumentFieldSchema? Items { get; set; }

        /// <summary>
        /// Named sub-fields of the object field.
        /// </summary>
        [JsonProperty("properties")]
        public Dictionary<string, DocumentFieldSchema>? Properties { get; set; }

        /// <summary>
        /// Semantic data type of the field value.
        /// </summary>
        [JsonProperty("type")]
        public DocumentFieldType? Type { get; set; }
    }
}
