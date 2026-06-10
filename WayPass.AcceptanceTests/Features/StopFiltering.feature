Feature: Stop Filtering by Location
  As a passenger
  I want to filter stops by region, province, district and locality
  So that I can find the closest pick-up points

  Background:
    Given the WayPass backend is running

  # US24 - Filtrar paraderos por ubicación
  Scenario: Filter stops by full geographic hierarchy
    Given there are stops registered in the system
    When I request stops filtered by region, province, district and locality
    Then the response status should be 200
    And every returned stop should match the selected location filters

  Scenario: Filter stops with empty results
    Given there are no stops for the selected location
    When I request stops filtered by that location
    Then the response status should be 200
    And the returned stops list should be empty