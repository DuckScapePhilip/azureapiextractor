using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AzureDocumentIntelligenceAPI.Models.DocumentModels.GetAnalyzeResult
{
    /// <summary>
    /// Bounding polygon on a specific page of the input.
    /// </summary>
    public class BoundingRegion
    {
        /// <summary>
        /// 1-based page double of page containing the bounding region.
        /// </summary>
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        /// <summary>
        /// Bounding polygon on the page, or the entire page if not specified. Coordinates specified relative to the top-left of the page. The doubles represent the x, y values of the polygon vertices, clockwise from the left (-180 degrees inclusive) relative to the element orientation.
        /// </summary>
        [JsonProperty("polygon")]
        public double[]? Polygon { get; set; }
    }
}
