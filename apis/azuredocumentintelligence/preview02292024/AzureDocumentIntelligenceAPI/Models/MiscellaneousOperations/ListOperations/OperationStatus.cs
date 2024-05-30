namespace AzureDocumentIntelligenceAPI.Models.MiscellaneousOperations.ListOperations
{ 
    /// <summary>
    /// Operation status.
    /// </summary>
    public enum OperationStatus
    {
        /// <summary>
        /// The operation has been canceled.
        /// </summary>
        canceled,

        /// <summary>
        /// The operation has completed.
        /// </summary>
        completed,

        /// <summary>
        /// The operation has failed.
        /// </summary>
        failed,

        /// <summary>
        /// The operation has not started yet.
        /// </summary>
        notStarted,

        /// <summary>
        /// The operation is in progress.
        /// </summary>
        running,

        /// <summary>
        /// The operation has succeeded.
        /// </summary>
        succeeded
    }
}
