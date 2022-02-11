using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
  class Program
  {
     static void Main(string[] args)
     {
         Pessoa p1 = new Pessoa("Geovane","Jorge");
         p1.Apresentar();
     }

  }
}
