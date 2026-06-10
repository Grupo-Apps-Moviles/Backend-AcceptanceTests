Feature: Passenger Authentication
  As a passenger of WayPass
  I want to register, sign in and sign out of the platform
  So that I can securely access my account and personal information

  Background:
    Given the WayPass backend is running

  # US26 - Registro de usuario
  Scenario: Successful passenger registration
    Given I am a new visitor with valid registration data
    When I submit a sign-up request as a Passenger
    Then the response status should be 201
    And the response should include the new user identifier

  Scenario: Registration fails with invalid data
    Given I am a new visitor with invalid registration data
    When I submit a sign-up request as a Passenger
    Then the response status should be 400

  # US27 - Iniciar sesión
  Scenario: Successful sign in returns a JWT token
    Given a Passenger account already exists
    When I submit a sign-in request with valid credentials
    Then the response status should be 200
    And the response should include a JWT token

  Scenario: Sign in fails with wrong credentials
    Given a Passenger account already exists
    When I submit a sign-in request with wrong credentials
    Then the response status should be 401

  # US28 - Cerrar sesión
  Scenario: Authenticated passenger can sign out
    Given I am an authenticated Passenger
    When I sign out from the platform
    Then my session token should no longer be valid