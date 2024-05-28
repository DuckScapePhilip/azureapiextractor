using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.ClassifyResult
{
    /// <summary>
    /// Semantic data type of the field value.
    /// </summary>
    public class DocumentFielType
    {
        /// <summary>
        /// Parsed address.
        /// </summary>
        [JsonProperty("address")]
        public string? Address { get; set; }

        /// <summary>
        /// List of subfields of the same type.
        /// </summary>
        [JsonProperty("array")]
        public string? Array { get; set; }

        /// <summary>
        /// Boolean value, normalized to true or false.
        /// </summary>
        [JsonProperty("boolean")]
        public string? Boolean { get; set; }

        /// <summary>
        /// Country/region, normalized to ISO 3166-1 alpha-3 format (ex. USA).
        /// </summary>
        [JsonProperty("countryRegion")]
        public string? CountryRegion { get; set; }

        /// <summary>
        /// Currency amount with optional currency symbol and unit.
        /// </summary>
        [JsonProperty("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// Date, normalized to ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        [JsonProperty("date")]
        public string? Date { get; set; }

        /// <summary>
        /// Integer double, normalized to 64-bit signed integer.
        /// </summary>
        [JsonProperty("integer")]
        public string? Integer { get; set; }

        /// <summary>
        /// Floating point double, normalized to double precision floating point.
        /// </summary>
        [JsonProperty("number")]
        public string? Number { get; set; }

        /// <summary>
        /// Named list of subfields of potentially different types.
        /// </summary>
        [JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Phone double, normalized to E.164 (+{CountryCode}{Subscriberdouble}) format.
        /// </summary>
        [JsonProperty("phonedouble")]
        public string? Phonedouble { get; set; }

        /// <summary>
        /// Array of selected string values.
        /// </summary>
        [JsonProperty("selectionGroup")]
        public string? SelectionGroup { get; set; }

        /// <summary>
        /// Is field selected?
        /// </summary>
        [JsonProperty("selectionMark")]
        public string? SelectionMark { get; set; }

        /// <summary>
        /// Is signature present?
        /// </summary>
        [JsonProperty("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// Plain text.
        /// </summary>
        [JsonProperty("string")]
        public string? String { get; set; }

        /// <summary>
        /// Time, normalized to ISO 8601 (hh:mm:ss) format.
        /// </summary>
        [JsonProperty("time")]
        public string? Time { get; set; }
    }
}
