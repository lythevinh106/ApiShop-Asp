using System.Text.Json;

namespace Presentation.Errors
{
    public class ResponseModelErrors
    {

        public int StatusCode { get; set; }


        public Dictionary<string, List<string>> Message { get; set; }

        public override string ToString()
        {

            return JsonSerializer.Serialize(this);
        }
    }
}
