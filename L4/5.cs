using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite dois números inteiros:");//coleta dos números do usuário
    int a=int.Parse(Console.ReadLine());
    int b=int.Parse(Console.ReadLine());
    Console.WriteLine("O Máximo divisor comum (MDC) desses dois números é: {0}", Mdc(a,b));//já imprime a mensagem com o resultado da função acionada para os dois números
  }
  static int Mdc(int x, int y){
    int s=0;//terceira variável para trocar os valores na operação
    if(x>y){//o dividendo deverá ser maior que o divisor
      while(x%y>0){//o programa roda enquanto o resto da divisão entre x e y for maior que 0
        s=x%y;//calcula o resto da divisão
        x=y;//x toma o valor de y
        y=s;//y toma o resto como seu valor
      }
      return y;//retorna o último resto diferente de 0
    }
    else{
      while(y%x>0){//o programa roda enquanto o resto da divisão entre y e x for maior que 0
        s=y%x;
        y=x;
        x=s;
      }
      return x;//retorna o último resto diferente de 0
    }
  }
}
