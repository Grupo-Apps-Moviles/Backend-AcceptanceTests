using Reqnroll;
using WayPass.AcceptanceTests.Support;

namespace WayPass.AcceptanceTests.Steps;

[Binding]
public class CollectionRouteManagementSteps
{
    private readonly Support.ScenarioContext _ctx;
    public CollectionRouteManagementSteps(Support.ScenarioContext ctx) => _ctx = ctx;

    // Pasos reutilizados desde otros steps:
    //   Given the WayPass backend is running                       (PassengerAuthenticationSteps)
    //   Given I am an authenticated Passenger                      (PassengerAuthenticationSteps)
    //   Given I have a collection named "{name}"                   (FavoriteCollectionsSteps)
    //   Given a route with id "{routeId}" exists                   (RouteSearchSteps)
    //   Then the response status should be {int}                   (PassengerAuthenticationSteps)
    
    [Given(@"I have collections ""(.*)"" and ""(.*)""")]
    public void GivenTwoCollections(string first, string second) { /* TODO(impl) */ }

    [Given(@"route ""(.*)"" is saved in ""(.*)""")]
    public void GivenRouteSavedInCollection(string routeId, string collection) { /* TODO(impl) */ }

    [Given(@"""(.*)"" contains (\d+) routes")]
    public void GivenCollectionContainsRoutes(string collection, int count) { /* TODO(impl) */ }

    [When(@"I add route ""(.*)"" to ""(.*)""")]
    public void WhenAddRouteToCollection(string routeId, string collection) { /* TODO(impl) */ }

    [When(@"I add route ""(.*)"" selecting ""(.*)""")]
    public void WhenAddRouteSelectingCollection(string routeId, string collection) { /* TODO(impl) */ }

    [When(@"I remove route ""(.*)"" from ""(.*)""")]
    public void WhenRemoveRouteFromCollection(string routeId, string collection) { /* TODO(impl) */ }

    [When(@"I request the routes of ""(.*)""")]
    public void WhenRequestRoutesOfCollection(string collection) { /* TODO(impl) */ }

    [Then(@"the route should appear in ""(.*)""")]
    public void ThenRouteAppearsInCollection(string collection) { /* TODO(impl) */ }

    [Then(@"the route should not appear in ""(.*)""")]
    public void ThenRouteDoesNotAppearInCollection(string collection) { /* TODO(impl) */ }

    [Then(@"the route should no longer appear in ""(.*)""")]
    public void ThenRouteNoLongerInCollection(string collection) { /* TODO(impl) */ }

    [Then(@"the returned list should contain (\d+) routes")]
    public void ThenReturnedListContainsRoutes(int count) { /* TODO(impl) */ }
}