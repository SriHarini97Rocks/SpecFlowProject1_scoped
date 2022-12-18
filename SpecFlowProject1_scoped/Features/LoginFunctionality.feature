
Feature: LoginFunctionality
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject1_scoped/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@smoke
Scenario: Check the valid login functionality of the site
	Given the login url of the phptravels site
	Then the valid username and password is entered
	And clicked on login button
	Then the page should be redirected to clientarea page