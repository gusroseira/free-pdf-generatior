using System.Threading.Tasks;
using DinkToPdf;

namespace PDF.Generator.Domain.ExternalServices
{
    public sealed class Converter : IConverter
    {
        private readonly DinkToPdf.Contracts.IConverter _converter;
        public Converter(DinkToPdf.Contracts.IConverter converter)
        {
            _converter = converter;
        }

        /// <summary>
        /// Convert html string to pdf without security
        /// </summary>
        /// <param name="obj">String in html format</param>
        /// <param name="settings">Settings to build pdf</param>
        /// <returns>pdf in array byte</returns>
        public async Task<byte[]> ConvertAsync(string obj, ConverterSettings settings)
        {
            if (string.IsNullOrEmpty(obj) || string.IsNullOrWhiteSpace(obj)) return await Task.FromResult(new byte[0]);
        
            var objectSettings = new ObjectSettings { PagesCount = true, HtmlContent = obj };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = settings,
                Objects = { objectSettings }
            };

            return await Task.FromResult(_converter.Convert(pdf));
        }
    }
}