using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentModels.AnalyzeDocumentFromStream
{
    /// <summary>
    /// Format of the content in analyzed result.
    /// </summary>
    public enum ContentFormat
    {
        /// <summary>
        /// Markdown representation of the document content with section headings, tables, etc.
        /// </summary>
        markDown,

        /// <summary>
        /// Plain text representation of the document content without any formatting.
        /// </summary>
        text
    }
}
