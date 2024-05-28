using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.GetClassifyResult
{
    /// <summary>
    /// An object representing the location and content of a table cell.
    /// </summary>
    public class DocumentTableCell
    {
        [JsonProperty("boundingRegions")]
        public BoundingRegion[]? BoundingRegions { get; set; }

        [JsonProperty("columnIndex")]
        public int ColumnIndex { get; set; }

        [JsonProperty("columnSpan")]
        public int ColumnSpan { get; set; } = 1;

        [JsonProperty("content")]
        public string? Content { get; set; }

        [JsonProperty("elements")]
        public string[]? Elements { get; set; }

        [JsonProperty("kind")]
        public DocumentTableCellKind? Kind { get; set; } = DocumentTableCellKind.content;

        [JsonProperty("rowIndex")]
        public int RowIndex { get; set; }

        [JsonProperty("rowSpan")]
        public int RowSpan { get; set; } = 1;

        [JsonProperty("spans")]
        public DocumentSpan[]? Spans { get; set; }
    }
}
