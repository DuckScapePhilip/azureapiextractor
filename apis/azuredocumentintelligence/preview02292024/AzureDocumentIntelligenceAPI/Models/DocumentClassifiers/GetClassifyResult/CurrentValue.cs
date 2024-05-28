using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.GetClassifyResult
{
    /// <summary>
    /// Currency field value.
    /// </summary>
    public class CurrentValue
    {
        /// <summary>
        /// Currency amount.
        /// </summary>
        [JsonProperty("amount")]
        public double Amount { get; set; }

        /// <summary>
        /// Resolved currency code (ISO 4217), if any.
        /// </summary>
        [JsonProperty("currencyCode")]
        public string? CurrencyCode { get; set; }

        /// <summary>
        /// Currency symbol label, if any.
        /// </summary>
        [JsonProperty("currencySymbol")]
        public string? CurrencySymbol { get; set; }
    }
}
