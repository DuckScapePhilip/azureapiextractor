using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentModels.GetAnalyzeResult
{
    /// <summary>
    /// Format of the content in analyzed result.
    /// </summary>
    public enum ContentFormat
    {
        /// <summary>
        /// Markdown representation of the document content with section headings, tables, etc.
        /// </summary>
        MarkDown,

        /// <summary>
        /// Plain text representation of the document content without any formatting.
        /// </summary>
        Text
    }
}
