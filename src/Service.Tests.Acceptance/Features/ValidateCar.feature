Feature: ValidateCar
	As a customer
	When a car endpoint is called 
	I would like to receive car data

Background:
	Given the following car data
	| Car Type | Registration | Year Bought |
	| Ford     | DN65 VHL     | 2015        |

Scenario: Given a car data list containing cars
	Then our data list should contain 1 car