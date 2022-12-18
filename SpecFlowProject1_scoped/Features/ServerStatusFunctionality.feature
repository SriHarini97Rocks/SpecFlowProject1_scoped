
Feature: ServerStatusFunctionality

A short summary of the feature

@smoke
Scenario: Checking the server status of the site
	Given the login url of the ecommnerce site
	Then the valid username and password is entered
	And clicked on login button
	When the orders tab of the site is clicked
	Then the total order should be 7
