namespace PDF.Security
{
    public class SecuritySettings
    {
        public bool PermitAccessibilityExtractContent { get; }

        public bool PermitAnnotations { get; }

        public bool PermitModifyDocument { get; }

        public bool PermitPrint { get; }

        public bool PermitFullQualityPrint { get; }

        public SecuritySettings(bool permitAccessibilityExtractContent, bool permitAnnotations,
            bool permitModifyDocument, bool permitPrint, bool permitFullQualityPrint)
        {
            PermitAccessibilityExtractContent = permitAccessibilityExtractContent;
            PermitAnnotations = permitAnnotations;
            PermitModifyDocument = permitModifyDocument;
            PermitPrint = permitPrint;
            PermitFullQualityPrint = permitFullQualityPrint;
        }
    }
}