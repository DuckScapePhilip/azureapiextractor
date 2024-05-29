using AzureDocumentIntelligenceAPI.Models.Errors;
using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentModels.GetAnalyzeResult
{
    /// <summary>
    /// Status and result of the analyze operation.
    /// </summary>
    public class AnalyzeResultOperation
    {
        /// <summary>
        /// Document analysis result.
        /// </summary>
        [JsonProperty("analyzeResult")]
        public AnalyzeResult? AnalyzeResult { get; set; } = null;

        /// <summary>
        /// Date and time (UTC) when the analyze operation was submitted.
        /// </summary>
        [JsonProperty("createdDateTime")]
        public string? CreatedDateTime { get; set; } = null;

        /// <summary>
        /// Encountered error during document analysis.
        /// </summary>
        [JsonProperty("error")]
        public Error? Error { get; set; } = null;

        /// <summary>
        /// Date and time (UTC) when the status was last updated.
        /// </summary>
        [JsonProperty("lastUpdatedDateTime")]
        public string? LastUpdatedDateTime { get; set; } = null;

        /// <summary>
        /// Operation status. notStarted, running, succeeded, or failed
        /// </summary>
        [JsonProperty("status")]
        public OperationStatus Status { get; set; } = OperationStatus.notStarted;

    }
}
