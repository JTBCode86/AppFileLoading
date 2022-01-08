using System;
using System.IO;
using System.Globalization;

namespace AppFileLoading.Entities
{
    class Arquivo
    {
        private string SourceFilePath;
        private string SourceFolderPath;
        private string TargetFolderPath;
        private string TargetFilePath;

        public Arquivo(string sourceFilePath)
        {
            SourceFilePath = sourceFilePath;
            SourceFolderPath = Path.GetDirectoryName(sourceFilePath);
            TargetFolderPath = SourceFolderPath + @"\out";
            TargetFilePath = TargetFolderPath + @"\summary.csv";
        }

        private void CriarDiretorio()
        {
            if (!Directory.Exists(TargetFolderPath))
            {
                Directory.CreateDirectory(TargetFolderPath);
            }
        }

        public void EscreverArquivo() 
        {
            try
            {
                string[] lines = File.ReadAllLines(SourceFilePath);

                CriarDiretorio();

                using (StreamWriter sw = File.AppendText(TargetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string Nome = fields[0];
                        double Preco = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int Quantidade = int.Parse(fields[2]);

                        Produto prod = new Produto(Nome, Preco, Quantidade);
                        sw.WriteLine(prod.Nome + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
