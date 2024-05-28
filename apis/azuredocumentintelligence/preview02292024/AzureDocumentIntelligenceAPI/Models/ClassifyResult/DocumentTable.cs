using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.ClassifyResult
{
    /// <summary>
    /// A table object consisting table cells arranged in a rectangular layout.
    /// </summary>
    public class DocumentTable
    {
        /// <summary>
        /// Bounding regions covering the table.
        /// </summary>
        [JsonProperty("boundingRegions")]
        public BoundingRegion[]? BoundingRegions { get; set; }

        /// <summary>
        /// Caption associated with the table.
        /// </summary>
        [JsonProperty("caption")]
        public DocumentCaption? Caption { get; set; }

        /// <summary>
        /// Cells contained within the table.
        /// </summary>
        [JsonProperty("cells")]
        public DocumentTableCell[]? Cells { get; set; }

        /// <summary>
        /// Number of columns in the table.
        /// </summary>
        [JsonProperty("columnCount")]
        public int ColumnCount { get; set; }

        /// <summary>
        /// List of footnotes associated with the table.
        /// </summary>
        [JsonProperty("footnotes")]
        public DocumentFootnote[]? Footnotes { get; set; }

        /// <summary>
        /// Number of rows in the table.
        /// </summary>
        [JsonProperty("rowCount")]
        public int RowCount { get; set; }

        /// <summary>
        /// Location of the table in the reading order concatenated content.
        /// </summary>
        [JsonProperty("spans")]
        public DocumentSpan[]? Spans { get; set; }
    }
}
