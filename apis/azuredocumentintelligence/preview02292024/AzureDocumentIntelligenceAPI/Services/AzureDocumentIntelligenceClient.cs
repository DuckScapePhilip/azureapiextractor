using System.Text;
using Newtonsoft.Json;
using AzureDocumentIntelligenceAPI.Models;
using AzureDocumentIntelligenceAPI.Models.Errors;
using AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.ClassifyDocument;
using AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.GetClassifyResult;

namespace AzureDocumentIntelligenceAPI.Services
{
    public class AzureDocumentIntelligenceClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _endpoint;
        private readonly string _apiKey; //apikey private because it is sensitive information
        private readonly ILogger<AzureDocumentIntelligenceClient> _logger;

        // Add a new constructor to accept the endpoint and apiKey
        public AzureDocumentIntelligenceClient(HttpClient httpClient, string endpoint, string apiKey, ILogger<AzureDocumentIntelligenceClient> logger)
        {
            _httpClient = httpClient;
            _endpoint = endpoint;
            _apiKey = apiKey;
            _logger = logger;
        }

        // Add a new method to build a classifier
        //public async Task<DocumentClassifierBuildOperationDetails> BuildClassifierAsync(BuildDocumentClassifierRequestBody requestBody)
        //{
        //    // ENDPOINT - Build the URL for the request
        //    string url = $"{_endpoint}/documentintelligence/documentClassifiers:build?api-version=2024-02-29-preview";

        //    // METHOD - Create a new HttpRequestMessage with the POST method and the URL
        //    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);

        //    // HEADER - Add the Ocp-Apim-Subscription-Key header with the API key
        //    request.Headers.Add("Ocp-Apim-Subscription-Key", _apiKey);

        //    // BODY - Serialize the requestBody object to JSON and set it as the content of the request
        //    string json = JsonConvert.SerializeObject(requestBody);
        //    request.Content = new StringContent(json, Encoding.UTF8, "application/json");

        //    //Sending POST request to the endpoint
        //    _logger.LogInformation($"Sending POST request to {url} with body: {json}");

        //    var response = await _httpClient.SendAsync(request);
        //    var responseContent = await response.Content.ReadAsStringAsync();

        //    if (!response.IsSuccessStatusCode)
        //    {
        //        _logger.LogError($"Failed to build classification model. Status code: {response.StatusCode}, Response: {responseContent}");
        //        throw new Exception($"Failed to build classification model: {responseContent}");
        //    }

        //    var operationLocation = response.Headers.GetValues("Operation-Location").FirstOrDefault();
        //    if (operationLocation == null)
        //    {
        //        _logger.LogError("Failed to get operation location for classification model build.");
        //        throw new Exception("Failed to get operation location for classification model build.");
        //    }

        //    for (int i = 0; i < 1000; i++)
        //    {
        //        var operationRequest = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}{operationLocation}");
        //        operationRequest.Headers.Add("Ocp-Apim-Subscription-Key", _apiKey);

        //        _logger.LogInformation($"Polling operation status at {_endpoint}{operationLocation}");

        //        var operationResponse = await _httpClient.SendAsync(operationRequest);
        //        var operationResponseContent = await operationResponse.Content.ReadAsStringAsync();

        //        if (!operationResponse.IsSuccessStatusCode)
        //        {
        //            _logger.LogError($"Failed to poll operation location. Status code: {operationResponse.StatusCode}, Response: {operationResponseContent}");
        //            throw new Exception($"Failed to poll operation location for classification model build: {operationResponseContent}");
        //        }

        //        var operationResult = JsonConvert.DeserializeObject<DocumentClassifierBuildOperationDetails>(operationResponseContent)
        //            ?? throw new Exception("Failed to deserialize extraction model build response.");

        //        if (operationResult.Status == "succeeded")
        //        {
        //            _logger.LogInformation("Classification model build succeeded.");
        //            return operationResult;
        //        }

        //        if (operationResult.Status == "failed")
        //        {
        //            _logger.LogError($"Classification model build failed: {operationResult.Error?.Message}");
        //            throw new Exception($"Classification model build failed: {operationResult.Error?.Message}");
        //        }

        //        await Task.Delay(1000);
        //    }

        //    _logger.LogError("Classification model build operation timed out.");
        //    throw new Exception("Classification model build operation timed out.");
        //}

        // Add a new method to classify a document
        public async Task<AnalyzeResult> ClassifyDocumentAsync(string classifierId, ClassifyDocumentRequestBody requestBody, StringIndexType? stringIndexType = default, SplitMode? splitMode = default, CancellationToken cancellationToken = default)
        {
            // VALIDATION - Check if the classifierId is null or empty
            if(string.IsNullOrEmpty(classifierId))
            {
                throw new ArgumentException("Classifier ID cannot be null or empty.", nameof(classifierId));
            }

            if(requestBody == null)
            {
                throw new ArgumentNullException(nameof(requestBody));
            }

            // ENDPOINT - Build the URL for the request
            string url = $"POST {_endpoint}/documentintelligence/documentClassifiers/{classifierId}:analyze?_overload=classifyDocument&api-version=2024-02-29-preview&stringIndexType={stringIndexType}&split={splitMode}";

            // METHOD - Create a new HttpRequestMessage with the POST method and the URL
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);

            // HEADER - Add the Ocp-Apim-Subscription-Key header with the API key
            request.Headers.Add("Ocp-Apim-Subscription-Key", _apiKey);

            // BODY - Serialize the requestBody object to JSON and set it as the content of the request
            string json = JsonConvert.SerializeObject(requestBody);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            _logger.LogInformation($"Sending POST request to {url} with body: {json}");

            try
            {
                var response = await _httpClient.SendAsync(request, cancellationToken);
                if (response.IsSuccessStatusCode)
                {
                    // Read the Operation-Location header and poll for the operation status.
                    string? operationLocation = response.Headers.GetValues("Operation-Location").FirstOrDefault();
                    
                    // If the operation location is not available, throw an exception.
                    if (string.IsNullOrWhiteSpace(operationLocation))
                    {
                        throw new Exception("Operation location not found in response headers.");
                    }

                    // Read the "Retry-After" header to determine the polling interval.
                    int retryAfter = response.Headers.RetryAfter?.Delta?.Seconds ?? 1;

                    // Poll every X seconds (as indicated by "Retry-After") to check for the status of the operation.
                    for (int i = 0; i < 1000; i++)
                    {
                        // Create a new HttpRequestMessage with the GET method and the operation location URL.
                        HttpRequestMessage operationRequest = new HttpRequestMessage(HttpMethod.Get, operationLocation);
                        operationRequest.Headers.Add("Ocp-Apim-Subscription-Key", _apiKey);

                        _logger.LogInformation($"Polling operation status at {operationLocation}");

                        // Send the GET request to the operation location.
                        var operationResponse = await _httpClient.SendAsync(operationRequest, cancellationToken);
                        var operationResponseContent = await operationResponse.Content.ReadAsStringAsync(cancellationToken);

                        // If the operation response is successful, deserialize the response content into an AnalyzeResult object.
                        if (operationResponse.IsSuccessStatusCode)
                        {
                            AnalyzeResultOperation? operationResult = JsonConvert.DeserializeObject<AnalyzeResultOperation>(operationResponseContent);

                            // If the operation result is not null, return the result.
                            if (operationResult != null)
                            {
                                // check that the operation completed successfully
                                switch (operationResult.Status)
                                {
                                    case OperationStatus.canceled:
                                        throw new Exception("Operation was canceled.");
                                    case OperationStatus.failed:
                                        {
                                            Exception ex = new Exception("Operation failed.");
                                            ex.Data.Add("ErrorResponse", operationResult);
                                            throw ex;
                                        }
                                    case OperationStatus.succeeded:
                                        {
                                            if (operationResult.AnalyzeResult != null)
                                            {
                                                return operationResult.AnalyzeResult;
                                            }
                                            else
                                            {
                                                throw new Exception("Operation succeeded but no result was returned.");
                                            }
                                        }
                                    case OperationStatus.completed:
                                        {
                                            throw new Exception("Operation completed but not succeeded.");
                                        }
                                }
                            }
                            else
                            {
                                throw new Exception("Failed to deserialize classify document result.");
                            }
                        }
                        else
                        {
                            // Deserialize response into the error model and throw an exception with the error message.
                            ErrorResponse? err = JsonConvert.DeserializeObject<ErrorResponse>(operationResponseContent);

                            if (err != null)
                            {
                                Exception ex = new Exception($"Failed to classify document. Error: {err.Error?.Message}");
                                ex.Data.Add("ErrorResponse", err);
                                throw ex;
                            }
                            else
                            {
                                throw new Exception($"Failed to classify document. Response: {operationResponseContent}");
                            }
                        }

                        // Delay the polling interval based on the "Retry-After" header.
                        await Task.Delay(retryAfter * 1000, cancellationToken);
                    }   

                    // If the operation does not complete within the polling limit, throw an exception.
                    throw new TimeoutException("Operation timed out.");
                }
                else
                {
                    // Deserialize response into the error model and throw an exception with the error message.
                    var responseContent = await response.Content.ReadAsStringAsync(cancellationToken);
                    ErrorResponse? err = JsonConvert.DeserializeObject<ErrorResponse>(responseContent);

                    if (err != null)
                    {
                        Exception ex = new Exception($"Failed to classify document. Error: {err.Error?.Message}");
                        ex.Data.Add("ErrorResponse", err);
                        throw ex;
                    }
                    else
                    {
                        throw new Exception($"Failed to classify document. Response: {responseContent}");
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception occurred while classifying document.");
                throw;
            }
        }

        //        // Add a new method to classify a document from a stream
        //        public async Task<ClassifyDocumentResult> ClassifyDocumentFromStreamAsync(Stream documentStream)
        //        {
        //            string url = $"{_endpoint}/documentintelligence/classifyDocumentFromStream?api-version=2024-02-29-preview";

        //            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
        //            request.Headers.Add("Ocp-Apim-Subscription-Key", _apiKey);
        //            request.Content = new StreamContent(documentStream);
        //            request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/pdf");

        //            var response = await _httpClient.SendAsync(request);
        //            if (!response.IsSuccessStatusCode)
        //            {
        //                throw new Exception($"Failed to classify document from stream: {await response.Content.ReadAsStringAsync()}");
        //            }

        //            var resultJson = await response.Content.ReadAsStringAsync();
        //            var result = JsonConvert.DeserializeObject<ClassifyDocumentResult>(resultJson);
        //            if (result == null)
        //            {
        //                throw new Exception("Failed to deserialize classify document result.");
        //            }

        //            return result;
        //        }

        //        // Add a new method to delete a classifier
        //        public async Task DeleteClassifierAsync(string classifierId)
        //        {
        //            string url = $"{_endpoint}/documentintelligence/documentClassifiers/{classifierId}?api-version=2024-02-29-preview";

        //            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, url);
        //            request.Headers.Add("Ocp-Apim-Subscription-Key", _apiKey);

        //            var response = await _httpClient.SendAsync(request);
        //            if (!response.IsSuccessStatusCode)
        //            {
        //                throw new Exception($"Failed to delete classifier: {await response.Content.ReadAsStringAsync()}");
        //            }
        //        }

        //        // Add a new method to get a classifier
        //        public async Task<Models.DocumentClassifierDetails> GetClassifierAsync(string classifierId)
        //        {
        //            string url = $"{_endpoint}/documentintelligence/documentClassifiers/{classifierId}?api-version=2024-02-29-preview";

        //            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
        //            request.Headers.Add("Ocp-Apim-Subscription-Key", _apiKey);

        //            var response = await _httpClient.SendAsync(request);
        //            if (!response.IsSuccessStatusCode)
        //            {
        //                throw new Exception($"Failed to get classifier details: {await response.Content.ReadAsStringAsync()}");
        //            }

        //            var resultJson = await response.Content.ReadAsStringAsync();
        //            var result = JsonConvert.DeserializeObject<Models.DocumentClassifierDetails>(resultJson);
        //            if (result == null)
        //            {
        //                throw new Exception("Failed to deserialize classifier details.");
        //            }

        //            return result;
        //        }

        //        // Add a new method to get a classify result
        //        public async Task<ClassifyResult> GetClassifyResultAsync(string operationId)
        //        {
        //            string url = $"{_endpoint}/documentintelligence/classifyResults/{operationId}?api-version=2024-02-29-preview";

        //            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
        //            request.Headers.Add("Ocp-Apim-Subscription-Key", _apiKey);

        //            var response = await _httpClient.SendAsync(request);
        //            if (!response.IsSuccessStatusCode)
        //            {
        //                throw new Exception($"Failed to get classify result: {await response.Content.ReadAsStringAsync()}");
        //            }

        //            var resultJson = await response.Content.ReadAsStringAsync();
        //            var result = JsonConvert.DeserializeObject<ClassifyResult>(resultJson);
        //            if (result == null)
        //            {
        //                throw new Exception("Failed to deserialize classify result.");
        //            }

        //            return result;
        //        }

        //        //Add a new method to list classifiers
        //        public async Task<List<Models.DocumentClassifierDetails>> ListClassifiersAsync()
        //        {
        //            string url = $"{_endpoint}/documentClassifiers?api-version=2024-02-29-preview";

        //            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
        //            request.Headers.Add("Ocp-Apim-Subscription-Key", _apiKey);

        //            _logger.LogInformation($"Sending GET request to {url}");

        //            var response = await _httpClient.SendAsync(request);
        //            var responseContent = await response.Content.ReadAsStringAsync();

        //            if (!response.IsSuccessStatusCode)
        //            {
        //                _logger.LogError($"Failed to list classifiers. Status code: {response.StatusCode}, Response: {responseContent}");
        //                throw new Exception($"Failed to list classifiers: {responseContent}");
        //            }

        //            var result = JsonConvert.DeserializeObject<List<Models.DocumentClassifierDetails>>(responseContent)
        //                ?? throw new Exception("Failed to deserialize list of classifiers.");

        //            return result;
        //        }


        //        public async Task<AnalyzeDocumentResult> AnalyzeDocumentAsync(AnalyzeDocumentRequestBody requestBody)
        //        {
        //            string url = $"{_endpoint}/documentModels/analyzeDocument?api-version=2024-02-29-preview";

        //            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
        //            request.Headers.Add("Ocp-Apim-Subscription-Key", _apiKey);

        //            string json = JsonConvert.SerializeObject(requestBody);
        //            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

        //            _logger.LogInformation($"Sending POST request to {url} with body: {json}");

        //            try
        //            {
        //                var response = await _httpClient.SendAsync(request);
        //                var responseContent = await response.Content.ReadAsStringAsync();

        //                _logger.LogInformation($"Response Status Code: {response.StatusCode}");
        //                _logger.LogInformation($"Response Content: {responseContent}");

        //                if (!response.IsSuccessStatusCode)
        //                {
        //                    _logger.LogError($"Failed to analyze document. Status code: {response.StatusCode}, Response: {responseContent}");
        //                    throw new Exception($"Failed to analyze document: {responseContent}");
        //                }

        //                _logger.LogInformation($"Response received: {responseContent}");

        //                var result = JsonConvert.DeserializeObject<AnalyzeDocumentResult>(responseContent);
        //                if (result == null)
        //                {
        //                    _logger.LogError("Failed to deserialize analyze document result.");
        //                    throw new Exception("Failed to deserialize analyze document result.");
        //                }

        //                return result;
        //            }
        //            catch (Exception ex)
        //            {
        //                _logger.LogError(ex, "Exception occurred while analyzing document.");
        //                throw;
        //            }
        //        }

        //        public async Task<AnalyzeDocumentResult> AnalyzeDocumentFromStreamAsync(Stream documentStream)
        //        {
        //            string url = $"{_endpoint}/documentModels/analyzeDocumentFromStream?api-version=2024-02-29-preview";

        //            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
        //            request.Headers.Add("Ocp-Apim-Subscription-Key", _apiKey);
        //            request.Content = new StreamContent(documentStream);
        //            request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/pdf");

        //            _logger.LogInformation($"Sending POST request to {url} with stream content.");

        //            try
        //            {
        //                var response = await _httpClient.SendAsync(request);
        //                var responseContent = await response.Content.ReadAsStringAsync();

        //                _logger.LogInformation($"Response Status Code: {response.StatusCode}");
        //                _logger.LogInformation($"Response Content: {responseContent}");

        //                if (!response.IsSuccessStatusCode)
        //                {
        //                    _logger.LogError($"Failed to analyze document from stream. Status code: {response.StatusCode}, Response: {responseContent}");
        //                    throw new Exception($"Failed to analyze document from stream: {responseContent}");
        //                }

        //                _logger.LogInformation($"Response received: {responseContent}");

        //                var result = JsonConvert.DeserializeObject<AnalyzeDocumentResult>(responseContent);
        //                if (result == null)
        //                {
        //                    _logger.LogError("Failed to deserialize analyze document result.");
        //                    throw new Exception("Failed to deserialize analyze document result.");
        //                }

        //                return result;
        //            }
        //            catch (Exception ex)
        //            {
        //                _logger.LogError(ex, "Exception occurred while analyzing document from stream.");
        //                throw;
        //            }
        //        }

        //        public async Task<DocumentModelBuildOperationDetails> BuildModelAsync(BuildDocumentModelRequestBody requestBody)
        //        {
        //            string url = $"{_endpoint}/documentModels/buildModel?api-version=2024-02-29-preview";

        //            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
        //            request.Headers.Add("Ocp-Apim-Subscription-Key", _apiKey);

        //            string json = JsonConvert.SerializeObject(requestBody);
        //            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

        //            _logger.LogInformation($"Sending POST request to {url} with body: {json}");

        //            var response = await _httpClient.SendAsync(request);
        //            var responseContent = await response.Content.ReadAsStringAsync();

        //            if (!response.IsSuccessStatusCode)
        //            {
        //                _logger.LogError($"Failed to build model. Status code: {response.StatusCode}, Response: {responseContent}");
        //                throw new Exception($"Failed to build model: {responseContent}");
        //            }

        //            var operationLocation = response.Headers.GetValues("Operation-Location").FirstOrDefault();
        //            if (operationLocation == null)
        //            {
        //                _logger.LogError("Failed to get operation location for model build.");
        //                throw new Exception("Failed to get operation location for model build.");
        //            }

        //            _logger.LogInformation($"Operation location: {operationLocation}");

        //            for (int i = 0; i < 1000; i++)
        //            {
        //                var operationRequest = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}{operationLocation}");
        //                operationRequest.Headers.Add("Ocp-Apim-Subscription-Key", _apiKey);

        //                _logger.LogInformation($"Polling operation status at {_endpoint}{operationLocation}");

        //                var operationResponse = await _httpClient.SendAsync(operationRequest);
        //                var operationResponseContent = await operationResponse.Content.ReadAsStringAsync();

        //                if (!operationResponse.IsSuccessStatusCode)
        //                {
        //                    _logger.LogError($"Failed to poll operation location. Status code: {operationResponse.StatusCode}, Response: {operationResponseContent}");
        //                    throw new Exception($"Failed to poll operation location for model build: {operationResponseContent}");
        //                }

        //                var operationResult = JsonConvert.DeserializeObject<DocumentModelBuildOperationDetails>(operationResponseContent);
        //                if (operationResult == null)
        //                {
        //                    throw new Exception("Failed to deserialize model build operation result.");
        //                }

        //                if (operationResult.Status == "Succeeded")
        //                {
        //                    _logger.LogInformation("Model build succeeded.");
        //                    return operationResult;
        //                }

        //                if (operationResult.Status == "Failed")
        //                {
        //                    _logger.LogError($"Model build failed: {operationResult.Error?.Message}");
        //                    throw new Exception($"Model build failed: {operationResult.Error?.Message}");
        //                }

        //                await Task.Delay(1000);
        //            }

        //            _logger.LogError("Model build operation timed out.");
        //            throw new Exception("Model build operation timed out.");
        //        }

        //        public async Task DeleteModelAsync(string modelId)
        //        {
        //            string url = $"{_endpoint}/documentModels/{modelId}?api-version=2024-02-29-preview";

        //            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, url);
        //            request.Headers.Add("Ocp-Apim-Subscription-Key", _apiKey);

        //            _logger.LogInformation($"Sending DELETE request to {url}");

        //            var response = await _httpClient.SendAsync(request);
        //            if (!response.IsSuccessStatusCode)
        //            {
        //                var responseContent = await response.Content.ReadAsStringAsync();
        //                _logger.LogError($"Failed to delete model. Status code: {response.StatusCode}, Response: {responseContent}");
        //                throw new Exception($"Failed to delete model: {responseContent}");
        //            }

        //            _logger.LogInformation("Model deleted successfully.");
        //        }


        //        public async Task<AnalyzeDocumentResult> GetAnalyzeResultAsync(string operationId)
        //        {
        //            string url = $"{_endpoint}/documentModels/analyzeResults/{operationId}?api-version=2024-02-29-preview";

        //            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
        //            request.Headers.Add("Ocp-Apim-Subscription-Key", _apiKey);

        //            var response = await _httpClient.SendAsync(request);
        //            var responseContent = await response.Content.ReadAsStringAsync();

        //            if (!response.IsSuccessStatusCode)
        //            {
        //                _logger.LogError($"Failed to get analyze result. Status code: {response.StatusCode}, Response: {responseContent}");
        //                throw new Exception($"Failed to get analyze result: {responseContent}");
        //            }

        //            var result = JsonConvert.DeserializeObject<AnalyzeDocumentResult>(responseContent);
        //            return result ?? throw new Exception("Failed to deserialize analyze result.");
        //        }

        //    }
    }
}
