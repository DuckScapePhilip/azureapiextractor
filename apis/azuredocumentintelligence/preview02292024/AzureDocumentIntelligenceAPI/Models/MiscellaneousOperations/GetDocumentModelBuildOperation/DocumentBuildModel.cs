namespace AzureDocumentIntelligenceAPI.Models.MiscellaneousOperations.GetDocumentModelBuildOperation
{
    /// <summary>
    /// Custom document model build mode.
    /// </summary>
    public enum DocumentBuildModel
    {
        /// <summary>
        /// Support documents with diverse visual templates.
        /// </summary>
        neural,

        /// <summary>
        /// Target documents with similar visual templates.
        /// </summary>
        template
    }
}
