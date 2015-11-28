using System.Net.Http.Formatting;
using Newtonsoft.Json;

namespace Wondercard.Client.Gateway
{
    public static class FormatterConfig
    {
        public static void ConfigureFormatters(MediaTypeFormatterCollection formatters)
        {
            var settings = formatters.JsonFormatter.SerializerSettings;
            settings.Formatting = Formatting.Indented;
        }
    }
}