using static System.Console;
public class Calculator
{

  public double sum(double x, double y)
  {
    return x + y;
  }

  public double division(double x, double y)
  {
    double result = 0;
    try
    {
      result = x / y;
    }
    catch (DivideByZeroException)
    {
      WriteLine("Erro! Não pode dividir por zero");

    }
    return result;
  }

  public double multiply(double x, double y)
  {
    return x * y;
  }
}