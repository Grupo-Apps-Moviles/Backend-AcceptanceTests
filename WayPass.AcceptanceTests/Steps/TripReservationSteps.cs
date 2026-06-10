using Reqnroll;
using WayPass.AcceptanceTests.Support;

namespace WayPass.AcceptanceTests.Steps;

[Binding]
public class TripReservationSteps
{
    private readonly Support.ScenarioContext _ctx;
    public TripReservationSteps(Support.ScenarioContext ctx) => _ctx = ctx;

    // Pasos reutilizados desde otros steps:
    //   Given the WayPass backend is running              (PassengerAuthenticationSteps)
    //   Given I am an authenticated Passenger             (PassengerAuthenticationSteps)
    //   Then the response status should be {int}          (PassengerAuthenticationSteps)

    [Given(@"an active route with id ""(.*)"" exists")]
    public void GivenActiveRouteExists(string routeId) { /* TODO(impl) */ }

    [Given(@"an inactive route with id ""(.*)"" exists")]
    public void GivenInactiveRouteExists(string routeId) { /* TODO(impl) */ }

    [Given(@"I am not authenticated")]
    public void GivenNotAuthenticated() { _ctx.AuthToken = null; }

    [Given(@"I have at least one confirmed reservation")]
    public void GivenConfirmedReservationExists() { /* TODO(impl) */ }

    [When(@"I send a reservation request for route ""(.*)""")]
    public void WhenSendReservationRequest(string routeId) { /* TODO(impl) */ }

    [When(@"I request my reservations")]
    public void WhenRequestMyReservations() { /* TODO(impl) */ }

    [Then(@"the reservation status should be ""(.*)""")]
    public void ThenReservationStatusIs(string status) { /* TODO(impl) */ }

    [Then(@"the response should include the reservation identifier")]
    public void ThenResponseIncludesReservationId() { /* TODO(impl) */ }

    [Then(@"the response should include an error message about route availability")]
    public void ThenResponseIncludesRouteError() { /* TODO(impl) */ }

    [Then(@"the returned list should include my confirmed reservation")]
    public void ThenListIncludesConfirmedReservation() { /* TODO(impl) */ }
}