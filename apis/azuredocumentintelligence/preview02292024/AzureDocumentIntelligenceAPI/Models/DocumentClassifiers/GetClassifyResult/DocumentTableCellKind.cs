namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.GetClassifyResult
{
    /// <summary>
    /// Table cell kind.
    /// </summary>
    public enum DocumentTableCellKind
    {
        /// <summary>
        /// Describes the content of the column.
        /// </summary>
        columnHeader,

        /// <summary>
        /// Contains the main content/data.
        /// </summary>
        content,

        /// <summary>
        /// Describes the content in (parts of) the table.
        /// </summary>
        description,

        /// <summary>
        /// Describes the content of the row.
        /// </summary>
        rowHeader,

        /// <summary>
        /// Describes the row headers, usually located at the top left corner of a table.
        /// </summary>
        stubHead
    }
}
