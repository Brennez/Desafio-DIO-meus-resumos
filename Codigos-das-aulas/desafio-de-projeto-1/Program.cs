using desafio_de_projeto_1.src.models;
using static System.Console;
class Program
{
  static void Main(String[] args)
  {
    Knight arus = new Knight("Arus", 12, "Warrior");
    Wizard jenica = new Wizard("Jenica", 30, "White Wizard");


    WriteLine(arus);
    WriteLine(jenica);
    WriteLine(jenica.atack(10));
  }
}