Feature: Registration

A short summary of the feature

@tag1
Scenario: Verify that user can Login with Valid Credentials
	Given I open the AzkaSurvey application
	And I enter data into the fields on the Loginpage 
	When I click on login button
	Then I should navigate to the other page
	And I enter all fields on that page
	When I click on saveandproceed button
	Then I should navigate to the next page
	And I enter all fields on that page
	When I click on Saveandproceed button
	Then I should navigate to the next page
	And I enter all fields on that page
	When I click on Saveandproceed button
	Then I should navigate to the next page
	And I enter all fields on that page
	When I click on Submit button
	Then I should see a success message

