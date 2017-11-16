Feature: Sportman unit tests

@mytag
Scenario: the personal best is the highest of a sportman
	Given a sportman with name Teofil
	When I add result 5 to sportman Teofil
	And I add result 6 to sportman Teofil
	Then the personal best is 6 for Teofil

Scenario: the world record is the highest of all results
	Given a sportman with name Teofil
	And a sportman with name Theodore
	When I add result 5 to sportman Teofil
	And I add result 6 to sportman Teofil
	And I add result 10 to sportman Theodore
	Then the world record is 10

Scenario: the world recorder is the sportname owning highest result
	Given a sportman with name Teofil
	And a sportman with name Theodore
	When I add result 5 to sportman Teofil
	And I add result 10 to sportman Theodore
	Then the world record is owned by Theodore

Scenario: check category amateur lower limit
	Given a sportman with name Teofil
	When World Record is 10
	And Personal Best is 0
	Then the category is amateur

Scenario: check category amateur upper limit
	Given a sportman with name Teofil
	When World Record is 10
	And Personal Best is 2
	Then the category is amateur

Scenario: check category professional lower limit
	Given a sportman with name Teofil
	When World Record is 10
	And Personal Best is 3
	Then the category is professional

Scenario: check category professional upper limit
	Given a sportman with name Teofil
	When World Record is 10
	And Personal Best is 7
	Then the category is professional

Scenario: check category classic lower limit
	Given a sportman with name Teofil
	When World Record is 10
	And Personal Best is 8
	Then the category is classic

Scenario: check category classic upper limit
	Given a sportman with name Teofil
	When World Record is 10
	And Personal Best is 10
	Then the category is classic