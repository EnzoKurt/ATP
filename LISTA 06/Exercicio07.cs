using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        // Solicita ao usuário a quantidade de letras que deseja inserir.
        Console.Write("Digite a quantidade de letras (N): ");
        int n = int.Parse(Console.ReadLine());

        // Define o caminho do arquivo onde as letras serão salvas.
        string caminhoArquivo = "C:\\Users\\DELL\\OneDrive\\Documentos\\letras.txt";

        // Usa StreamWriter para escrever as letras no arquivo texto.
        using (StreamWriter writer = new StreamWriter(caminhoArquivo))
        {
            for (int i = 0; i < n; i++)
            {
                // Solicita ao usuário uma letra e a escreve no arquivo.
                Console.Write($"Digite a letra {i + 1}: ");
                char letra = char.Parse(Console.ReadLine());
                writer.Write(letra);
            }
        }

        // Variáveis para contar as vogais.
        int countA = 0, countE = 0, countI = 0, countO = 0, countU = 0;

        // Usa StreamReader para ler as letras do arquivo texto.
        using (StreamReader reader = new StreamReader(caminhoArquivo))
        {
            int character;
            while ((character = reader.Read()) != -1)
            {
                // Converte o caractere lido para char.
                char letra = (char)character;
                // Verifica se a letra lida é uma vogal e incrementa o contador correspondente.
                switch (char.ToLower(letra))
                {
                    case 'a':
                        countA++;
                        break;
                    case 'e':
                        countE++;
                        break;
                    case 'i':
                        countI++;
                        break;
                    case 'o':
                        countO++;
                        break;
                    case 'u':
                        countU++;
                        break;
                }
            }
        }

        // Exibe a quantidade de cada vogal.
        Console.WriteLine("Quantidades de vogais:");
        Console.WriteLine($"A: {countA}");
        Console.WriteLine($"E: {countE}");
        Console.WriteLine($"I: {countI}");
        Console.WriteLine($"O: {countO}");
        Console.WriteLine($"U: {countU}");
    }
}
