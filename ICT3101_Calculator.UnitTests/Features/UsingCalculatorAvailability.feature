Feature: UsingCalculatorAvailability
	In order to calculate MTBF and Availability
	As someone who struggles with math
	I want to be able to use my calculator to do this

@MTBF
Scenario: Calculating MTBF
	Given I have a calculator
	When I have entered "35" and "15" into the calculator and press MTBF
	Then the availability result should be "50"

@MTBF
Scenario: Calculating MTBF with negative number
	Given I have a calculator
	When I have entered negative "-35" and "15" into the calculator and press MTBF
	Then the availability result should be exception error

@Availability
	Scenario: Calculating Availability
	Given I have a calculator
	When I have entered "35" and "15" into the calculator and press Availability
	Then the availability result should be "0.7"
