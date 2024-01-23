# Playwright Example Tests

Playwright is a web testing and automation framework that provides reliable end-to-end testing for modern web applications. 

This repository contains examples of using Playwright with NUnit and .NET in various testing scenarios.

## List of Tests
- **First test**: The headless browser first navigates to a URL and loads the web page, then clicks on the "Read the site in your language" drop-down menu and clicks on the selected language to load the site in the desired language. The test then uses regular expressions to check that the page title and URL contain certain substrings to confirm that the web page has successfully loaded in the desired language.
  - This test demonstrates the use of test hooks, creating locators and performing actions on them, auto-wait, page navigation, and assertions.

## Getting Started

1. Clone the repository.
2. Install the dependencies by running `dotnet restore`.
3. Run the tests using the following command in the terminal: `dotnet test`.

## Contributing

Contributions and suggestions are welcome.

## License

This project is released under the MIT Licence. See the LICENSE file for details.