using Microsoft.Playwright;

namespace playwright_nunit_examples
{
    public class ScreenshotTest
    {
        [Test]
        public async Task ScreenshotPage()
        {
            // Launch a new instance of Playwright.
            using var playwright = await Playwright.CreateAsync();

            // Launch a new instance of Chromium browser.
            await using var browser = await playwright.Chromium.LaunchAsync();

            // Create a new browser context.
            var context = await browser.NewContextAsync();

            // Create a new page in the browser context.
            var page = await context.NewPageAsync();

            // Navigate to the specified URL.
            await page.GotoAsync("https://playwright.dev/");

            // Take a screenshot of the page and save it to the specified file path.
            await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });
        }
    }
}
