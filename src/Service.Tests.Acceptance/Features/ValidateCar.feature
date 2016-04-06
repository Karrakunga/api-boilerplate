Feature: ValidateCar
	As a customer
	When a car endpoint is called 
	I would like to receive car data

Scenario: Given a car endpoint when that endpoint is called a list of cars is returned
	Given the following car data
	| Car Type | Registration | Year Bought |
	| Ford     | DN65 VHL     | 2015        |
	When the endpoint is called
	Then the following data should be returned
	And the api will return a response of Ok
