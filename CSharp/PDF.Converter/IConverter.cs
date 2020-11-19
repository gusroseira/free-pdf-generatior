using System.Threading.Tasks;

namespace PDF.Generator.Domain.ExternalServices
{
    public interface IConverter
    {
        Task<byte[]> ConvertAsync(string obj, ConverterSettings settings);
    }
}