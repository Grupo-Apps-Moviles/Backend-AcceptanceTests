using FluentAssertions;
using Reqnroll;
using RestSharp;
using System.Text.Json;
using WayPass.AcceptanceTests.Support;

namespace WayPass.AcceptanceTests.Steps;

[Binding]
public class PassengerAuthenticationSteps
{
    private readonly Support.ScenarioContext _ctx;
    private readonly RestClient _client = ApiClient.Create();
    private object? _payload;

    public PassengerAuthenticationSteps(Support.ScenarioContext ctx) => _ctx = ctx;

    [Given(@"the WayPass backend is running")]
    public void GivenBackendIsRunning() { /* sanity precondition */ }

    [Given(@"I am a new visitor with valid registration data")]
    public void GivenNewVisitorValid()
    {
        _payload = new
        {
            username = $"passenger_{Guid.NewGuid():N}",
            email = $"user_{Guid.NewGuid():N}@waypass.test",
            password = "Passw0rd!",
            role = "Passenger"
        };
    }

    [Given(@"I am a new visitor with invalid registration data")]
    public void GivenNewVisitorInvalid()
    {
        _payload = new { username = "", email = "not-an-email", password = "", role = "" };
    }

    [Given(@"a Passenger account already exists")]
    public void GivenPassengerAccountExists()
    {
        _payload = new { username = "test_passenger", password = "Passw0rd!" };
    }

    [Given(@"I am an authenticated Passenger")]
    public void GivenAuthenticatedPassenger()
    {
        _ctx.AuthToken = "stub-jwt-token";
    }

    [When(@"I submit a sign-up request as a Passenger")]
    public void WhenSignUp()
    {
        var request = new RestRequest("/api/v1/auth/sign-up", Method.Post).AddJsonBody(_payload!);
        _ctx.LastResponse = _client.Execute(request);
    }

    [When(@"I submit a sign-in request with valid credentials")]
    public void WhenSignInValid()
    {
        var request = new RestRequest("/api/v1/auth/sign-in", Method.Post).AddJsonBody(_payload!);
        _ctx.LastResponse = _client.Execute(request);
    }

    [When(@"I submit a sign-in request with wrong credentials")]
    public void WhenSignInWrong()
    {
        var request = new RestRequest("/api/v1/auth/sign-in", Method.Post)
            .AddJsonBody(new { username = "test_passenger", password = "wrong-password" });
        _ctx.LastResponse = _client.Execute(request);
    }

    [When(@"I sign out from the platform")]
    public void WhenSignOut()
    {
        _ctx.AuthToken = null;
    }

    [Then(@"the response status should be (\d+)")]
    public void ThenResponseStatusShouldBe(int expected)
    {
        ((int)_ctx.LastResponse!.StatusCode).Should().Be(expected);
    }

    [Then(@"the response should include the new user identifier")]
    public void ThenResponseIncludesUserId()
    {
        _ctx.LastResponse!.Content.Should().NotBeNullOrEmpty();
        using var doc = JsonDocument.Parse(_ctx.LastResponse.Content!);
        doc.RootElement.TryGetProperty("id", out _).Should().BeTrue();
    }

    [Then(@"the response should include a JWT token")]
    public void ThenResponseIncludesJwt()
    {
        _ctx.LastResponse!.Content.Should().NotBeNullOrEmpty();
        using var doc = JsonDocument.Parse(_ctx.LastResponse.Content!);
        doc.RootElement.TryGetProperty("token", out var token).Should().BeTrue();
        token.GetString().Should().NotBeNullOrWhiteSpace();
    }

    [Then(@"my session token should no longer be valid")]
    public void ThenTokenNoLongerValid()
    {
        _ctx.AuthToken.Should().BeNull();
    }
}