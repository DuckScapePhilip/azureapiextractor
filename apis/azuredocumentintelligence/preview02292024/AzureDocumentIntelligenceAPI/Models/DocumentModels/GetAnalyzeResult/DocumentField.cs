using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentModels.GetAnalyzeResult
{
    /// <summary>
    /// An object representing the content and location of a field value.
    /// </summary>
    public class DocumentField
    {
        /// <summary>
        /// Bounding regions covering the field.
        /// </summary>
        [JsonProperty("boundingRegion")]
        public BoundingRegion[]? BoundingRegion { get; set; }

        /// <summary>
        /// Confidence of correctly extracting the field.
        /// </summary>
        [JsonProperty("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Field content.
        /// </summary>
        [JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Location of the field in the reading order concatenated content.
        /// </summary>
        [JsonProperty("spans")]
        public DocumentSpan[]? Spans { get; set; }

        /// <summary>
        /// Data type of the field value.
        /// </summary>
        [JsonProperty("type")]
        public DocumentFieldType? Type { get; set; }

        /// <summary>
        /// Address value.
        /// </summary>
        [JsonProperty("valueAddress")]
        public AddressValue? ValueAddress { get; set; }

        /// <summary>
        /// Array of field values.
        /// </summary>
        [JsonProperty("valueArray")]
        public DocumentField[]? ValueArray { get; set; }

        /// <summary>
        /// Boolean value.
        /// </summary>
        [JsonProperty("valueBoolean")]
        public bool? ValueBoolean { get; set; }

        /// <summary>
        /// 3-letter country code value (ISO 3166-1 alpha-3).
        /// </summary>
        [JsonProperty("valueCountryRegion")]
        public string? ValueCountryRegion { get; set; }

        /// <summary>
        /// Currency value.
        /// </summary>
        [JsonProperty("valueCurrency")]
        public CurrencyValue? ValueCurrency { get; set; }

        /// <summary>
        /// Date value in YYYY-MM-DD format (ISO 8601).
        /// </summary>
        [JsonProperty("valueDate")]
        public string? ValueDate { get; set; }

        /// <summary>
        /// Integer value.
        /// </summary>
        [JsonProperty("valueInteger")]
        public int? ValueInteger { get; set; }

        /// <summary>
        /// Floating point value.
        /// </summary>
        [JsonProperty("valueNumber")]
        public double? ValueNumber { get; set; }

        /// <summary>
        /// Dictionary of named field values.
        /// </summary>
        [JsonProperty("valueObject")]
        public Dictionary<string, DocumentField>? ValueObject { get; set; }

        /// <summary>
        /// Phone double value in E.164 format (ex. +19876543210).
        /// </summary>
        [JsonProperty("valuePhoneNumber")]
        public string? ValuePhoneNumber { get; set; }

        /// <summary>
        /// Selection group value.
        /// </summary>
        [JsonProperty("valueSelectionGroup")]
        public string[]? ValueSelectionGroup { get; set; }

        /// <summary>
        /// Selection mark value.
        /// </summary>
        [JsonProperty("valueSelectionMark")]
        public DocumentSelectionMarkState? ValueSelectionMark { get; set; }

        /// <summary>
        /// Presence of signature.
        /// </summary>
        [JsonProperty("valueSignature")]
        public DocumentSignatureType? ValueSignature { get; set; }

        /// <summary>
        /// String value.
        /// </summary>
        [JsonProperty("valueString")]
        public string? ValueString { get; set; }

        /// <summary>
        /// Time value in hh:mm:ss format (ISO 8601).
        /// </summary>
        [JsonProperty("valueTime")]
        public string? ValueTime { get; set; }



    }
}
