using Newtonsoft.Json;
namespace urmom;
public class Bored
{
    public string? activity { get; set; }
    public string? type { get; set; }
    public int participants { get; set; }
    public float price { get; set; }
}
public static class Program
{
    static HttpClient client = new HttpClient();
    public static async Task Main()
    {
        await WR();
    }
    public static async Task<Bored> MainAsync()
    {
        string? request = await client.GetStringAsync("https://www.boredapi.com/api/activity/");
        Bored? cure = JsonConvert.DeserializeObject<Bored>(request);//! needs a new place
        return JsonConvert.DeserializeObject<Bored?>(request);
    }
    public static async Task WR()
    {
        Bored cure = await MainAsync();//*this sets the results of mainasync to the object cure of type Bored
        Console.WriteLine(cure.activity);
        Console.WriteLine(cure.participants);
    }
}