using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorKSSISteps
    {
        private Calculator _calculator;
        public UsingCalculatorKSSISteps(Calculator calc)
        {
            this._calculator = calc;
        }

        private double _result;

        [When(@"I have entered ""(.*)"" for old KSSI and ""(.*)"" for KCSI into the calculator with ""(.*)"" % changed code and press KSSI")]
        public void WhenIHaveEnteredForOldKSSIAndForKCSIIntoTheCalculatorWithChangedCodeAndPressKSSI(int p0, int p1, int p2)
        {
            _result = _calculator.KSSI(p0, p1, p2);
        }
        
        [Then(@"the new KSSI result should be ""(.*)""")]
        public void ThenTheNewKSSIResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
