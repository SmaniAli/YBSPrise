Console.Title = "Your Bridge School Big Contest";
Console.WriteLine("Welcome to the first contest from Your Bridge School");
Console.Write("Please enter your name: ");
string userName = Console.ReadLine();
Console.Write("hi " + userName + ", How old are you? ");

///convert from string to int
int userAge = int.Parse(Console.ReadLine());

if (userAge < 18)
{
    int to18 = 18 - userAge;
    Console.WriteLine("you are young, try again after " + to18 + " years");
    Console.ReadLine();
}

else
{
    Console.WriteLine("you are old enough, how to play:");
    Console.WriteLine("     enter num of the answer end press enter");
    Console.WriteLine("press any key to continue ......");
    Console.ReadKey();
    Console.Clear();

    Console.WriteLine("first question");
    Console.WriteLine("How many letter in english ?");
    Console.WriteLine("1- 25 letter");
    Console.WriteLine("2- 26 letter");
    Console.WriteLine("3- 27 letter");

    string userChose1 = Console.ReadLine();
    if (userChose1 == "1")
    {
        Console.WriteLine("that is right, press any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Second question");
        Console.WriteLine("Fill the blink: What .... your name?");
        Console.WriteLine("1- am");
        Console.WriteLine("2- are");
        Console.WriteLine("3- is");

        string userChose2 = Console.ReadLine();
        if (userChose2 == "3")
        {
            Console.WriteLine("correct, press any key to continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("last question");
            Console.WriteLine("What is the color of the sky");
            Console.WriteLine("1- red");
            Console.WriteLine("2- blue");
            Console.WriteLine("3- green");

            string userChose3 = Console.ReadLine();
            if (userChose3 == "2")
            {
                Console.WriteLine("that correct you won, press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("there three doors behind each door a prize, choose one:");

                Console.WriteLine("1- door 01");
                Console.WriteLine("2- door 02");
                Console.WriteLine("3- door 03");

                string doorChosen = Console.ReadLine();
                string mess = "";
                if (doorChosen == "1")
                {
                    mess = "You won Bugatti Bolide";
                }
                else if (doorChosen == "3")
                {
                    mess = "You won Lamborghini";
                }
                if (doorChosen == "2")
                {
                    mess = "You won maruti";
                }

                Console.WriteLine($"congrarition ms {userName} you won " + mess);
                Console.ReadLine();

            }

            else
            {
                Console.WriteLine("wrang answer, you lose");
                Console.ReadLine();
            }
        }

        else
        {
            Console.WriteLine("wrang answer, you lose");
            Console.ReadLine();
        }
    }

    else
    {
        Console.WriteLine("wrang answer, you lose");
        Console.ReadLine();
    }

}