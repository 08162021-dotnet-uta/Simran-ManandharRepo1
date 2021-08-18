using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      var input1 = int.Parse(Console.ReadLine()); //123a, 123 // type inference, parsing
      var input2 = int.Parse(Console.ReadLine());

      // compute stuff
      int result1 = Add(input1, input2);
      int result2 = Subtract(input1, input2);
      int result3 = Multiply(input1, input2);
      int result4 = Divide(input1, input2);

      // output stuff
      Print(result1, result2, result3, result4);
    }

    static int Add(int input1, int input2)
    {
      // compute stuff
      var compute = (int)input1 + (int)input2; // type inference, casting
      return compute;
    }

    static int Subtract(int input1, int input2)
    {
      // compute stuff
      var compute = (int)input1 - (int)input2; // type inference, casting
      return compute;
    }

    static int Multiply(int input1, int input2)
    {
      // compute stuff
      var compute = (int)input1 * (int)input2; // type inference, casting
      return compute;
    }

    static int Divide(int input1, int input2)
    {
      // compute stuff
      var compute = (int)input1 / (int)input2; // type inference, casting
      return compute;
    }

    static void Print(params int[] list)
    {
      // output stuff
      Console.Write("Answers:\n");
      for (int i = 0; i < list.Length; i++)
      {
        Console.Write(list[i] + "\n");
      }
    }


  }
}
