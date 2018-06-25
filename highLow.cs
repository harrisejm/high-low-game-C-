using System;
using System.Collections.Generic;
class IsHighLow
{

  public string High;
  public bool isHigh()
  {
    if (High == "Higher" || High == "higher" || High == "H" || High == "h")
    {
      return true;
    }
    else
    {
      return false;
    }
  }
 }

class Test
{
  public static void Main()
  {

    // IsHighLow myHighLow=new IsHighLow();
    // int myLow= 0;
    // myHighLow.Low=myLow;
    // int myHigh= 100;
    // myHighLow.High=myHigh;
    // while


 List<int> testList = new List<int>{};
 for (int i = 0; i < 101; i++)
 {
   testList.Add(i);
 }
 int startGuess = 50;
 int startValue = 100;


Console.WriteLine("Do you want to play");
string userInput = Console.ReadLine();
    if (userInput == "y")
    {
  IsHighLow firstRun = new IsHighLow();
  Console.WriteLine("Is you number higher or lower than " + startGuess);
  string hello = Console.ReadLine();
  firstRun.High = hello;

    if (firstRun.isHigh())
      {
        Console.WriteLine("is your number higher than " + (startGuess + (startValue - startGuess)/2));
        hello = Console.ReadLine();
        startGuess = (startGuess + (startValue  - (startGuess/2)));
        startValue = startValue/2;
        if (firstRun.isHigh())
          {
          Console.WriteLine("is your number higher than " + (startGuess + (startValue - startGuess)/2));
          hello = Console.ReadLine();
          startGuess = (startGuess + (startValue  - (startGuess/2)));
          startValue = startValue/2;
          if (firstRun.isHigh())
            {
            Console.WriteLine("is your number higher than " + (startGuess + (startValue - startGuess)/2));
            hello = Console.ReadLine();
            startGuess = (startGuess + (startValue  - (startGuess/2)));
            startValue = startValue/2;
            }
          }
      }

      else
      {
        Console.WriteLine("is your number higher than " + (startGuess - (startValue- startGuess)/2));
        startGuess = (startGuess - (startValue  - (startGuess/2)));
        startValue = startValue/2;
      }


      // Console.Write("Okay, is your number higher or lower than 50? (higher/Lower/Correct)");
      // hello = Console.ReadLine();
      // if (userInput2 == "Higher" || userInput2 == "higher" || userInput2 == "H" || userInput2 == "h")
      // {
      //   Console.WriteLine("Is your number higher or lower than 75? (higher/Lower/Correct)");
      //  hello = Console.ReadLine();
      //   if (userInput3 == "Higher" || userInput3 == "higher" || userInput3 == "H" || userInput3 == "h")
      //   {
      //     Console.WriteLine("Is your number higher or lower than 83? (higher/Lower/Correct)");
      //   hello= Console.ReadLine();
      //     if (userInput4 == "Higher" || userInput4 == "higher" || userInput4 == "H" || userInput4 == "h")
      //     {
      //       Console.WriteLine("Is your number higher or lower than 92? (higher/Lower/Correct)");
      //     hello= Console.ReadLine();
      //       if (userInput5 == "Higher" || userInput5 == "higher" || userInput5 == "H" || userInput5 == "h")
      //       {
      //         Console.WriteLine("Is your number higher or lower than 96? (higher/Lower/Correct)");
      //         string userInput6 = Console.ReadLine();
      //         if (userInput6 == "Higher" || userInput6 == "higher" || userInput6== "H" || userInput6 == "h")
      //         {
      //           Console.WriteLine("Is your number higher or lower than 98? (higher/Lower/Correct)");
      //           string userInput7 = Console.ReadLine();
      //           if (userInput7 == "Higher" || userInput7 == "higher" || userInput7 == "H" || userInput7 == "h")
      //           {
      //             Console.WriteLine("Is your number higher or lower than 99? (higher/Lower/Correct)");
      //             string userInput8 = Console.ReadLine();
      //             if (userInput8 == "Higher" || userInput8 == "higher" || userInput8 == "H" || userInput8 == "h")
      //             {
      //               Console.WriteLine("Your number is 100");
      //
      //             }
      //           }
      //         }
      //       }
      //     }
      //   }
      //
      //
      //
      //
      // }
      //   else if (userInput2 == "Lower" || userInput2 == "lower" || userInput2 == "L" || userInput2 == "l")
      // {
      //   Console.WriteLine("Is your number higher or lower than 25? (higher/Lower/Correct)");
      // }
      //
      //




    //
    // }
    // else if (userInput == "n")
    // {
    //   Console.WriteLine("You entered N");
    // }
    // else
    // {
    //   Console.WriteLine("You did not enter valid response. Please restart");
    // }



}
}
}
