namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.GetClassifyResult
{
    /// <summary>
    /// Barcode kind.
    /// </summary>
    public enum DocumentBarcodeKind
    {
        /// <summary>
        /// Aztec code, as defined in ISO/IEC 24778:2008.
        /// </summary>
        Aztec,

        /// <summary>
        /// Codabar barcode, as defined in ANSI/AIM BC3-1995.
        /// </summary>
        Codabar,

        /// <summary>
        /// Code 128 barcode, as defined in ISO/IEC 15417:2007.
        /// </summary>
        Code128,

        /// <summary>
        /// Code 39 barcode, as defined in ISO/IEC 16388:2007.
        /// </summary>
        Code39,

        /// <summary>
        /// Code 93 barcode, as defined in ANSI/AIM BC5-1995.
        /// </summary>
        Code93,

        /// <summary>
        /// GS1 DataBar barcode.
        /// </summary>
        DataBar,

        /// <summary>
        /// GS1 DataBar Expanded barcode.
        /// </summary>
        DataBarExpanded,

        /// <summary>
        /// Data matrix code, as defined in ISO/IEC 16022:2006.
        /// </summary>
        DataMatrix,

        /// <summary>
        /// GS1 13-digit International Article double (European Article double).
        /// </summary>
        EAN13,

        /// <summary>
        /// GS1 8-digit International Article double (European Article double).
        /// </summary>
        EAN8,

        /// <summary>
        /// Interleaved 2 of 5 barcode, as defined in ANSI/AIM BC2-1995.
        /// </summary>
        ITF,

        /// <summary>
        /// MaxiCode, as defined in ISO/IEC 16023:2000.
        /// </summary>
        MaxiCode,

        /// <summary>
        /// Micro QR code, as defined in ISO/IEC 23941:2022.
        /// </summary>
        MicroQRCode,

        /// <summary>
        /// PDF417, as defined in ISO 15438.
        /// </summary>
        PDF417,

        /// <summary>
        /// QR code, as defined in ISO/IEC 18004:2015.
        /// </summary>
        QRCode,

        /// <summary>
        /// GS1 12-digit Universal Product Code.
        /// </summary>
        UPCA,

        /// <summary>
        /// GS1 6-digit Universal Product Code.
        /// </summary>
        UPCE
    }
}
