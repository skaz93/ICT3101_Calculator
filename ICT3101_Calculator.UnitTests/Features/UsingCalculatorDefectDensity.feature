Feature: UsingCalculatorDefectDensity
	As a engineer
	I want to be able to calculate the defect density of a system using a program
	So that i can reduce the risk of human errors in calculation

@CalculateDefectDensity
Scenario: Calculating Defect Density
	Given I have a calculator
	When I have entered "100" KLOC and "50" defects into the calculator and press Defect Density
	Then the Defect Density result should be "2"