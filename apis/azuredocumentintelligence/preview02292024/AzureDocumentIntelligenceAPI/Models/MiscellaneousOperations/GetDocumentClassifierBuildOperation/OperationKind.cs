namespace AzureDocumentIntelligenceAPI.Models.MiscellaneousOperations.GetDocumentClassifierBuildOperation
{
    /// <summary>
    /// Type of operation.
    /// </summary>
    public enum OperationKind
    {
        /// <summary>
        /// Build a new custom classifier model.
        /// </summary>
        documentClassifierBuild,

        /// <summary>
        /// Build a new custom document model.
        /// </summary>
        documentModelBuild,

        /// <summary>
        /// Compose a new custom document model from existing models.
        /// </summary>
        documentModelCompose,

        /// <summary>
        /// Copy an existing document model to potentially a different resource, region, or subscription.
        /// </summary>
        documentModelCopyto,
    }
}
