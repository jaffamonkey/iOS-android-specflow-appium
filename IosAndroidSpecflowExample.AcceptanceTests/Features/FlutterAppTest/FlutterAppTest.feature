Feature: Test Flutter App

@flutter
Scenario: Open app and click a link
	Given I check Page Title displayed
    And I tap increase counter
    And I check value changes to 1
    And I click to open page 2
    And I verify contents of Page 2