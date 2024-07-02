using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        // Caminho do arquivo de texto
        string caminhoArquivo = "C:\\Users\\DELL\\OneDrive\\Documentos\\exemplo.txt";

        try
        {
            // Abre o arquivo para leitura
            using (StreamReader sr = new StreamReader(caminhoArquivo))
            {
                string conteudo = sr.ReadToEnd(); // Lê todo o conteúdo do arquivo

                int contadorA = 0;

                // Percorre cada caractere do conteúdo
                foreach (char c in conteudo)
                {
                    if (c == 'a' || c == 'A') // Verifica se o caractere é 'a' (maiúsculo ou minúsculo)
                    {
                        contadorA++;
                    }
                }

                // Imprime a quantidade de caracteres 'a' encontrados
                Console.WriteLine($"Quantidade de caracteres 'a' encontrados: {contadorA}");
            }
        }
        catch (Exception e)
        {
            // Em caso de erro, imprime a mensagem de exceção
            Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {e.Message}");
        }
    }
}
