using System;              // Importa o namespace System que contém classes básicas do .NET Framework.
using System.IO;           // Importa o namespace System.IO que contém classes para manipulação de arquivos.

public class Program
{
    public static void Main()
    {
        // Define o caminho do arquivo onde os dados dos alunos serão armazenados.
        string caminhoArquivo = "C:\\Users\\DELL\\OneDrive\\Documentos\\alunos.txt";

        // Loop principal do programa.
        while (true)
        {
            // Exibe o menu de opções para o usuário.
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Inserir dados de alunos");
            Console.WriteLine("2. Ler dados de alunos");
            Console.WriteLine("3. Sair");

            // Lê a opção escolhida pelo usuário.
            string opcao = Console.ReadLine();

            // Verifica a opção escolhida e chama o método correspondente.
            if (opcao == "1")
            {
                InserirDadosAlunos(caminhoArquivo);  // Chama o método para inserir dados de alunos.
            }
            else if (opcao == "2")
            {
                LerDadosAlunos(caminhoArquivo);  // Chama o método para ler dados de alunos.
            }
            else if (opcao == "3")
            {
                break;  // Sai do loop e termina o programa.
            }
            else
            {
                // Informa ao usuário que a opção escolhida é inválida.
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }

    static void InserirDadosAlunos(string caminhoArquivo)
    {
        // Abre o arquivo no modo de acréscimo (append) para adicionar novos dados.
        using (StreamWriter writer = new StreamWriter(caminhoArquivo, true)) // O 'true' indica que o arquivo será aberto no modo de acréscimo.
        {
            while (true)
            {
                // Solicita ao usuário a matrícula do aluno.
                Console.Write("Digite a matrícula do aluno: ");
                string matricula = Console.ReadLine();

                // Solicita ao usuário o telefone do aluno.
                Console.Write("Digite o telefone do aluno: ");
                string telefone = Console.ReadLine();

                // Escreve os dados do aluno no arquivo texto.
                writer.WriteLine($"{matricula},{telefone}");

                // Pergunta ao usuário se deseja inserir mais alunos.
                Console.Write("Deseja inserir mais alunos? (s/n): ");
                string resposta = Console.ReadLine().ToLower();
                if (resposta != "s")
                {
                    break;  // Sai do loop se o usuário não desejar inserir mais alunos.
                }
            }
        }
    }

    static void LerDadosAlunos(string caminhoArquivo)
    {
        // Verifica se o arquivo existe antes de tentar lê-lo.
        if (File.Exists(caminhoArquivo))
        {
            // Abre o arquivo para leitura.
            using (StreamReader reader = new StreamReader(caminhoArquivo))
            {
                string linha;
                // Lê cada linha do arquivo até o final.
                while ((linha = reader.ReadLine()) != null)
                {
                    // Divide a linha lida em matrícula e telefone.
                    string[] dados = linha.Split(',');
                    string matricula = dados[0];
                    string telefone = dados[1];

                    // Exibe os dados do aluno no console.
                    Console.WriteLine($"Matrícula: {matricula}, Telefone: {telefone}");
                }
            }
        }
        else
        {
            // Informa ao usuário que o arquivo não foi encontrado.
            Console.WriteLine("Nenhum dado de aluno encontrado.");
        }
    }
}
