
Feature: ServerStatusFunctionality

A short summary of the feature


Scenario: Checking the server status of the site
	Given the login url of the phptravels site
	Then the valid username and password is entered
	And clicked on login button
	When the server status url of the site is visited
	Then the no error message should appear
