using Reqnroll;
using WayPass.AcceptanceTests.Support;

namespace WayPass.AcceptanceTests.Steps;

[Binding]
public class RouteSearchSteps
{
    private readonly Support.ScenarioContext _ctx;
    public RouteSearchSteps(Support.ScenarioContext ctx) => _ctx = ctx;

    // Pasos reutilizados desde PassengerAuthenticationSteps:
    //   Given the WayPass backend is running
    //   Then the response status should be {int}

    [Given(@"there are active routes registered in the system")]
    public void GivenActiveRoutesExist() { /* TODO(impl) */ }

    [Given(@"there are no routes for the selected location")]
    public void GivenNoRoutesForLocation() { /* TODO(impl) */ }

    [Given(@"a route with id ""(.*)"" exists")]
    public void GivenRouteExists(string routeId) { /* TODO(impl) */ }

    [Given(@"no route with id ""(.*)"" exists")]
    public void GivenRouteDoesNotExist(string routeId) { /* TODO(impl) */ }

    [Given(@"I previously filtered routes by a specific location")]
    public void GivenPreviouslyFilteredRoutes() { /* TODO(impl) */ }

    [When(@"I request routes filtered by a specific region, province, district and city")]
    public void WhenFilterRoutesByFullHierarchy() { /* TODO(impl) */ }

    [When(@"I request routes filtered by that location")]
    public void WhenFilterRoutesByThatLocation() { /* TODO(impl) */ }

    [When(@"I request routes filtered by a specific location")]
    public void WhenFilterRoutesBySpecificLocation() { /* TODO(impl) */ }

    [When(@"I request the details of route ""(.*)""")]
    public void WhenRequestRouteDetail(string routeId) { /* TODO(impl) */ }

    [When(@"I re-send the same filter request")]
    public void WhenReSendFilterRequest() { /* TODO(impl) */ }

    [Then(@"every returned route should match the selected location filters")]
    public void ThenEveryRouteMatchesFilters() { /* TODO(impl) */ }

    [Then(@"the returned routes list should be empty")]
    public void ThenReturnedRoutesEmpty() { /* TODO(impl) */ }

    [Then(@"every returned route should include origin, destination, fare and duration")]
    public void ThenEveryRouteHasSummary() { /* TODO(impl) */ }

    [Then(@"the response should include the company, stops, schedules and fare")]
    public void ThenResponseIncludesFullRouteDetail() { /* TODO(impl) */ }

    [Then(@"the returned routes list should match the previous result set")]
    public void ThenRoutesMatchPreviousResultSet() { /* TODO(impl) */ }
}