using System;

namespace _9_ClassesChallenge
{
  public class Program
  {
    public static void Main(string[] args)
    {

      Human Sim = new Human();
      Human Simi = new Human("Simran", "Manandhar");

      Console.WriteLine(Sim.AboutMe());
      Console.WriteLine(Simi.AboutMe());

      Human2 Sim1 = new Human2("Cory", "Tinsley", "Brown");
      Human2 Sim2 = new Human2("Jack", "Ma", 30);
      Human2 Sim3 = new Human2("Lee", "Long", 25, "Grey");

      Console.WriteLine(Sim1.AboutMe2());
      Console.WriteLine(Sim2.AboutMe2());
      Console.WriteLine(Sim3.AboutMe2());

      Sim2.Weight = 400;
      System.Console.WriteLine("Bobby's weight was set to 400...");
      System.Console.WriteLine("Bobby's weight was set to 401...");
      Sim2.Weight = 401;
      System.Console.WriteLine($"Bobby's waight is now {Sim2.Weight}");




    }
  }
}
