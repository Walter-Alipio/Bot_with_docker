using BotDockerizado.Service;
using SeleniumConfig;

internal class Program
{
    private static void Main(string[] args)
    {
        bool consult = true;

        while (consult)
        {
            Console.Clear();
            Console.WriteLine("What are you looking for?");

            var text = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("...");

            if ( string.IsNullOrEmpty(text) ) continue;

            using var driver = new WebDriverConfig().GetWebDriver();

            var results = GoogleSearch.Search(driver, text);

            Console.Clear();
            Console.WriteLine("##### Results ####");
            if (results != null && results.Count > 0)
            {
                foreach (var url in results)
                {
                    Console.WriteLine(url);
                }
            }
            else 
            {
                Console.WriteLine($"Can't find any result for {text}");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Do you want to made a new consult? S/N");

            var newSearchAnswer = Console.ReadLine();

            while (!newSearchAnswer.ToLower().Equals("s") && !newSearchAnswer.ToLower().Equals("n"))
            {
                Console.WriteLine("Do you want to made a new consult? S/N");

                newSearchAnswer = Console.ReadLine();
            }

            if (newSearchAnswer.ToLower().Equals("n")) break;
        }

    }
}