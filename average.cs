using System;

public class Average{
    public static void Main(){
        double total = 0, mark, counter = 0, average;
        string input;

        Console.Write("Insert a mark: ");
        input = Console.ReadLine();	// we read the mark as string to check the word "end"	 

        while(input != "end")  // if the mark isn't an end then we pass it to double to work with it
        {  
            mark = Convert.ToDouble(input);
            counter++;
            total += mark; 
            Console.Write("Insert a mark: ");
            input = Console.ReadLine();
        }

        if(counter != 0)
        {
            average = total/counter;
            Console.WriteLine("The average is {0}.", average);
        }
    }
}
