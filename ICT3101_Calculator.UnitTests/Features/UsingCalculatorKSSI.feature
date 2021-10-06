Feature: UsingCalculatorKSSI
	As a engineer
	I want to be able to perform calculation of the second SSI in the 2nd release of a system using a program
	So that i can reduce the amount of work i have

@CalculateNewKSSI
Scenario: Calculating new KSSI
	Given I have a calculator
	When I have entered "50" for old KSSI and "20" for KCSI into the calculator with "20" % changed code and press KSSI
	Then the new KSSI result should be "66"