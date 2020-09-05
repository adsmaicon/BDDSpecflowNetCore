Feature: Login
	Login to EA Demo application

@smoke
Scenario: Perform Login of EA Application site

	#steps
	Given I launch the application
	And I click login link
	And I enter the following details
		| Username | Password |
		| admin    | password |
	When I click button
	Then I should see Employee details link