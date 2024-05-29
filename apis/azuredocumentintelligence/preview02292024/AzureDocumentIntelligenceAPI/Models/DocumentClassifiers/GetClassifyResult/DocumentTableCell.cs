using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.GetClassifyResult
{
    /// <summary>
    /// An object representing the location and content of a table cell.
    /// </summary>
    public class DocumentTableCell
    {
        /// <summary>
        /// Bounding regions covering the table cell.
        /// </summary>
        [JsonProperty("boundingRegions")]
        public BoundingRegion[]? BoundingRegions { get; set; }

        /// <summary>
        /// Column index of the cell.
        /// </summary>
        [JsonProperty("columnIndex")]
        public int ColumnIndex { get; set; }

        /// <summary>
        /// Number of columns spanned by this cell.
        /// </summary>
        [JsonProperty("columnSpan")]
        public int ColumnSpan { get; set; } = 1;

        /// <summary>
        /// Concatenated content of the table cell in reading order.
        /// </summary>
        [JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Child elements of the table cell.
        /// </summary>
        [JsonProperty("elements")]
        public string[]? Elements { get; set; }

        /// <summary>
        /// Table cell kind.
        /// </summary>
        [JsonProperty("kind")]
        public DocumentTableCellKind? Kind { get; set; } = DocumentTableCellKind.content;

        /// <summary>
        /// Row index of the cell.
        /// </summary>
        [JsonProperty("rowIndex")]
        public int RowIndex { get; set; }

        /// <summary>
        /// Number of rows spanned by this cell.
        /// </summary>
        [JsonProperty("rowSpan")]
        public int RowSpan { get; set; } = 1;

        /// <summary>
        /// Location of the table cell in the reading order concatenated content.
        /// </summary>
        [JsonProperty("spans")]
        public DocumentSpan[]? Spans { get; set; }
    }
}
