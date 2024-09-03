using System.Globalization;
using System.Text;

namespace BotDockerizado.Tools.ImportarExportar
{
    internal class Importar
    {
        public void ImportTxt(DataGridView dataGridView)
        {
            string rota = "";
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            OpenFileDialog openfile1 = new OpenFileDialog();
            if (openfile1.ShowDialog() == DialogResult.OK)
            {
                if (openfile1.FileName.Equals("") == false)
                {
                    rota = openfile1.FileName;
                    string Arquivo = openfile1.FileName;
                }
            }
            else
            {
                return;
            }

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(rota, Encoding.UTF8);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                try
                {
                    string[] dados = line.Split(';', ',');

                    if (dados.Count() == 1)
                    {
                        dataGridView.Rows.Add(dados[0].Replace("\r\n", "").Replace("\t", ""));
                    }
                    if (dados.Count() == 2)
                    {
                        dataGridView.Rows.Add(dados[0].Replace("\r\n", "").Replace("\t", ""), dados[1].Replace("\r\n", "").Replace("\t", ""));
                    }
                    if (dados.Count() == 3)
                    {
                        dataGridView.Rows.Add(dados[0].Replace("\r\n", "").Replace("\t", ""), dados[1].Replace("\r\n", "").Replace("\t", ""), dados[2].Replace("\r\n", "").Replace("\t", ""));
                    }
                    if (dados.Count() == 4)
                    {
                        dataGridView.Rows.Add(dados[0].Replace("\r\n", "").Replace("\t", ""), dados[1].Replace("\r\n", "").Replace("\t", ""), dados[2].Replace("\r\n", "").Replace("\t", ""), dados[3].Replace("\r\n", "").Replace("\t", ""));
                    }
                    if (dados.Count() == 5)
                    {
                        dataGridView.Rows.Add(dados[0].Replace("\r\n", "").Replace("\t", ""), dados[1].Replace("\r\n", "").Replace("\t", ""), dados[2].Replace("\r\n", "").Replace("\t", ""), dados[3].Replace("\r\n", "").Replace("\t", ""), dados[4].Replace("\r\n", "").Replace("\t", ""));
                    }
                    if (dados.Count() == 6)
                    {
                        dataGridView.Rows.Add(dados[0].Replace("\r\n", "").Replace("\t", ""), dados[1].Replace("\r\n", "").Replace("\t", ""), dados[2].Replace("\r\n", "").Replace("\t", ""), dados[3].Replace("\r\n", "").Replace("\t", ""), dados[4].Replace("\r\n", "").Replace("\t", ""), dados[5].Replace("\r\n", "").Replace("\t", ""));
                    }
                    if (dados.Count() == 7)
                    {
                        dataGridView.Rows.Add(dados[0].Replace("\r\n", "").Replace("\t", ""), dados[1].Replace("\r\n", "").Replace("\t", ""), dados[2].Replace("\r\n", "").Replace("\t", ""), dados[3].Replace("\r\n", "").Replace("\t", ""), dados[4].Replace("\r\n", "").Replace("\t", ""), dados[5].Replace("\r\n", "").Replace("\t", ""), dados[6].Replace("\r\n", "").Replace("\t", ""));
                    }
                    if (dados.Count() == 8)
                    {
                        dataGridView.Rows.Add(dados[0].Replace("\r\n", "").Replace("\t", ""), dados[1].Replace("\r\n", "").Replace("\t", ""), dados[2].Replace("\r\n", "").Replace("\t", ""), dados[3].Replace("\r\n", "").Replace("\t", ""), dados[4].Replace("\r\n", "").Replace("\t", ""), dados[5].Replace("\r\n", "").Replace("\t", ""), dados[6].Replace("\r\n", "").Replace("\t", ""), dados[7].Replace("\r\n", "").Replace("\t", ""));
                    }
                    if (dados.Count() == 9)
                    {
                        dataGridView.Rows.Add(dados[0].Replace("\r\n", "").Replace("\t", ""), dados[1].Replace("\r\n", "").Replace("\t", ""), dados[2].Replace("\r\n", "").Replace("\t", ""), dados[3].Replace("\r\n", "").Replace("\t", ""), dados[4].Replace("\r\n", "").Replace("\t", ""), dados[5].Replace("\r\n", "").Replace("\t", ""), dados[6].Replace("\r\n", "").Replace("\t", ""), dados[7].Replace("\r\n", "").Replace("\t", ""), dados[8].Replace("\r\n", "").Replace("\t", ""));
                    }
                    if (dados.Count() == 10)
                    {
                        dataGridView.Rows.Add(dados[0].Replace("\r\n", "").Replace("\t", ""), dados[1].Replace("\r\n", "").Replace("\t", ""), dados[2].Replace("\r\n", "").Replace("\t", ""), dados[3].Replace("\r\n", "").Replace("\t", ""), dados[4].Replace("\r\n", "").Replace("\t", ""), dados[5].Replace("\r\n", "").Replace("\t", ""), dados[6].Replace("\r\n", "").Replace("\t", ""), dados[7].Replace("\r\n", "").Replace("\t", ""), dados[8].Replace("\r\n", "").Replace("\t", ""), dados[9].Replace("\r\n", "").Replace("\t", ""));
                    }
                    if (dados.Count() == 11)
                    {
                        dataGridView.Rows.Add(dados[0].Replace("\r\n", "").Replace("\t", ""), dados[1].Replace("\r\n", "").Replace("\t", ""), dados[2].Replace("\r\n", "").Replace("\t", ""), dados[3].Replace("\r\n", "").Replace("\t", ""), dados[4].Replace("\r\n", "").Replace("\t", ""), dados[5].Replace("\r\n", "").Replace("\t", ""), dados[6].Replace("\r\n", "").Replace("\t", ""), dados[7].Replace("\r\n", "").Replace("\t", ""), dados[8].Replace("\r\n", "").Replace("\t", ""), dados[9].Replace("\r\n", "").Replace("\t", ""), dados[10].Replace("\r\n", "").Replace("\t", ""));
                    }
                    if (dados.Count() == 12)
                    {
                        dataGridView.Rows.Add(dados[0].Replace("\r\n", "").Replace("\t", ""), dados[1].Replace("\r\n", "").Replace("\t", ""), dados[2].Replace("\r\n", "").Replace("\t", ""), dados[3].Replace("\r\n", "").Replace("\t", ""), dados[4].Replace("\r\n", "").Replace("\t", ""), dados[5].Replace("\r\n", "").Replace("\t", ""), dados[6].Replace("\r\n", "").Replace("\t", ""), dados[7].Replace("\r\n", "").Replace("\t", ""), dados[8].Replace("\r\n", "").Replace("\t", ""), dados[9].Replace("\r\n", "").Replace("\t", ""), dados[10].Replace("\r\n", "").Replace("\t", ""), dados[11].Replace("\r\n", "").Replace("\t", ""));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return;
        }
    }
}
