using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace SeleniumConfig
{
    public class WebDriverConfig : IDisposable
    {
        private IWebDriver _driver;

        public WebDriverConfig()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);

            _driver = new ChromeDriver(OptionsChrome());

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public IWebDriver GetWebDriver()
        {
            return _driver;
        }

        private ChromeOptions OptionsChrome()
        {
            ChromeOptions options = new ChromeOptions();
            //Configurações adicionais para se comportar como um navegador padrão
            options.AddArgument("--disable-blink-features=AutomationControlled");
            options.AddExcludedArgument("enable-automation");
            options.AddArgument("--start-maximized"); // Iniciar maximizado
            options.AddArgument("--disable-extensions"); // Desativar extensões
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--headless"); // Run Chrome in headless mode
            options.AddArgument("--no-sandbox"); // Required for Docker
            options.AddArgument("--disable-dev-shm-usage"); // Overcome limited resource problems
            options.AddArgument("--disable-gpu"); // Applicable to Windows OS only
            options.AddArgument("--disable-software-rasterizer");
            options.AddArgument("--remote-debugging-port=9222"); // Required to run Chrome in Docker
            options.AddUserProfilePreference("download.prompt_for_download", false);
            options.AddUserProfilePreference("plugins.always_open_pdf_externally", true);
            options.AddUserProfilePreference("profile.default_content_setting_values.notifications", 1); // Permitir notificações
            options.AddUserProfilePreference("credentials_enable_service", false);
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            options.AddUserProfilePreference("profile.default_content_settings.popups", 0);
            options.AddUserProfilePreference("download.directory_upgrade", true);
            options.AddUserProfilePreference("safebrowsing.enabled", true);


            return options;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
