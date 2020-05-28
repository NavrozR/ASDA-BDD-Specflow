Feature: AsdaDropdown
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@AsdaDropdown
Scenario: Asda Dropdown test
	Given I have navigated to Asda home page
	And I have clicked on Groceries main page 
	And I have clicked on Groceries on Asda Groceries page
	When I select Apples from the dropdown menu of Fruit
	Then I see page showing various Apples on sale
