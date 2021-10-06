using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilitySteps
    {
        private Calculator _calculator;
        public UsingCalculatorBasicReliabilitySteps(Calculator calc)
        {
            this._calculator = calc;
        }

        private double _result;

        [When(@"I have entered ""(.*)"" and ""(.*)"" and ""(.*)"" into the calculator and press CurrentFailureIntensity")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressCurrentFailureIntensity(int p0, int p1, int p2)
        {
            _result = _calculator.CFI(p0, p1, p2);
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" and ""(.*)"" and time ""(.*)"" into the calculator and press AverageFailureIntensity")]
        public void WhenIHaveEnteredAndAndAndTimeIntoTheCalculatorAndPressAverageFailureIntensity(int p0, int p1, int p2, int p3)
        {
            _result = _calculator.AvgFailure(p0, p1, p2, p3);
        }

        [Then(@"the CFI result should be ""(.*)""")]
        public void ThenTheCFIResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the Avg Fail Number result should be ""(.*)""")]
        public void ThenTheAvgFailNumberResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

    }
}
