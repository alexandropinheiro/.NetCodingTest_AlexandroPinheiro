using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.IO;
using System.Net.Http;

namespace Testes.Env
{
    public class Environment
    {
        public static TestServer Server { get; set; }
        public static HttpClient Client { get; set; }

        public static void CriarServidor()
        {
            Server = new TestServer(
                new WebHostBuilder()
                    .UseContentRoot(Directory.GetCurrentDirectory())
                    .UseUrls("http://localhost:8285"));

            Client = Server.CreateClient();
        }
    }
}
