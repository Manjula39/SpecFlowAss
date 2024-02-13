Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowAss/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Substract two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are Substracted
	Then the result should be 20
	@mytag
Scenario: Multiply two numbers
	Given the first number is 500
	And the second number is 70
	When the two numbers are Multiplied
	Then the result should be 35000
	@mytag
Scenario: Division two numbers
	Given the first number is 350
	And the second number is 7
	When the two numbers are Divided
	Then the result should be 50