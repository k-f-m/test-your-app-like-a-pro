# Playwright Example Tests

Playwright is a web testing and automation framework that provides reliable end-to-end testing for modern web applications. 

This repository contains examples of using Playwright with NUnit and .NET in various testing scenarios.

## List of Tests
- **First test**: The headless browser first navigates to a URL and loads the web page, then clicks on the "Read the site in your language" drop-down menu and clicks on the selected language to load the site in the desired language. The test then uses regular expressions to check that the page title and URL contain certain substrings to confirm that the web page has successfully loaded in the desired language.
  - This test demonstrates the use of test hooks, creating locators and performing actions on them, auto-wait, page navigation, and assertions.
- **Screenshot test**: This test launches a Chromium browser, creates a new browser context and a page within that context, navigates to the specified URL, and takes a screenshot of the page. The screenshot is then saved to the specified file path.

## Getting Started

1. Clone the repository.
2. Make sure you have the [.NET CLI](https://learn.microsoft.com/en-us/dotnet/core/tools/) on your machine.
3. Install the dependencies by running `dotnet restore`.
4. Build the project by running `dotnet build` so that `playwright.ps1` is available in the `bin` directory.
5. Install the required browsers by running `pwsh bin/Debug/net8.0/playwright.ps1`
     - If `pwsh` is not available, [install PowerShell](https://docs.microsoft.com/powershell/scripting/install/installing-powershell).
6. Run the tests using the following command in the terminal: `dotnet test`.

## Contributing

Contributions and suggestions are welcome.

## License

This project is released under the MIT Licence. See the LICENSE file for details.
