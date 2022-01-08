using System;
using AppFileLoading.Entities;

namespace AppFileLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diretorio origem: ");
            string sourceFilePath = Console.ReadLine();
            
            Arquivo arquivo = new Arquivo(sourceFilePath);
            arquivo.EscreverArquivo();

            Console.WriteLine("Arquivo gerado com sucesso!");
            Console.ReadLine(); 
        }
    }
}
