Feature: UsingCalculatorFactorial
In order to conquer Factorial
As a division enthusiast
I want calculate what is the result of factoria of a number

@Factorials
Scenario: Factorial of a integer
	Given I have a calculator
	When I have entered "5" into the calculator and press factorial
	Then the factorial result should be "120"

@Factorials
Scenario: Factorial of zero
	Given I have a calculator
	When I have entered "0" into the calculator and press factorial
	Then the factorial result should be "1"