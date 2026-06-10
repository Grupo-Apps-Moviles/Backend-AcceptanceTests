using RestSharp;

namespace WayPass.AcceptanceTests.Support;

public class ScenarioContext
{
    public string? AuthToken { get; set; }
    public string? CurrentUserId { get; set; }
    public RestResponse? LastResponse { get; set; }
    public Dictionary<string, object> Data { get; } = new();
}