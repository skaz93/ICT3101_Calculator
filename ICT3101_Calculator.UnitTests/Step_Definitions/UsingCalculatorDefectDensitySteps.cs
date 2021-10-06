using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorDefectDensitySteps
    {
        private Calculator _calculator;
        public UsingCalculatorDefectDensitySteps(Calculator calc)
        {
            this._calculator = calc;
        }

        private double _result;

        [When(@"I have entered ""(.*)"" KLOC and ""(.*)"" defects into the calculator and press Defect Density")]
        public void WhenIHaveEnteredKLOCAndDefectsIntoTheCalculatorAndPressDefectDensity(int p0, int p1)
        {
            _result = _calculator.DefectDensity(p0, p1);
        }
        
        [Then(@"the Defect Density result should be ""(.*)""")]
        public void ThenTheDefectDensityResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
