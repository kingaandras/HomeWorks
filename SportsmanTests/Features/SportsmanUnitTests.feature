Feature: SportmanSpeclflowUnitTests

@mytag
Scenario: Check personal best
	Given a Sportman with name Teofil
	And I add items to personal results for Teofil
	When I compare the results to the personal best
	Then the personal best is the highest
