using System.IO;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using PdfSharp.Pdf.Security;

namespace PDF.Security
{
    public sealed class SecurtiyIssuer
    {
        /// <summary>
        /// Issue the pdf security 
        /// </summary>
        /// <param name="stream">pdf in stream format</param>
        /// <param name="pdfPassword">Password</param>
        /// <param name="settings">Security Settings</param>
        /// <returns></returns>
        public async Task<Stream> IssueAsync(Stream stream, string pdfPassword, SecuritySettings settings)
        {
            PdfDocument document = PdfSharp.Pdf.IO.PdfReader.Open(stream);
            PdfSecuritySettings securitySettings = document.SecuritySettings;
            securitySettings.UserPassword = pdfPassword;
            securitySettings.PermitAccessibilityExtractContent = settings.PermitAccessibilityExtractContent;
            securitySettings.PermitAnnotations = settings.PermitAnnotations;
            securitySettings.PermitModifyDocument = settings.PermitModifyDocument;
            securitySettings.PermitPrint = settings.PermitModifyDocument;
            document.Save(stream);

            return await Task.FromResult(stream);
            
        }
    }
}