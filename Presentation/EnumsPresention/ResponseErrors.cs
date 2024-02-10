using System.Text.Json;

namespace Presentation.EnumsPresention
{
    public class ResponseErrors
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; }


        public List<string> Messages { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
