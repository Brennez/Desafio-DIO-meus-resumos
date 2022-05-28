using desafio_de_projeto_1.src.models;
using static System.Console;
class Program
{
  static void Main(String[] args)
  {
    Knight arus = new Knight("Arus", 42, "Knight", 469, 72);
    Wizard jenica = new Wizard("Jenica", 42, "White Wizard", 325, 474);
    Wedge wedge = new Wedge("Wdge", 42, "Ninja", 292, 89);
    Topapa topapa = new Topapa("Wedge", 42, "Ninja", 106, 611);



    WriteLine(arus);
    WriteLine(jenica);
    WriteLine(wedge);

  }
}