using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.GetClassifier
{
    ////The error object.
    public class Error
    {
        /// <summary>
        /// One of a server-defined set of error codes.
        /// </summary>
        [JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// An array of details about specific errors that led to this reported error.
        /// </summary>
        [JsonProperty("details")]
        public Error[]? Details { get; set; }

        /// <summary>
        /// An object containing more specific information than the current object about the error.
        /// </summary>
        [JsonProperty("innererror")]
        public InnerError? InnerError { get; set; }

        /// <summary>
        /// A human-readable representation of the error.
        /// </summary>
        [JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The target of the error.
        /// </summary>
        [JsonProperty("target")]
        public string? Target { get; set; }
    }
}

