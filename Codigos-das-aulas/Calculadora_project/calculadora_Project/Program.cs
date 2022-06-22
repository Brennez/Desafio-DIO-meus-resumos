using static System.Console;
public class Program
{
  public static void Main()
  {
    Calculator c = new Calculator();

    int op;
    do
    {
      WriteLine("OPÇÔES");
      WriteLine("1 - SOMA");
      WriteLine("2 - MULTIPLICAÇÃO");
      WriteLine("3 - DIVISÃO");
      WriteLine("0 - SAIR");
      op = int.Parse(ReadLine());

      switch (op)
      {
        case 1:
          WriteLine($"RESULTADO: {c.sum(readNumber1(), readNumber2())}");
          break;
        case 2:
          WriteLine($"RESULTADO: {c.multiply(readNumber1(), readNumber2())}");
          break;
        case 3:
          double result = c.division(readNumber1(), readNumber2());
          WriteLine($"RESULTADO: {result}");
          break;
        case 0:
          WriteLine("Obrigado por usar!");
          break;
        default:
          WriteLine("Opção inválida");
          break;
      }
    } while (op != 0);
  }

  public static double readNumber1()
  {
    Write("N1: ");
    return double.Parse(ReadLine());

  }

  public static double readNumber2()
  {
    Write("N2: ");
    return double.Parse(ReadLine());
  }

}