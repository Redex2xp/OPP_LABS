

using System.Diagnostics;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using laba_2_noasyn;

Stopwatch timer = new Stopwatch();
timer.Start();

HttpClient sharedClient = new()
{
    BaseAddress = new Uri("https://api.hh.ru"),
};
sharedClient.DefaultRequestHeaders.Add("User-Agent", "MyApp");

var r1 = new Request();
var text = r1.Get(sharedClient, "vacancies?text=C# developer");
Console.WriteLine($"{text}\n");
text = r1.Get(sharedClient, "vacancies?text=C++ developer");
Console.WriteLine($"{text}\n");
text = r1.Get(sharedClient, "vacancies?text=Go developer");
Console.WriteLine($"{text}\n");

timer.Stop();
Console.WriteLine($"Times: {timer.ElapsedMilliseconds} ms");