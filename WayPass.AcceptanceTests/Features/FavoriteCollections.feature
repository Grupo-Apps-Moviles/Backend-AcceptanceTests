Feature: Favorite Collections
  As an authenticated passenger
  I want to create, list, rename and delete my favorite collections
  So that I can organize the routes that interest me

  Background:
    Given the WayPass backend is running
    And I am an authenticated Passenger

  # US45 - Crear colección
  Scenario: Create a new favorite collection
    Given I have a valid collection name
    When I send a request to create a collection
    Then the response status should be 201
    And the response should include the new collection identifier

  # US46 - Ver mis colecciones
  Scenario: List all my collections
    Given I have at least one collection created
    When I request my collections
    Then the response status should be 200
    And every returned collection should belong to me

  # US47 - Editar nombre de colección
  Scenario: Rename an existing collection
    Given I have a collection named "Trabajo"
    When I update its name to "Oficina"
    Then the response status should be 200
    And the collection name should now be "Oficina"

  # US48 - Eliminar colección
  Scenario: Delete a collection
    Given I have a collection that I no longer use
    When I send a delete request for that collection
    Then the response status should be 204
    And the collection should no longer appear in my collections list