Feature: Registration


As a user to benefit from this platform,
i have to register on the plafrom.
@tag1
Scenario Outline: Validate Registration 
	Given I navigate "https://angularjs.realworld.io/#/"
	And I click on the SignUp
	And I enter Username text "<Username>"
	And I enter Email text "<Email>"
	And I enter Password test "<Password>"
	When I click on SignUp button 
	Then I should be able to register successfully 

	Examples: 
	| Username | Email              | Password |
	| Ganiyat001  | olade1@yahoo.com    | Funke123 |
	| QUDUS    | qudus@yahoo.com    | Password |
	| BOLU     | olatunde@yahoo.com | Password |
