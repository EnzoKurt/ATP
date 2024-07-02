using System;              // Importa o namespace System que contém classes básicas do .NET Framework.
using System.IO;           // Importa o namespace System.IO que contém classes para manipulação de arquivos.
using System.Linq;         // Importa o namespace System.Linq para utilizar o método Average().

public class Program
{
    public static void Main()
    {
        string caminhoArquivo = "C:\\Users\\DELL\\OneDrive\\Documentos\\exemplo.txt"; // Define o caminho do arquivo onde os números em ponto flutuante estão armazenados.

        // Verifica se o arquivo existe antes de tentar ler.
        if (File.Exists(caminhoArquivo))
        {
            try
            {
                // Lê todas as linhas do arquivo para um array de strings.
                string[] linhas = File.ReadAllLines(caminhoArquivo);

                // Se não houver linhas no arquivo, informa ao usuário e encerra o programa.
                if (linhas.Length == 0)
                {
                    Console.WriteLine("O arquivo está vazio.");
                    return;
                }

                // Inicializa variáveis para armazenar os valores máximo, mínimo e a soma total.
                double valorMaximo = double.MinValue;  // Inicializa o valor máximo com o menor valor possível para números de ponto flutuante.
                double valorMinimo = double.MaxValue;  // Inicializa o valor mínimo com o maior valor possível para números de ponto flutuante.
                double somaTotal = 0;                  // Inicializa a soma total como zero.

                // Itera sobre cada linha do arquivo.
                foreach (string linha in linhas)
                {
                    // Converte a linha para um número em ponto flutuante.
                    if (double.TryParse(linha, out double numero))
                    {
                        // Atualiza o valor máximo e mínimo, se necessário.
                        if (numero > valorMaximo)
                            valorMaximo = numero;
                        if (numero < valorMinimo)
                            valorMinimo = numero;

                        // Adiciona o número à soma total.
                        somaTotal += numero;
                    }
                    else
                    {
                        // Exibe uma mensagem de erro se não for possível converter a linha para double.
                        Console.WriteLine($"Erro ao converter o valor na linha: {linha}");
                    }
                }

                // Calcula a média dos valores.
                double media = somaTotal / linhas.Length;

                // Exibe os resultados na tela.
                Console.WriteLine($"Valor Máximo: {valorMaximo}");
                Console.WriteLine($"Valor Mínimo: {valorMinimo}");
                Console.WriteLine($"Média: {media}");
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro caso ocorra uma exceção durante a leitura do arquivo.
                Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {ex.Message}");
            }
        }
        else
        {
            // Informa ao usuário que o arquivo não foi encontrado.
            Console.WriteLine("O arquivo não foi encontrado.");
        }
    }
}
