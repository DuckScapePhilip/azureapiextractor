namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.GetClassifyResult
{
    /// <summary>
    /// State of the selection mark.
    /// </summary>
    public enum DocumentSelectionMarkState
    {
        /// <summary>
        /// The selection mark is selected, often indicated by a check ✓ or cross X inside the selection mark.
        /// </summary>
        selected,

        /// <summary>
        /// The selection mark is not selected.
        /// </summary>
        unselected
    }
}
