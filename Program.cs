using System;

namespace LabaEx1 {
  class Program {
    static void Main() {
      int exponent, modeSelection, secondCharIndex, loopStartIndex, initialMode, modePermutation, modeExponentiation, modeExit;
      long resultOfExponentiation, powerStartValue, degreeBase;
      string originalNumber, changedNumber;

      modeExit = 0;
      modeExponentiation = 1;
      modePermutation = 2;
      initialMode = modeExponentiation;
      powerStartValue = 1;
      loopStartIndex = 0;
      secondCharIndex = 1;

      initialMode = modeExponentiation;
      modeSelection = initialMode;

      while (modeSelection != modeExit) {
        Console.Write("\nWhich task should I open?\r\n1 - Exponentiation\r\n2 - Permutation of the second symbol of a number\r\n0 - Exit the program\n\nMode selection - ");
        modeSelection = Convert.ToInt32(Console.ReadLine());

        if (modeSelection > modePermutation || modeSelection < modeExit) {
          Console.Write("\nan unknown number was entered\n");
        }

        if (modeSelection == modeExponentiation) {
          Console.Write("\nInput a = ");
          degreeBase = Convert.ToInt32(Console.ReadLine());

          Console.Write("\nInput n = ");
          exponent = Convert.ToInt32(Console.ReadLine());

          resultOfExponentiation = powerStartValue;

          for (int exponentiationCounter = loopStartIndex; exponentiationCounter < exponent; ++exponentiationCounter) {
            resultOfExponentiation *= degreeBase;
          }

          Console.WriteLine($"\na = {resultOfExponentiation}");
        }

        if (modeSelection == modePermutation) {
          Console.Write("\nEnter number: ");

          originalNumber = Console.ReadLine();
          changedNumber = originalNumber.Remove(secondCharIndex, 1) + originalNumber[secondCharIndex];
          Console.WriteLine($"\nResult: {changedNumber} \n");
        }
      }
    }
  }
}