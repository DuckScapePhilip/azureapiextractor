using Microsoft.AspNetCore.Mvc;
using AzureDocumentIntelligenceAPI.Services;
using AzureDocumentIntelligenceAPI.Models;
using AzureDocumentIntelligenceAPI.Models.ClassifyDocument;
using AzureDocumentIntelligenceAPI.Models.ClassifyDocument;

namespace AzureDocumentIntelligenceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly AzureDocumentIntelligenceClient _client;
        private readonly ILogger<TestController> _logger;

        public TestController(AzureDocumentIntelligenceClient client, ILogger<TestController> logger)
        {
            _client = client;
            _logger = logger;
        }

        //[HttpPost("build-classifier")]
        //public async Task<IActionResult> BuildClassifier(BuildDocumentClassifierRequestBody requestBody)
        //{
        //    try
        //    {
        //        _logger.LogInformation("Received request to build classifier.");
        //        var result = await _client.BuildClassifierAsync(requestBody);
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, $"Error occurred while building classifier. {ex.Message}");
        //        return StatusCode(500, $"Erro: {ex.Message}\n{ex.StackTrace}");
        //    }
        //}

        [HttpPost("classify-document")]
        public async Task<IActionResult> ClassifyDocument(ClassifyDocumentRequestBody requestBody)
        {
            try
            {
                _logger.LogInformation("Received request to classify document.");
                var result = await _client.ClassifyDocumentAsync(requestBody);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occurred while classifying document. {ex.Message}");
                return StatusCode(500, $"Erro: {ex.Message}\n{ex.StackTrace}");
            }
        }

        //[HttpPost("classify-document-from-stream")]
        //public async Task<IActionResult> ClassifyDocumentFromStream()
        //{
        //    try
        //    {
        //        using (var stream = new MemoryStream())
        //        {
        //            await Request.Body.CopyToAsync(stream);
        //            stream.Seek(0, SeekOrigin.Begin);
        //            var result = await _client.ClassifyDocumentFromStreamAsync(stream);
        //            return Ok(result);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, $"Erro: {ex.Message}");
        //    }
        //}

        //[HttpDelete("delete-classifier/{classifierId}")]
        //public async Task<IActionResult> DeleteClassifier(string classifierId)
        //{
        //    try
        //    {
        //        await _client.DeleteClassifierAsync(classifierId);
        //        return NoContent();
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, $"Erro: {ex.Message}");
        //    }
        //}

        //[HttpGet("get-classifier/{classifierId}")]
        //public async Task<IActionResult> GetClassifier(string classifierId)
        //{
        //    try
        //    {
        //        var result = await _client.GetClassifierAsync(classifierId);
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, $"Erro: {ex.Message}");
        //    }
        //}

        //[HttpGet("get-classify-result/{operationId}")]
        //public async Task<IActionResult> GetClassifyResult(string operationId)
        //{
        //    try
        //    {
        //        var result = await _client.GetClassifyResultAsync(operationId);
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, $"Erro: {ex.Message}");
        //    }
        //}

        //[HttpGet("list-classifiers")]
        //public async Task<IActionResult> ListClassifiers()
        //{
        //    try
        //    {
        //        var result = await _client.ListClassifiersAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, $"Error occurred while listing classifiers. {ex.Message}");
        //        return StatusCode(500, $"Erro: {ex.Message}");
        //    }
        //}


        //[HttpPost("analyze-document")]
        //public async Task<IActionResult> AnalyzeDocument([FromBody] AnalyzeDocumentRequestBody requestBody)
        //{
        //    try
        //    {
        //        _logger.LogInformation("Received request to analyze document.");
        //        var result = await _client.AnalyzeDocumentAsync(requestBody);
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, $"Error occurred while analyzing document. {ex.Message}");
        //        return StatusCode(500, $"Erro: {ex.Message}\n{ex.StackTrace}");
        //    }
        //}

        //[HttpPost("analyze-document-from-stream")]
        //public async Task<IActionResult> AnalyzeDocumentFromStream()
        //{
        //    try
        //    {
        //        _logger.LogInformation("Received request to analyze document from stream.");
        //        using (var stream = new MemoryStream())
        //        {
        //            await Request.Body.CopyToAsync(stream);
        //            stream.Seek(0, SeekOrigin.Begin);
        //            var result = await _client.AnalyzeDocumentFromStreamAsync(stream);
        //            return Ok(result);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, $"Error occurred while analyzing document from stream. {ex.Message}");
        //        return StatusCode(500, $"Erro: {ex.Message}\n{ex.StackTrace}");
        //    }
        //}

        //[HttpPost("build-model")]
        //public async Task<IActionResult> BuildModel([FromBody] BuildDocumentModelRequestBody requestBody)
        //{
        //    try
        //    {
        //        _logger.LogInformation("Received request to build model.");
        //        var result = await _client.BuildModelAsync(requestBody);
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, $"Error occurred while building model. {ex.Message}");
        //        return StatusCode(500, $"Erro: {ex.Message}\n{ex.StackTrace}");
        //    }
        //}

        //[HttpDelete("delete-model/{modelId}")]
        //public async Task<IActionResult> DeleteModel(string modelId)
        //{
        //    try
        //    {
        //        _logger.LogInformation($"Received request to delete model with modelId: {modelId}");
        //        await _client.DeleteModelAsync(modelId);
        //        return NoContent();
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, $"Error occurred while deleting model. {ex.Message}");
        //        return StatusCode(500, $"Erro: {ex.Message}\n{ex.StackTrace}");
        //    }
        //}

        //[HttpGet("get-analyze-result/{operationId}")]
        //public async Task<IActionResult> GetAnalyzeResult(string operationId)
        //{
        //    try
        //    {
        //        _logger.LogInformation($"Received request to get analyze result with operationId: {operationId}");
        //        var result = await _client.GetAnalyzeResultAsync(operationId);
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, $"Error occurred while getting analyze result. {ex.Message}");
        //        return StatusCode(500, $"Erro: {ex.Message}\n{ex.StackTrace}");
        //    }
        //}

    }
}
