using System;

public class Exercicio08 {
    int[,] matriz = new int[4, 4];
  
  public void Rodar () {
    Preenche();
    Imprime();
    SomaAbaixoDiagonalPrincipal();
  }
  
  public void Preenche() {
    Random sort = new Random();
    
    for(int i = 0; i < 4; i++) 
      for(int j = 0; j < 4; j++) 
        matriz[i, j] = sort.Next(0,10);
  }
  
  public void Imprime() {
    for(int i = 0; i < 4; i++) {
      for(int j = 0; j < 4; j++) 
        Console.Write (matriz[i, j] + "   ");
      Console.WriteLine();
    }
  }

  public void SomaAbaixoDiagonalPrincipal(){
    int soma = 0;
    
    for(int i = 0; i < 4; i++) 
      for(int j = 0; j < i; j++) 
        soma += matriz[i, j];
    Console.WriteLine("Soma dos elementos abaixo da diagonal principal: " + soma);
  }
}
