using Reqnroll;
using WayPass.AcceptanceTests.Support;

namespace WayPass.AcceptanceTests.Steps;

[Binding]
public class FavoriteCollectionsSteps
{
    private readonly Support.ScenarioContext _ctx;
    public FavoriteCollectionsSteps(Support.ScenarioContext ctx) => _ctx = ctx;

    // Pasos reutilizados desde PassengerAuthenticationSteps:
    //   Given the WayPass backend is running
    //   Given I am an authenticated Passenger
    //   Then the response status should be {int}

    [Given(@"I have a valid collection name")]
    public void GivenValidCollectionName() { /* TODO(impl) */ }

    [Given(@"I have at least one collection created")]
    public void GivenAtLeastOneCollection() { /* TODO(impl) */ }

    [Given(@"I have a collection named ""(.*)""")]
    public void GivenCollectionNamed(string name) { /* TODO(impl) */ }

    [Given(@"I have a collection that I no longer use")]
    public void GivenCollectionToDelete() { /* TODO(impl) */ }

    [When(@"I send a request to create a collection")]
    public void WhenCreateCollection() { /* TODO(impl) */ }

    [When(@"I request my collections")]
    public void WhenRequestMyCollections() { /* TODO(impl) */ }

    [When(@"I update its name to ""(.*)""")]
    public void WhenUpdateCollectionName(string newName) { /* TODO(impl) */ }

    [When(@"I send a delete request for that collection")]
    public void WhenDeleteCollection() { /* TODO(impl) */ }

    [Then(@"the response should include the new collection identifier")]
    public void ThenResponseIncludesCollectionId() { /* TODO(impl) */ }

    [Then(@"every returned collection should belong to me")]
    public void ThenEveryCollectionBelongsToMe() { /* TODO(impl) */ }

    [Then(@"the collection name should now be ""(.*)""")]
    public void ThenCollectionNameIs(string name) { /* TODO(impl) */ }

    [Then(@"the collection should no longer appear in my collections list")]
    public void ThenCollectionNoLongerExists() { /* TODO(impl) */ }
}