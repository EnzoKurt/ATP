using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        // Solicita ao usuário a quantidade de veículos e o valor do aluguel.
        Console.Write("Digite a quantidade de veículos: ");
        int quantidadeVeiculos = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor cobrado por cada aluguel: ");
        decimal valorAluguel = decimal.Parse(Console.ReadLine());

        // Calcula o faturamento mensal e anual.
        decimal faturamentoMensal = (quantidadeVeiculos * valorAluguel) / 3;
        decimal faturamentoAnual = faturamentoMensal * 12;

        // Calcula o valor ganho com multas no mês.
        decimal valorMultasMensal = (faturamentoMensal / 10) * 0.2m;

        // Calcula o valor gasto com manutenção anual.
        decimal valorManutencaoAnual = (quantidadeVeiculos * 0.02m) * 600m;

        // Exibe os resultados na tela.
        Console.WriteLine("Faturamento Mensal: R$ " + faturamentoMensal);
        Console.WriteLine("Faturamento Anual: R$ " + faturamentoAnual);
        Console.WriteLine("Valor ganho com multas no mês: R$ " + valorMultasMensal);
        Console.WriteLine("Valor gasto com manutenção anual: R$ " + valorManutencaoAnual);

        // Define o caminho do arquivo onde os resultados serão salvos.
        string caminhoArquivo = "C:\\Users\\DELL\\OneDrive\\Documentos\\resultado.txt";

        // Usa StreamWriter para escrever os resultados no arquivo texto.
        using (StreamWriter writer = new StreamWriter(caminhoArquivo))
        {
            writer.WriteLine("Faturamento Mensal: R$ " + faturamentoMensal);
            writer.WriteLine("Faturamento Anual: R$ " + faturamentoAnual);
            writer.WriteLine("Valor ganho com multas no mês: R$ " + valorMultasMensal);
            writer.WriteLine("Valor gasto com manutenção anual: R$ " + valorManutencaoAnual);
        }

        // Informa ao usuário que os resultados foram salvos no arquivo.
        Console.WriteLine("Os resultados foram salvos no arquivo: " + caminhoArquivo);
    }
}
