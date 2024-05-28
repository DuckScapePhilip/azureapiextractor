﻿namespace AzureDocumentIntelligenceAPI.Models.ClassifyResult
{
    /// <summary>
    /// Presence of signature.
    /// </summary>
    public enum DocumentSignatureType
    {
        /// <summary>
        /// A signature is detected.
        /// </summary>
        signed,

        /// <summary>
        /// No signatures are detected.
        /// </summary>
        unsigned
    }
}
