namespace AzureDocumentIntelligenceAPI.Models.DocumentModels.GetAnalyzeResult
{
    /// <summary>
    /// Semantic role of the paragraph.
    /// </summary>
    public enum ParagraphRole
    {
        /// <summary>
        /// A note usually placed after the main content on a page.
        /// </summary>
        footnote,

        /// <summary>
        /// A block of formulas, often with shared alignment.
        /// </summary>
        formulaBlock,

        /// <summary>
        /// Text near the bottom edge of the page.
        /// </summary>
        pageFooter,

        /// <summary>
        /// Text near the top edge of the page.
        /// </summary>
        pageHeader,

        /// <summary>
        /// Page number.
        /// </summary>
        pageNumber,

        /// <summary>
        /// Sub heading describing a section of the document.
        /// </summary>
        sectionHeading,

        /// <summary>
        /// Top-level title describing the entire document.
        /// </summary>
        title
    }
}
