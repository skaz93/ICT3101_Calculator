Feature: UsingCalculatorBasicReliability
	In order to calculate the Basic Musa model's failures/intensities
	As a Software Quality Metric enthusiast
	I want to use my calculator to do this

@CurrentFailureIntensity
Scenario: Calculating Current Failure Intensity
	Given I have a calculator
	When I have entered "100" and "50" and "10" into the calculator and press CurrentFailureIntensity
	Then the CFI result should be "5"

@AverageFailureAtTimeT
Scenario: Calculating Average Number of Expected Failure
	Given I have a calculator
	When I have entered "100" and "50" and "10" and time "10" into the calculator and press AverageFailureIntensity
	Then the Avg Fail Number result should be "63"

