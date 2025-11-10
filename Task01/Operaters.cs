using System;

namespace Task01
{

  public class Operators
  {
    public void Add(int a, int b)
    {
      Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
    }

    public void Subtract(int a, int b)
    {
      Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
    }

    public void Multiply(int a, int b)
    {
      Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
    }

    public void Divide(int a, int b)
    {
      Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
    }
  }
}