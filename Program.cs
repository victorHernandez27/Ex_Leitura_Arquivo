using System;
using System.IO;

namespace Ex_Leitura_Arquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            try
            {
                StreamReader sr= new StreamReader("c:\\5by5\\Test.txt"); //Instancia um objeto
                line = sr.ReadLine();// faz a leitura de uma linha do arquivo

                while(line != null) // laço de repetição para fazer a leitura das lingas
                {
                    Console.WriteLine(line); // Imprime o retorno do arquivo no Console
                    line = sr.ReadLine(); // Faz leitura de uma linha do arquivo
                }                
                sr.Close(); //Comando para fechar o arquivo
                Console.WriteLine("Fim da Leitura do Arquivo");
                Console.ReadLine();
            }
            catch (Exception e) //tratamento de erro na abertura do arquivo 
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executando o Bloco de Comandos - Sem Erros.");
            }
        }
    }
}
