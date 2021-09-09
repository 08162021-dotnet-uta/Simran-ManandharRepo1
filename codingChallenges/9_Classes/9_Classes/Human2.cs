using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("9_ClassesChallenge.Tests")]
namespace _9_ClassesChallenge
{
  internal class Human2
  {
    private string lastName = "Smyth";
    private string firstName = "Pat";
    private string eyeColor;
    private int age;

    public Human2()
    {

    }

    public Human2(string firstName, string lastName)
    {
      this.firstName = firstName;
      this.lastName = lastName;
    }

    public Human2(string firstName, string lastName, string eyeColor)
    {
      this.firstName = firstName;
      this.lastName = lastName;
      this.eyeColor = eyeColor;
      this.age = 0;
    }

    public Human2(string firstName, string lastName, int age)
    {
      this.firstName = firstName;
      this.lastName = lastName;
      this.age = age;
    }

    public Human2(string firstName, string lastName, int age, string eyeColor)
    {
      this.firstName = firstName;
      this.lastName = lastName;
      this.age = age;
      this.eyeColor = eyeColor;
    }

    public string AboutMe()
    {
      return $"My name is {this.firstName} {this.lastName}.";
    }

    public string AboutMe2()
    {
      if (this.age == 0)
      {
        return $"My name is {this.firstName} {this.lastName}. My eye color is {this.eyeColor}.";
      }
      else if (this.eyeColor == null)
      {
        return $"My name is {this.firstName} {this.lastName}. My age is {this.age}";
      }
      else if (this.age == 0 && this.eyeColor == null)
      {
        return String.Format("My name is {0} {1}", firstName, lastName);
      }
      else
      {
        return $"My name is {this.firstName} {this.lastName}. My age is {this.age}. My eye color is {this.eyeColor}";
      }
    }

    private int _weight;
    public int Weight
    {
      get
      {
        return _weight;
      }
      set
      {
        if (_weight < 0 || _weight > 400)
        {
          _weight = 0;
        }
      }
    }





  }
}