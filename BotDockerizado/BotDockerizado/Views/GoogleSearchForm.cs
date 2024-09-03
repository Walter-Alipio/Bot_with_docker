using BotDockerizado.Service;
using OpenQA.Selenium;
using SeleniumConfig;

namespace BotDockerizado.Views
{
    public partial class GoogleSearchForm : Form
    {
        public GoogleSearchForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var searchText = SearchBox.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                using IWebDriver driver = new WebDriverConfig().GetWebDriver();

                var results = GoogleSearch.Search(driver, searchText);

                FullFillDataGrid(results);
            }
        }

        private void FullFillDataGrid(Queue<string>? results)
        {
            dataGridViewResults.Rows.Clear();
            if (results != null)
            {
                foreach (var url in results)
                {
                    dataGridViewResults.Rows.Add(url);
                }
            }
            else
            {
                dataGridViewResults.Rows.Add("None result has been find!");
            }
        }
    }
}
