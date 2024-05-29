using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentModels.GetAnalyzeResult
{
    /// <summary>
    /// Formula kind.
    /// </summary>
    public enum DocumentFormulaKind
    {
        /// <summary>
        /// A formula in display mode that takes up an entire line.
        /// </summary>
        Display,

        /// <summary>
        /// A formula embedded within the content of a paragraph.
        /// </summary>
        Inline
    }
}
