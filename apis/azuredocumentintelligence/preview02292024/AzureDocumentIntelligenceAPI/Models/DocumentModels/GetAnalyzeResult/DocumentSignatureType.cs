namespace AzureDocumentIntelligenceAPI.Models.DocumentModels.GetAnalyzeResult
{
    /// <summary>
    /// Presence of signature.
    /// </summary>
    public enum DocumentSignatureType
    {
        /// <summary>
        /// A signature is detected.
        /// </summary>
        signed,

        /// <summary>
        /// No signatures are detected.
        /// </summary>
        unsigned
    }
}
