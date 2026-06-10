Feature: Managing Routes inside Collections
  As an authenticated passenger
  I want to add, remove and list routes within a collection
  So that I can keep my favorite routes organized

  Background:
    Given the WayPass backend is running
    And I am an authenticated Passenger
    And I have a collection named "Mis Favoritas"

  # US49 - Agregar ruta a colección
  Scenario: Add a route to a collection
    Given a route with id "route-001" exists
    When I add route "route-001" to "Mis Favoritas"
    Then the response status should be 201
    And the route should appear in "Mis Favoritas"

  # US50 - Seleccionar colección para ruta
  Scenario: Pick a specific collection when saving a route
    Given I have collections "Trabajo" and "Viajes"
    And a route with id "route-002" exists
    When I add route "route-002" selecting "Viajes"
    Then the response status should be 201
    And the route should appear in "Viajes"
    And the route should not appear in "Trabajo"

  # US51 - Quitar ruta de colección
  Scenario: Remove a route from a collection
    Given route "route-001" is saved in "Mis Favoritas"
    When I remove route "route-001" from "Mis Favoritas"
    Then the response status should be 204
    And the route should no longer appear in "Mis Favoritas"

  # US52 - Ver rutas de colección
  Scenario: List the routes stored in a collection
    Given "Mis Favoritas" contains 3 routes
    When I request the routes of "Mis Favoritas"
    Then the response status should be 200
    And the returned list should contain 3 routes