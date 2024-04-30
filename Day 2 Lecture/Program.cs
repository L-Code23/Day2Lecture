using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int myAge = 5;
        if (myAge >= 21)
        {
            Console.WriteLine("You can drink.");
        }
        else if (myAge >= 18)
        {
            Console.WriteLine("You can vote.");
        }
        else if (myAge >= 16)
        {
            Console.WriteLine("You can drive.");
        }
        else
        {
            Console.WriteLine("You are too young");
        }



        //Mini Exercise
        //Ask user for a positive number
        //Collect number from user
        // If the number is positive(include 0) then display "positive"
        //otherwise I want you to display negative


        Console.WriteLine("Enter a positive number.");
        int number = int.Parse(Console.ReadLine());

        if (number >= 0)
        {
            Console.WriteLine("positive");
        }
        else
        {
            Console.WriteLine("negative");
        }

        //Switch Statement
        int menuChoice = 1;

        switch (menuChoice)
        {
            case 1:
                Console.WriteLine("Menu choice 1");

                break;

            case 2:
                Console.WriteLine("Menu choice 2");

                break;

            case 3:
                Console.WriteLine("Menu choice 3");

                break;

            case 4:
                Console.WriteLine("Menu choice 4");

                break;

             default:
                Console.WriteLine("Invalid");    
                
                break;   
        }
        //ternary
        int x = 20;
        int y = 30;

        string msg = x > y ? "x is greater than y" : "y is greater than x";
        Console.WriteLine(msg);

        //--------------------------------------------Loops---------------------------------------------------------------

        //for(initialization; boolean_expression;update){
        //}

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        } 
        //Write a for loop that starts at 10 then counts down to 0

        for(int i = 10; i>=0; i--)
        {
            Console.WriteLine(i);
        }

        //While Loop
        // Be care with while loops and try not to run infinite loops.
        bool keepLooping = true;
        while (keepLooping)
        {

            //main code
            Console.WriteLine("Do you want to loop again? press n to stop.");
            string loopChoice = Console.ReadLine();
            if (loopChoice == "n")
            {
                keepLooping = false;
            }
        }
            //Do While Loop
            int posNumber = 0;
            do
            {
                Console.WriteLine("Please enter a positive number.");
                posNumber = int.Parse(Console.ReadLine());
            } while (posNumber <= 0);
            Console.WriteLine(posNumber);

            //Foreach Loop
            //array
            string[] menu = { "Mac and Cheese", "Chicken", "Soda" };
            foreach(string item in menu)
            {
                Console.WriteLine(item);
            }

        //break
        while (true)
        {
            Console.WriteLine("Main Code");
            Console.WriteLine("Continue? y/n");
            string continueChoice = Console.ReadLine();
            if(continueChoice == "n")
            {
                break;
            }
         
        }
        //continue
        while (true)
        {
            Console.WriteLine("Please enter a radius");
            int radius = int.Parse(Console.ReadLine());
            if(radius <= 0)
            {
                Console.WriteLine("Value must be positive");
                continue;
            }
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine(area);
            break;
        }



    }
}