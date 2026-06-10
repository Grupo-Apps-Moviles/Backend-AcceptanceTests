Feature: Passenger Profile Management
  As an authenticated passenger
  I want to view and update my profile
  So that my personal information is always up to date

  Background:
    Given the WayPass backend is running
    And I am an authenticated Passenger

  # US29 - Editar perfil de usuario
  Scenario: Retrieve my profile by user id
    When I request the profile associated to my user id
    Then the response status should be 200
    And the response should include my profile information

  Scenario: Update my profile with valid data
    Given I have a valid profile update payload
    When I send a profile update request
    Then the response status should be 200
    And the profile should reflect the updated information

  Scenario: Update profile fails with invalid data
    Given I have an invalid profile update payload
    When I send a profile update request
    Then the response status should be 400