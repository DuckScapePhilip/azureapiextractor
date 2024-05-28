using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.AuthorizeModelCopy
{
    /// <summary>
    /// Authorization to copy a document model to the specified target resource and modelId.
    /// </summary>
    public class CopyAuthorization
    {
        /// <summary>
        /// Token used to authorize the request.
        /// </summary>
        [JsonProperty("accessToken")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// Date/time when the access token expires.
        /// </summary>
        [JsonProperty("expirationDateTime")]
        public string? ExpirationDateTime { get; set; }

        /// <summary>
        /// Identifier of the target document model.
        /// </summary>
        [JsonProperty("targetModelId")]
        public string? TargetModelId { get; set; }

        /// <summary>
        /// URL of the copied document model in the target account.
        /// </summary>
        [JsonProperty("targetModelLocation")]
        public string? TargetModelLocation { get; set; }

        /// <summary>
        /// ID of the target Azure resource where the document model should be copied to.
        /// </summary>
        [JsonProperty("targetResourceId")]
        public string? TargetResourceId { get; set; }

        /// <summary>
        /// Location of the target Azure resource where the document model should be copied to.
        /// </summary>
        [JsonProperty("targetResourceRegion")]
        public string? TargetResourceRegion { get; set; }
    }
}
