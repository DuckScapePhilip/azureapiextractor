using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentModels.GetAnalyzeResult
{
    /// <summary>
    /// Address field value.
    /// </summary>
    public class AddressValue
    {
        /// <summary>
        /// Name of city, town, village, etc.
        /// </summary>
        [JsonProperty("city")]
        public string? City { get; set; }

        /// <summary>
        /// Districts or boroughs within a city, such as Brooklyn in New York City or City of Westminster in London.
        /// </summary>
        [JsonProperty("cityDistrict")]
        public string? CityDistrict { get; set; }

        /// <summary>
        /// Country/region.
        /// </summary>
        [JsonProperty("countryRegion")]
        public string? CountryRegion { get; set; }

        /// <summary>
        /// Build name, such as World Trade Center.
        /// </summary>
        [JsonProperty("house")]
        public string? House { get; set; }

        /// <summary>
        /// House or building double.
        /// </summary>
        [JsonProperty("houseNumber")]
        public string? HouseNumber { get; set; }

        /// <summary>
        /// Floor double, such as 3F.
        /// </summary>
        [JsonProperty("level")]
        public string? Level { get; set; }

        /// <summary>
        /// Post office box double.
        /// </summary>
        [JsonProperty("poBox")]
        public string? PoBox { get; set; }

        /// <summary>
        /// Postal code used for mail sorting.
        /// </summary>
        [JsonProperty("postalCode")]
        public string? PostalCode { get; set; }

        /// <summary>
        /// Street name.
        /// </summary>
        [JsonProperty("road")]
        public string? Road { get; set; }

        /// <summary>
        /// First-level administrative division.
        /// </summary>
        [JsonProperty("state")]
        public string? State { get; set; }

        /// <summary>
        /// Second-level administrative division used in certain locales.
        /// </summary>
        [JsonProperty("stateDistrict")]
        public string? StateDistrict { get; set; }

        /// <summary>
        /// Street-level address, excluding city, state, countryRegion, and postalCode.
        /// </summary>
        [JsonProperty("streetAddress")]
        public string? StreetAddress { get; set; }

        /// <summary>
        /// Unofficial neighborhood name, like Chinatown.
        /// </summary>
        [JsonProperty("suburb")]
        public string? Suburb { get; set; }

        /// <summary>
        /// Apartment or office double
        /// </summary>
        [JsonProperty("unit")]
        public string? Unit { get; set; }
    }
}
