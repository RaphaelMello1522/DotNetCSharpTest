using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Requester
{
    internal class Program
    {
        private const string PORTAL_URL = "http://localhost:5000/Home/Index";
        private static readonly CancellationTokenSource source = new CancellationTokenSource();
        private static readonly CancellationToken token = source.Token;

        private static void Main(string[] args)
        {
            Console.CancelKeyPress += (o, e) => source.Cancel();

            do
            {
                Console.Write("Número de Requests concorrentes: ");

                var requestQty = int.Parse(Console.ReadLine());
                var tasks = new Task[requestQty];

                for (int i = 0; i < requestQty; i++)
                {
                    var x = i;

                    tasks[i] = Task.Run(() => DoRequest(x));
                }

                Task.WaitAll(tasks);
                Console.WriteLine(Environment.NewLine);
            }
            while (!token.IsCancellationRequested);
        }

        private static void DoRequest(int requestId)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var result = httpClient.GetStringAsync(PORTAL_URL).Result;
                    Console.WriteLine($"Request {requestId} => Ok: {!string.IsNullOrEmpty(result)}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Request {requestId} => Erro: {ex.Message}");
            }
        }
    }
}