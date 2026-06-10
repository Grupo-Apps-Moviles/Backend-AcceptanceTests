Feature: Route Search and Detail
  As a passenger
  I want to filter routes by location and inspect their details
  So that I can choose the best route for my trip

  Background:
    Given the WayPass backend is running

  # US41 - Filtrar rutas por ubicación
  Scenario: Filter routes by region, province, district and city
    Given there are active routes registered in the system
    When I request routes filtered by a specific region, province, district and city
    Then the response status should be 200
    And every returned route should match the selected location filters

  Scenario: Filter routes returns empty list when no routes match
    Given there are no routes for the selected location
    When I request routes filtered by that location
    Then the response status should be 200
    And the returned routes list should be empty

  # US42 - Ver resultados de búsqueda
  Scenario: Each route in results contains the summary information
    When I request routes filtered by a specific location
    Then every returned route should include origin, destination, fare and duration

  # US43 - Ver detalles de ruta
  Scenario: Retrieve full details of a route
    Given a route with id "route-001" exists
    When I request the details of route "route-001"
    Then the response status should be 200
    And the response should include the company, stops, schedules and fare

  Scenario: Route detail returns 404 when route does not exist
    Given no route with id "non-existent" exists
    When I request the details of route "non-existent"
    Then the response status should be 404

  # US44 - Volver al listado (validación a nivel de API: el filtro previo sigue siendo válido)
  Scenario: Re-applying previous filters returns the same result set
    Given I previously filtered routes by a specific location
    When I re-send the same filter request
    Then the returned routes list should match the previous result set