
using System.Collections;

namespace Model.Contracts
{
    public interface ISeedable
    {


        IList Seed();

    }



    public class SeedGuid
    {

        public static List<string> ListGuid { get; private set; } = new List<string>
        {
            "79640b64-94d3-4cb2-89c8-a5fefe3c2051",
            "79640b64-94d3-4cb2-89c8-a5fefe3c2052",
            "79640b64-94d3-4cb2-89c8-a5fefe3c2053",
            "79640b64-94d3-4cb2-89c8-a5fefe3c2054",
            "79640b64-94d3-4cb2-89c8-a5fefe3c2055",
            "79640b64-94d3-4cb2-89c8-a5fefe3c2056",
            "79640b64-94d3-4cb2-89c8-a5fefe3c2057",
            "79640b64-94d3-4cb2-89c8-a5fefe3c2058",
            "79640b64-94d3-4cb2-89c8-a5fefe3c2059",


        };

        //private static List<Guid> GenerateGuids()
        //{
        //    List<Guid> result = new List<Guid>();

        //    for (int i = 0; i < 10; i++)
        //    {
        //        result.Add(Guid.NewGuid());
        //    }

        //    return result;
        //}



    }


}
