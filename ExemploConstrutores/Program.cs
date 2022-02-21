using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
  class Program
  {

    ////Aula de Delegate Classe calculadora 
     public delegate void Operacao(int x, int y);
      //Trabalhando com contrutores (Pessoa)
     static void Main(string[] args)
     {
         //Aula de Contrutor Padrão
         //  Pessoa p1 = new Pessoa("Geovane","Jorge");
         //  p1.Apresentar();


          //Aula de Contrutor Privado
          // Log log = Log.GetInstance();
          // log.PropriedadeLog="Teste intancia";
          // Log log2= Log.GetInstance();
          // System.Console.WriteLine(log2.PropriedadeLog);


         // ==================================================
          // Aaula de GET E SET NA PRATICA (Classe Data.cs)
          // Data data = new Data();
          // data.SetMes(20);
          // data.ApresentarMes();

          // ==================================================
          //Aula de Delegate
          //Operacao op = new Operacao(Calculadora.Somar);
          //op.Invoke(10,10);
          //Aula de Multi Cast Delegate
          //op=Calculadora.Subtrair;
          //op.Invoke(10,10);














         
     }

  }
}
