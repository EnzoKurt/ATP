using System;

public class Program
{
  public static void Main()
  {
    while (true)
    {
      Console.Clear();
      Console.WriteLine("Lista 06 de ATP");
      Console.WriteLine("Informe:");
      Console.WriteLine("1) Para executar o exercício 1 da lista 06 de ATP.");
      Console.WriteLine("2) Para executar o exercício 2 da lista 06 de ATP.");
      Console.WriteLine("3) Para executar o exercício 3 da lista 06 de ATP.");
      Console.WriteLine("4) Para executar o exercício 4 da lista 06 de ATP.");
      Console.WriteLine("5) Para executar o exercício 5 da lista 06 de ATP.");
      Console.WriteLine("6) Para executar o exercício 6 da lista 06 de ATP.");
      Console.WriteLine("7) Para executar o exercício 7 da lista 06 de ATP.");
      Console.WriteLine("8) Para executar o exercício 8 da lista 06 de ATP.");
      Console.WriteLine("9) Para executar o exercício 9 da lista 06 de ATP.");
      Console.WriteLine("10) Para executar o exercício 10 da lista 06 de ATP.");
      int escolha = int.Parse(Console.ReadLine());

      switch (escolha)
      {
        case 1:
          Exercicio01 exercicio01 = new Exercicio01();
          exercicio01.Main();
          break;
        case 2:
          Exercicio02 exercicio02 = new Exercicio02();
          exercicio02.Main();
          break;
        case 3:
          Exercicio03 exercicio03 = new Exercicio03();
          exercicio03.Main();
          break;
        case 4:
          Exercicio04 exercicio04 = new Exercicio04();
          exercicio04.Main();
          break;
        case 5:
          Exercicio05 exercicio05 = new Exercicio05();
          exercicio05.Main();
          break;
        case 6:
          Exercicio06 exercicio06 = new Exercicio06();
          exercicio06.Main();
          break;
        case 7:
          Exercicio07 exercicio07 = new Exercicio07();
          exercicio07.Main();
          break;
        case 8:
          Exercicio08 exercicio08 = new Exercicio08();
          exercicio08.Main();
          break;
        case 9:
          Exercicio09 exercicio09 = new Exercicio09();
          exercicio09.Main();
          break;
        case 10:
          Exercicio10 exercicio10 = new Exercicio10();
          exercicio10.Main();
          break;        
        default:
          Console.WriteLine("Opção inválida.");
          break;
      }
      Console.ReadKey();
    }
  }
}