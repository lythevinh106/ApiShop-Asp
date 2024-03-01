using System.Text.Json;

namespace Service.Errors
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

    public abstract class Exceptions : Exception
    {


        public Exceptions(string message) : base(message)
        {


        }



    }



    public class ConflicDataException : Exceptions
    {
        public ConflicDataException(string message) : base(message)
        {
        }
    }
}
