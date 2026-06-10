using RestSharp;

namespace WayPass.AcceptanceTests.Support;

public static class ApiClient
{
    public static string BaseUrl =>
        Environment.GetEnvironmentVariable("WAYPASS_API_BASE")
        ?? "https://backendmoviles-hqu5.onrender.com";

    public static RestClient Create() => new RestClient(BaseUrl);
}