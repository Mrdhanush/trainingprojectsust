using System.Net;
using System.Text;

namespace webreqconsoleapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebRequest req = WebRequest.Create("http://www.microsoft.com");
            WebResponse response = req.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.ASCII);
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}
