namespace AzureDocumentIntelligenceAPI.Models.MiscellaneousOperations.ListOperations
{
    /// <summary>
    /// Custom document model build mode.
    /// </summary>
    public enum DocumentBuildMode
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
