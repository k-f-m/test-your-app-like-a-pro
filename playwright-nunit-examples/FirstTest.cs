using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System.Text.RegularExpressions;

namespace playwright_nunit_examples
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class FirstTest : PageTest
    {
        [Test]
        public async Task ChangeLanguageThenCheckTitleAndURL()
        {
            // Create locators.
            var dropDownList = Page.GetByRole(AriaRole.Button, new() { Name = "Read the site in your language" });
            var language = Page.GetByRole(AriaRole.Link, new() { Name = "English", Exact = true });

            // Open the language list.
            await dropDownList.ClickAsync();

            // Choose the language.
            await language.ClickAsync();

            // Expect the title to contain 'placeholder' as a substring.
            await Expect(Page).ToHaveTitleAsync(new Regex("placeholder"));

            // Expect the URL to contain 'placeholder'.
            await Expect(Page).ToHaveURLAsync(new Regex(".*placeholder"));
        }

        [SetUp]
        public async Task SetUp()
        {
            // Navigate to the desired URL.
            await Page.GotoAsync("Enter web page URL here");
        }
    }
}
