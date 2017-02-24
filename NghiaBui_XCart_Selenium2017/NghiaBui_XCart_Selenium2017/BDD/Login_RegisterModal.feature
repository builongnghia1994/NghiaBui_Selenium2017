Feature: Login_RegisterModal
	The Login_Register Modal displays when clicking on the Sign In/ Sign Up button

@mytag
@Browser:Chrome
Scenario: Verify Login_Register Modal displays
	Given I have navigated to Homepage
	When I click on Sign In/ Sign Up button
	Then Login_RegisterModal displays
