using System;

namespace _4_MethodsChallenge
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //1
      string name = GetName();
      GreetFriend(name);

      //2
      double result1 = GetNumber();
      double result2 = GetNumber();
      int action1 = GetAction();
      double result3 = DoAction(result1, result2, action1);

      Console.WriteLine($"The result of your mathematical operation is {result3}.");
    }

    public static string GetName()
    {
      // throw new NotImplementedException("GetName() is not implemented yet0");
      System.Console.WriteLine("Please Enter your name");
      string name = System.Console.ReadLine();
      return name;

    }

    public static string GreetFriend(string name)
    {
      // throw new NotImplementedException("GreetFriend() is not implemented yet");
      return $"Hello, {name}. You are my friend.";
    }

    public static double GetNumber()
    {
      // throw new NotImplementedException("GetNumber() is not implemented yet");
      System.Console.WriteLine("Enter a number");
      string input = System.Console.ReadLine();
      double num;
      bool number = double.TryParse(input, out num);
      if (!number)
      {
        throw new FormatException($"The user input, {input}, is invalid.");
      }
      return num;
    }

    public static int GetAction()
    {
      // throw new NotImplementedException("GetAction() is not implemented yet");
      bool unsuccessful;
      int num1;
      do
      {
        System.Console.WriteLine("Press numbers to do your action");
        System.Console.WriteLine("\n\t1 for add.\n\t2 for subtract.\n\t3 for multiply.\n\t4 for divide.\n");
        string input = Console.ReadLine();
        unsuccessful = int.TryParse(input, out num1);
      } while (!unsuccessful || num1 < 1 || num1 > 4);

      return num1;
    }

    public static double DoAction(double x, double y, int action)
    {
      // throw new NotImplementedException("DoAction() is not implemented yet");
      switch (action)
      {
        case 1:
          return x + y;
        case 2:
          return Math.Max(x, y) - Math.Min(x, y);
        case 3:
          return x * y;
        case 4:
          return Math.Max(x, y) / Math.Min(x, y);
        default:
          throw new FormatException("Something went wrong in DoAction()");
      }
    }
  }
}
