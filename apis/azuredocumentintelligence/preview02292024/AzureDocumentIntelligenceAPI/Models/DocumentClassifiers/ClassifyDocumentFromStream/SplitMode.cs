using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.ClassifyDocumentFromStream
{ 
    /// <summary>
    /// Document splitting mode.
    /// </summary>
    public enum SplitMode
    {
        /// <summary>
        /// Automatically split file into documents.
        /// </summary>
        auto,

        /// <summary>
        /// Treat the entire file as a single document.
        /// </summary>
        none,

        /// <summary>
        /// Treat each page in the file as a separate document.
        /// </summary>
        perPage
    }
}
