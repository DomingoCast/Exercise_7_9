using System;

class digits
{
    static void Main()
    {
        int oneDigit = 0, twoDigits = 0, threeDigits = 0, more4Digits = 0;
        Console.Write("Insert a number: ");

        string input = Console.ReadLine();  // read the number as string to check the word "end"

        while(input != "end")
        {
            int number = Convert.ToInt32(input);
            if(number != 0)
            {
                if(number/10 == 0)
                    oneDigit ++;
                else if (number/100 == 0)
                    twoDigits ++;
                else if (number/1000 == 0)
                    threeDigits ++;
                else
                    more4Digits ++;
            }
            input = Console.ReadLine();
        }

        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", oneDigit, twoDigits , threeDigits , more4Digits ); 
    }
}

