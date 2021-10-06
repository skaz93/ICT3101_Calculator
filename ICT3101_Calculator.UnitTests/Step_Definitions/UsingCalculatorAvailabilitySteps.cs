using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorAvailabilitySteps
    {
        private Calculator _calculator;
        public UsingCalculatorAvailabilitySteps(Calculator calc)
        {
            this._calculator = calc;
        }

        private double _result;

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(int p0, int p1)
        {
            _result = _calculator.Mtbf(p0, p1);
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(int p0, int p1)
        {
            _result = _calculator.Availability(p0, p1);
        }

        [When(@"I have entered negative ""(.*)"" and ""(.*)"" into the calculator and press MTBF")]
        public void WhenIHaveEnteredNegativeAndIntoTheCalculatorAndPressMTBF(int p0, int p1)
        {
            try
            {
                _result = _calculator.Mtbf(p0, p1);
            }
            catch (Exception e)
            {
                ScenarioContext.Current.Add("Invalid Argument", e);
            }
            
        }


        [Then(@"the availability result should be exception error")]
        public void ThenTheAvailabilityResultShouldBeExceptionError()
        {
            var exception = ScenarioContext.Current["Invalid Argument"];
            Assert.That(exception, Is.Not.Null);
        }
        
        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
