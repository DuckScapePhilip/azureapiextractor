using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.GetClassifyResult
{
    /// <summary>
    /// An object representing a figure in the document.
    /// </summary>
    public class DocumentFigure
    {
        /// <summary>
        /// Bounding regions covering the figure.
        /// </summary>
        [JsonProperty("boundingRegions")]
        public BoundingRegion[]? BoundingRegions { get; set; }

        /// <summary>
        /// Caption associated with the figure.
        /// </summary>
        [JsonProperty("caption")]
        public DocumentCaption? Caption { get; set; }

        /// <summary>
        /// Child elements of the figure, excluding any caption or footnotes.
        /// </summary>
        [JsonProperty("elements")]
        public string[]? Elements { get; set; }

        /// <summary>
        /// List of footnotes associated with the figure.
        /// </summary>
        [JsonProperty("footnotes")]
        public DocumentFootnote[]? Footnotes { get; set; }

        /// <summary>
        /// Location of the figure in the reading order concatenated content.
        /// </summary>
        [JsonProperty("spans")]
        public DocumentSpan[]? Spans { get; set; }
    }
}
