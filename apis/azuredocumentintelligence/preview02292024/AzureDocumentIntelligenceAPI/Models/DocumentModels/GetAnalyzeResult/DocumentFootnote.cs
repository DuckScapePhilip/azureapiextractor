using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentModels.GetAnalyzeResult
{
    /// <summary>
    /// A footnote object describing a table or figure.
    /// </summary>
    public class DocumentFootnote
    {
        [JsonProperty("boundingRegions")]
        public BoundingRegion[]? BoundingRegions { get; set; }

        [JsonProperty("content")]
        public string? Content { get; set; }

        [JsonProperty("elements")]
        public string[]? Elements { get; set; }

        [JsonProperty("spans")]
        public DocumentSpan[]? Spans { get; set; }
    }
}
