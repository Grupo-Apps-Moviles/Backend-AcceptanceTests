using Reqnroll;
using WayPass.AcceptanceTests.Support;

namespace WayPass.AcceptanceTests.Steps;

[Binding]
public class StopFilteringSteps
{
    private readonly Support.ScenarioContext _ctx;
    public StopFilteringSteps(Support.ScenarioContext ctx) => _ctx = ctx;

    // Pasos reutilizados desde PassengerAuthenticationSteps:
    //   Given the WayPass backend is running
    //   Then the response status should be {int}

    [Given(@"there are stops registered in the system")]
    public void GivenStopsExist() { /* TODO(impl) */ }

    [Given(@"there are no stops for the selected location")]
    public void GivenNoStopsForLocation() { /* TODO(impl) */ }

    [When(@"I request stops filtered by region, province, district and locality")]
    public void WhenFilterStopsByHierarchy() { /* TODO(impl) */ }

    [When(@"I request stops filtered by that location")]
    public void WhenFilterStopsByThatLocation() { /* TODO(impl) */ }

    [Then(@"every returned stop should match the selected location filters")]
    public void ThenEveryStopMatchesFilters() { /* TODO(impl) */ }

    [Then(@"the returned stops list should be empty")]
    public void ThenReturnedStopsEmpty() { /* TODO(impl) */ }
}