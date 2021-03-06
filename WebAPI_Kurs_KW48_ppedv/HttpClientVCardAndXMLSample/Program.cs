using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace HttpClientVCardAndXMLSample
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string baseUrl = "https://localhost:5001/api/VCardFormatter";

            Console.ReadLine();
            using HttpClient client = new ();
            
            

            // Client möchte eine Anfrage stellen und erstellt seinen Request 
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, baseUrl);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("text/vcard"));


            HttpResponseMessage response = await client.SendAsync(request);

            //auslesen des Responseergebnisses
            string result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result);
            Console.ReadKey();





            //using HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:5001/api/VCardFormatter");



        }
    }
}
