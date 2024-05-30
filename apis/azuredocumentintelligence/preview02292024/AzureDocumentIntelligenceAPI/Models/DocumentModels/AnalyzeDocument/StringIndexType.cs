using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentModels.AnalyzeDocument
{
    /// <summary>
    /// Method used to compute string offset and length.
    /// </summary>
    public enum StringIndexType
    {
        /// <summary>
        /// User-perceived display character, or grapheme cluster, as defined by Unicode 8.0.0.
        /// </summary>
        textElements,

        /// <summary>
        /// Character unit represented by a single unicode code point. Used by Python 3.
        /// </summary>
        unicodeCodePoints,

        /// <summary>
        /// Character unit represented by a 16-bit Unicode code unit. Used by JavaScript, Java, and .NET.
        /// </summary>
        utf16CodeUnit
    }
}
