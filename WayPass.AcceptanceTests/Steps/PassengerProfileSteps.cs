using Reqnroll;
using WayPass.AcceptanceTests.Support;

namespace WayPass.AcceptanceTests.Steps;

[Binding]
public class PassengerProfileSteps
{
    private readonly Support.ScenarioContext _ctx;
    public PassengerProfileSteps(Support.ScenarioContext ctx) => _ctx = ctx;

    // Pasos reutilizados desde PassengerAuthenticationSteps:
    //   Given the WayPass backend is running
    //   Given I am an authenticated Passenger
    //   Then the response status should be {int}

    [Given(@"I have a valid profile update payload")]
    public void GivenValidProfilePayload() { /* TODO(impl) */ }

    [Given(@"I have an invalid profile update payload")]
    public void GivenInvalidProfilePayload() { /* TODO(impl) */ }

    [When(@"I request the profile associated to my user id")]
    public void WhenRequestProfile() { /* TODO(impl) */ }

    [When(@"I send a profile update request")]
    public void WhenSendProfileUpdate() { /* TODO(impl) */ }

    [Then(@"the response should include my profile information")]
    public void ThenResponseIncludesProfileInfo() { /* TODO(impl) */ }

    [Then(@"the profile should reflect the updated information")]
    public void ThenProfileReflectsUpdate() { /* TODO(impl) */ }
}