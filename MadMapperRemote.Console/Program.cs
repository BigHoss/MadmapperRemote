using MadMapperRemote.Core;

namespace MadMapperRemote.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            MadMapperConnection connection = new MadMapperConnection("http://localhost:8010");

            connection.OpenConnection();
        }
    }
}
