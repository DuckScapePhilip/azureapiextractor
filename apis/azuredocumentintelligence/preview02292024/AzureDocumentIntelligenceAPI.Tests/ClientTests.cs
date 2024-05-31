using AzureDocumentIntelligenceAPI.Services;
using Extensions.Logging.NUnit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AzureDocumentIntelligenceAPI.Tests
{
    [TestFixture]
    public class Tests
    {
        IConfiguration Configuration { get; set; }
        ILoggerFactory loggerFactory;


        string endpoint = "";
        string apiKey = "";
        string storageSasUrl = "";

        string testDataDir = Path.Combine(Directory.GetCurrentDirectory(), "TestData");

        HttpClient client = new HttpClient();
        AzureDocumentIntelligenceClient azureClient;

        [OneTimeSetUp]
        public void Setup()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<Tests>(); // Make sure this class is in the same assembly as the secrets ID
            Configuration = builder.Build();

            endpoint = Configuration["AZURE_API_ENDPOINT"] ?? throw new Exception("AZURE_API_ENDPOINT not set in user secrets.");
            apiKey = Configuration["AZURE_API_KEY"] ?? throw new Exception("AZURE_API_KEY not set in user secrets.");
            storageSasUrl = Configuration["AZURE_STORAGE_SAS_URL"] ?? throw new Exception("AZURE_STORAGE_SAS_URL not set in user secrets.");

            // build a dummy ILoggerFactory
            loggerFactory = new LoggerFactory();
            loggerFactory.AddProvider(new NUnitLoggerProvider());

            // build the azure client
            azureClient = new AzureDocumentIntelligenceClient(client, endpoint, apiKey, loggerFactory.CreateLogger<AzureDocumentIntelligenceClient>());
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            // clean up
            loggerFactory.Dispose();
            client.Dispose();
        }

        [Test]
        [Order(1)]
        public void AnalyzeDocument_PrebuiltModel()
        {
            // loop through each ".pdf" file in our test data directory
            foreach (var file in Directory.GetFiles(testDataDir, "*.pdf"))
            {
                // analyze the document
                //TODO: var result = azureClient.AnalyzeDocumentAsync("prebuilt-layout", file);

                // verify it generated the ".ocr.json" file
                var ocrFile = file + ".ocr.json";
                Assert.IsTrue(File.Exists(ocrFile), $"Expected file {ocrFile} not found.");
            }
        }

        [Test]
        [Order(2)]
        public void BuildClassificationModel()
        {
            var azureClient = new AzureDocumentIntelligenceClient(client, endpoint, apiKey, loggerFactory.CreateLogger<AzureDocumentIntelligenceClient>());

            // TODO: building this requires to specify a storage account SAS URL and two sets of documents to train the model for classification

            // {
            //     "classifierId": "unittest_{Guid.NewGuid().ToString()}",
            //     "description": "Unit testing our api SDK.",
            //     "docTypes": {
            //        "catchforms": {
            //           "azureBlobSource": {
            //              "containerUrl": "{storageSasUrl}",
            //              "prefix": "classifications/trial/1032874/training/catchforms/"
            //           }
            //        },
            //        "compravenda": {
            //           "azureBlobSource": {
            //              "containerUrl": "{storageSasUrl}",
            //              "prefix": "classifications/trial/1032874/training/compravenda/"
            //           }
            //        }
            //     }
            // }      
        }

        [Test]
        [Order(3)]
        public void ClassifyDocument_CustomModel()
        {
            // TODO: test classifying a document using our custom model

            // loop through each ".pdf" file in our test data directory
            foreach (var file in Directory.GetFiles(testDataDir, "*.pdf"))
            {
                // analyze the document
                // var result = azureClient.ClassifyDocumentAsync("{custom_model_classifier_id}", file);

                // TODO: verify the classification is "catchforms"
            }
        }
    }
}