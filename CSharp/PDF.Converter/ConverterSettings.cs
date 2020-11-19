namespace PDF.Generator.Domain.ExternalServices
{
    using System;
    using DinkToPdf;

    public class ConverterSettings : GlobalSettings
    {
        public new string DocumentTitle { get; }

        private Action<string> IsValid => (document) =>
        {
            if (string.IsNullOrEmpty(document) || string.IsNullOrWhiteSpace(document) || document.Length < 3)
                throw new ArgumentException("Titulo obrigatorio");
        };

        public new ColorMode ColorMode => ColorMode.Color;
        public new Orientation Orientation = Orientation.Portrait;
        public new MarginSettings Margins = new MarginSettings() {Top = 10};

        public ConverterSettings(string documentTitle)
        {
            IsValid(documentTitle);
            DocumentTitle = documentTitle;
        }
    }
}