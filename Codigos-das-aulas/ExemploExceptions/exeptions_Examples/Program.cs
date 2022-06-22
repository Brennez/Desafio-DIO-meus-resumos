using static System.Console;

public class Program
{
  public static void Main(string[] args)
  {
    int n = 100;
    int m = 0;

    try
    {
      double result = Divide(n, m);
      WriteLine($"{n} / {m} = {result}");
    }
    catch (System.DivideByZeroException) when (n < 0) //Faz um condicional para entrar no catch
    {
      WriteLine("Não pode dividir por zero amigão");
    }
    catch (Exception ex)
    {
      // WriteLine("Apenas uma exceção");
      WriteLine(ex.Message);
      // throw; //relança a exceção 
    }
    finally
    {
      WriteLine("Finalmente a divisão foi finalizada");
    }
  }

  public static double Divide(int x, int y)
  {
    if (x == 0)
    {
      throw new MyClassExeption("Minha exceção");
    }
    return x / y;
  }

}