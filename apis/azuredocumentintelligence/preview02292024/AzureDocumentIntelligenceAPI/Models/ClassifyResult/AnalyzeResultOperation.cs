using AzureDocumentIntelligenceAPI.Models.Errors;
using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.ClassifyResult
{
    /// <summary>
    /// Status and result of the analyze operation.
    /// </summary>
    public class AnalyzeResultOperation
    {
        [JsonProperty("status")]
        public OperationStatus Status { get; set; } = OperationStatus.notStarted;

        [JsonProperty("error")]
        public Error? Error { get; set; } = null;

        [JsonProperty("analyzeResult")]
        public AnalyzeResult? AnalyzeResult { get; set; } = null;
    }
}
