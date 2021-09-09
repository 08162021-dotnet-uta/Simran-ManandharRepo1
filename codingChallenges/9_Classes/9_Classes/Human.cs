using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("9_ClassesChallenge.Tests")]
namespace _9_ClassesChallenge
{
  internal class Human
  {

    private string lastName = "Smyth";
    private string firstName = "Pat";

    public Human()
    {

    }

    public Human(string firstName, string lastName)
    {
      this.firstName = firstName;
      this.lastName = lastName;
    }

    public string AboutMe()
    {
      // return $"My name is {firstName} {lastName}.";
      // return "My name is" + firstName + " " + lastName + ".";
      return String.Format("My name is {0} {1}", firstName, lastName);

    }


  }//end of class
}//end of namespace