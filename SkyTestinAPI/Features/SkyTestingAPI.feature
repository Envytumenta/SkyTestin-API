Feature: SkyTestingAPI
	

@GET
Scenario: List of Articles
	Given I have access to the endpoint
	When I search for the endpoint
	Then result is displayed

	@GET
Scenario: Single Article
	Given I have access to the single endpoint
	When I search for the endpoint
	Then result is displayed




