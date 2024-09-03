using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BotDockerizado.Service
{
    public class GoogleSearch
    {
        public static Queue<string>? Search(IWebDriver driver, string text)
        {
            string _url = "https://www.google.com";

            driver.Navigate().GoToUrl(_url);

            // Find the search box element by its name attribute 'q'
            var searchBox = driver.FindElement(By.Name("q"));

            // Enter the search text
            searchBox.SendKeys(text);

            // Simulate pressing the Enter key
            searchBox.SendKeys(Keys.Enter);

            // Optionally, wait for the search results page to load
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Title.Contains(text));

            // Get all anchor elements with the specific jsname attribute
            IList<IWebElement> resultLinks = driver.FindElements(By.CssSelector("a[jsname='UWckNb']"));

            var queueUrl = new Queue<string>();

            foreach (var link in resultLinks)
            {
                string href = link.GetAttribute("href");
                queueUrl.Enqueue(href);
                Console.WriteLine(href);
            }

            return queueUrl;
        }

    }
}
