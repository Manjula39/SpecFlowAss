namespace SpecFlowAss.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext scenarioContext;
        private readonly Calculator calculator;
        private int result;
        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            this.calculator = new Calculator();
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
           calculator.Num1= number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
           calculator.Num2 = number;
        }

        [When("the two numbers are Substracted")]
        public void WhenTheTwoNumbersAreSubstracted()
        {
            result = calculator.Subtract();
        }
        [When("the two numbers are Multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            result = calculator.Multiply();
        }
        [When("the two numbers are Divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            result = calculator.Divide();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            result.Should().Be(result);
        }
    }
}
