Console.WriteLine("Welcome to the first prise from Your Bridge Schoole");
Console.Write("Please enter your name: ");
string userName = Console.ReadLine();
Console.Write("hi " + userName + ", How Old are you? ");

///convert from string to int
int userAge = int.Parse(Console.ReadLine());

if (userAge < 18)
{
    int to18 = 18 - userAge;
    Console.WriteLine("you are yong, try again after " + to18 + " years");
    Console.ReadLine();
}

else
{
    Console.WriteLine("you are old enagh, how to play:");
    Console.WriteLine("     enter num of the ansowrs end press enter");
    Console.WriteLine("press any key to contunuw");
    Console.ReadKey();
    Console.Clear();

    Console.WriteLine("first quition");
    Console.WriteLine("1- 65464654");
    Console.WriteLine("2- 65464654");
    Console.WriteLine("3- 65464654");

    string userChose1 = Console.ReadLine();
    if (userChose1 == "1")
    {
        Console.WriteLine("that is right, press any key to contunie");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Second quition");
        Console.WriteLine("1- 65464654");
        Console.WriteLine("2- 65464654");
        Console.WriteLine("3- 65464654");

        string userChose2 = Console.ReadLine();
        if (userChose2 == "3")
        {
            Console.WriteLine("correct, press any key to contunie");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("last quition");
            Console.WriteLine("1- 65464654");
            Console.WriteLine("2- 65464654");
            Console.WriteLine("3- 65464654");

            string userChose3 = Console.ReadLine();
            if (userChose3 == "2")
            {
                Console.WriteLine("that correct you won, press any key to contunie");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("there three doors behind each door a prise, choose one:");

                Console.WriteLine("1- door 01");
                Console.WriteLine("2- door 02");
                Console.WriteLine("3- door 03");

                string doorChosen = Console.ReadLine();
                string mess = "";
                if (doorChosen == "1")
                {
                    mess = "You won BMW";
                }
                else if (doorChosen == "3")
                {
                    mess = "You won Audi";
                }
                if (doorChosen == "2")
                {
                    mess = "You won Bogaty";
                }

                Console.WriteLine($"congrarition ms {userName} you won " + mess);
                Console.ReadLine();

            }

            else
            {
                Console.WriteLine("wrang anwosrs, you lose");
                Console.ReadLine();
            }
        }

        else
        {
            Console.WriteLine("wrang anwosrs, you lose");
            Console.ReadLine();
        }
    }

    else
    {
        Console.WriteLine("wrang anwosrs, you lose");
        Console.ReadLine();
    }

}