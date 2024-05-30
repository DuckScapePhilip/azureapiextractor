using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.MiscellaneousOperations.ListOperations
{
    /// <summary>
    /// Paged collection of OperationDetails items
    /// </summary>
    public class PagedOperationDetails
    {
        [JsonProperty("nextLink")]
        public string? NextLink { get; set; }


        //How to implement value property?
       
    }
}
