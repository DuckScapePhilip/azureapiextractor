namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.GetClassifyResult
{
    /// <summary>
    /// The unit used by the width, height, and polygon properties. For images, the unit is "pixel". For PDF, the unit is "inch".
    /// </summary>
    public enum LenghtUnit
    {
        /// <summary>
        /// Length unit for PDF files.
        /// </summary>
        inch,

        /// <summary>
        /// Length unit for image files.
        /// </summary>
        pixel
    }
}
