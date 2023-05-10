using System;
namespace DelegatesDemo
{
  //this is a Delegate without a return type and it takes a string as an Input.
  public delegate void MyDelegate(string text);
  public class Program
  {
    static void Main(string[] args)
    {
      //Instantiating the Delgate and Passing the Method which maches the MyDelegate return type and Signature as Parameter
      MyDelegate delegate1=new MyDelegate(PrintMessage);
      //Invoking the Delegate
      delegate1.Invoke("Varun");

    }
    //this is a Static Method which returns nothing and takes string as an input.
    public static void PrintMessage(string str)
    {
      Console.WriteLine($"Hello Mr/Mrs. {str} Goodmorning, Welcome On Board!");
    }
  }
}