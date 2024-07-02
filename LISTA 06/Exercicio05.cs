using System.Text; // Biblioteca para manipulação de texto
using System.Threading.Channels; // Biblioteca para canais de threading
public class Program{
    public static void Main(){
// Exibe uma mensagem no console
Console.WriteLine("Olá! O sistema irá criar um arquivo com caracteres aleatórios \ne irá contar a quantidade de letras a no mesmo.");

// Exibe uma mensagem no console para o usuário iniciar o processo
Console.WriteLine("Digite qualquer tecla e tecle enter para iniciar");

// Lê a entrada do usuário para iniciar o processo
string iniciar = Console.ReadLine();

// Chama a função que conta a quantidade de linhas no arquivo
QuantDeLinhas();
    }

// Procedimento que conta a quantidade de linhas no arquivo
static void QuantDeLinhas() // Define um método estático chamado QuantDeLinhas que não retorna nenhum valor.
{
    StreamReader sr = new StreamReader("C:\\Users\\DELL\\OneDrive\\Documentos\\exemplo.txt");
    // Cria um objeto StreamReader para ler o arquivo de texto localizado no caminho especificado.

    String line = sr.ReadLine();
    // Lê a primeira linha do arquivo e a armazena na variável 'line'.

    int qtd = 0;
    // Inicializa um contador de linhas com valor 0.

    while (line != null)
    // Inicia um loop que continua enquanto a linha atual não for nula (ou seja, enquanto não atingir o final do arquivo).
    {
        Console.WriteLine(line);
        // Imprime a linha atual no console.

        line = sr.ReadLine();
        // Lê a próxima linha do arquivo e a armazena na variável 'line'.

        qtd++;
        // Incrementa o contador de linhas em 1.
    }

    sr.Close();
    // Fecha o StreamReader, liberando os recursos associados.

    Console.WriteLine($"A quantidade de linhas no arquivo é de {qtd}");
    // Exibe a quantidade de linhas no console.
}
}