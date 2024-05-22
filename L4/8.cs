using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite um valor inteiro positivo:");
    int n=int.Parse(Console.ReadLine());//coleta número do usuário
    Console.WriteLine("valor de s é:{0}",Formula(n));//imprime resultado com o valor retornado pela função acionada
  }
  static double Formula(int x){
    double s=0;
    for(int i=1;i<x;i++){
     s+=((i*i)+1)/i+3;//aplica-se a formula para calcular s 
     Console.WriteLine(s);
    }
    return s;//retorna valor encontrado em s
  }
}
