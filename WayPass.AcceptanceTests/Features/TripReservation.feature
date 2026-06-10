Feature: Trip Reservation
  As an authenticated passenger
  I want to reserve a trip on an available route
  So that I can secure my seat before boarding

  Background:
    Given the WayPass backend is running
    And I am an authenticated Passenger

  # US53 - Reservar un viaje
  Scenario: Successfully reserve a trip on an active route
    Given an active route with id "route-001" exists
    When I send a reservation request for route "route-001"
    Then the response status should be 201
    And the reservation status should be "Confirmed"
    And the response should include the reservation identifier

  Scenario: Reservation fails for an inactive route
    Given an inactive route with id "route-099" exists
    When I send a reservation request for route "route-099"
    Then the response status should be 400
    And the response should include an error message about route availability

  Scenario: Reservation fails when the passenger is not authenticated
    Given I am not authenticated
    When I send a reservation request for route "route-001"
    Then the response status should be 401

  Scenario: Retrieve my reservations
    Given I have at least one confirmed reservation
    When I request my reservations
    Then the response status should be 200
    And the returned list should include my confirmed reservation