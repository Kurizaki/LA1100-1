using System.Drawing;
using System.Transactions;

namespace NumberGuessingAdvancedDegin
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" _______                  __                    _______                                     ");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("|    |  |.--.--.--------.|  |--.-----.----.    |     __|.--.--.-----.-----.-----.-----.----.");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("|       ||  |  |        ||  _  |  -__|   _|    |    |  ||  |  |  -__|__ --|__ --|  -__|   _|");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("|__|____||_____|__|__|__||_____|_____|__|      |_______||_____|_____|_____|_____|_____|__|  ");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                                                                                            ");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine(" __  __                               __  __               __                  __ __        ");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("|  |/  |.-----.---.-.-----.--.--.    |  |/  |.-----.-----.|  |.-----.--.--.--.|__|__|.-----.");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("|     < |  -__|  _  |     |  |  |    |     < |  _  |  -__||  ||  -__|  |  |  ||  |  ||     |");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("|__|\\__||_____|___._|__|__|_____|    |__|\\__||_____|_____||__||_____|________||__|  ||__|__|");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("                                                                                |___|       ");
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Beliebige Taste zum Starten");
            Console.ReadKey();
            ShowSimplePercentage();
            Console.ReadKey();
        }
        static void ShowSimplePercentage()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rLoading: {i}%   ");
                Thread.Sleep(25);
            }
            Console.Write("\rFertig!          ");
            Console.Clear();
            int schätzen = 0;
            string antwort = "";
            int Versuche = 0;
            int number = 0;
            bool check = false;
            int schwierigkeit = 0;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" _______                  __                    _______                                     ");
            Console.WriteLine("|    |  |.--.--.--------.|  |--.-----.----.    |     __|.--.--.-----.-----.-----.-----.----.");
            Console.WriteLine("|       ||  |  |        ||  _  |  -__|   _|    |    |  ||  |  |  -__|__ --|__ --|  -__|   _|");
            Console.WriteLine("|__|____||_____|__|__|__||_____|_____|__|      |_______||_____|_____|_____|_____|_____|__|  ");
            Console.WriteLine("                                                                                            ");
            Console.WriteLine("                                                                                            ");
            Console.WriteLine("Herrzlich Willkommen zu meinem Schätzspiel Neuling. In diesem Spiel musst du erraten an welche Zahl ich denke.");
            Console.WriteLine("                                                                                            ");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Als Anfänger empfehle ich dir die Schwierigkeit 1 zu nehemen aber es gibt auch 2 und 3");
            Console.WriteLine("In der ersten Schwierigkeit denke ich mir eine Zahl zwischen 1 und 100 aus, in der zweiten eine Zahl zwischen 1 und 500, und in der dritten eine Zahl zwischen 1 und 1000.");
            Console.WriteLine("                                                                                            ");
            System.Threading.Thread.Sleep(2000);
            Console.Write("beliebige Taste um die Schwierigkeit einzustellen.");
            Console.ReadKey();
            Console.Clear();
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" _______                  __                    _______                                     ");
                Console.WriteLine("|    |  |.--.--.--------.|  |--.-----.----.    |     __|.--.--.-----.-----.-----.-----.----.");
                Console.WriteLine("|       ||  |  |        ||  _  |  -__|   _|    |    |  ||  |  |  -__|__ --|__ --|  -__|   _|");
                Console.WriteLine("|__|____||_____|__|__|__||_____|_____|__|      |_______||_____|_____|_____|_____|_____|__|  ");
                Console.WriteLine("                                                                                            ");
                Console.WriteLine("Also welche Schwierigkeit möchtest du wählen 1, 2 oder 3?");
                while (check == false)
                {
                    try
                    {
                        Console.WriteLine("                                                                                            ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        schwierigkeit = Convert.ToInt32(Console.ReadLine());
                        check = true;
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                                                                                            ");
                        Console.WriteLine("Ungültige Eingabe");
                        check = false;
                    }
                }
                check = false;
                Console.Clear();
                while (schwierigkeit > 3)
                {
                    if (schwierigkeit > 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                                                                                            ");
                        Console.WriteLine("Error... Du hast eine ungültige Schwierigkeit eingegeben.");
                    }
                    while (check == false)
                    {
                        try
                        {
                            Console.WriteLine("                                                                                            ");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            schwierigkeit = Convert.ToInt32(Console.ReadLine());
                            check = true;
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("                                                                                            ");
                            Console.WriteLine("Ungültige Eingabe");
                            check = false;
                        }
                    }
                    check = false;
                }
                if (schwierigkeit == 1)
                {
                    Random random1 = new();
                    number = random1.Next(1, 100);
                }
                if (schwierigkeit == 2)
                {
                    Random random2 = new();
                    number = random2.Next(1, 500);
                }
                if (schwierigkeit == 3)
                {
                    Random random3 = new();
                    number = random3.Next(1, 1000);
                }
                if (schwierigkeit == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(" _______                  __                    _______                                     ");
                    Console.WriteLine("|    |  |.--.--.--------.|  |--.-----.----.    |     __|.--.--.-----.-----.-----.-----.----.");
                    Console.WriteLine("|       ||  |  |        ||  _  |  -__|   _|    |    |  ||  |  |  -__|__ --|__ --|  -__|   _|");
                    Console.WriteLine("|__|____||_____|__|__|__||_____|_____|__|      |_______||_____|_____|_____|_____|_____|__|  ");
                    Console.WriteLine("                                                                                            ");
                    Console.WriteLine("Hmmm.. Ich habe eine Zahl zwischen 1 und 100 im Kopf, doch welche ist sie?");
                }
                if (schwierigkeit == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(" _______                  __                    _______                                     ");
                    Console.WriteLine("|    |  |.--.--.--------.|  |--.-----.----.    |     __|.--.--.-----.-----.-----.-----.----.");
                    Console.WriteLine("|       ||  |  |        ||  _  |  -__|   _|    |    |  ||  |  |  -__|__ --|__ --|  -__|   _|");
                    Console.WriteLine("|__|____||_____|__|__|__||_____|_____|__|      |_______||_____|_____|_____|_____|_____|__|  ");
                    Console.WriteLine("                                                                                            ");
                    Console.WriteLine("                                                                                            ");
                    Console.WriteLine("Hmmm.. Ich habe eine Zahl zwischen 1 und 500 im Kopf, doch welche ist sie?");
                }
                if (schwierigkeit == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(" _______                  __                    _______                                     ");
                    Console.WriteLine("|    |  |.--.--.--------.|  |--.-----.----.    |     __|.--.--.-----.-----.-----.-----.----.");
                    Console.WriteLine("|       ||  |  |        ||  _  |  -__|   _|    |    |  ||  |  |  -__|__ --|__ --|  -__|   _|");
                    Console.WriteLine("|__|____||_____|__|__|__||_____|_____|__|      |_______||_____|_____|_____|_____|_____|__|  ");
                    Console.WriteLine("                                                                                            ");
                    Console.WriteLine("                                                                                            ");
                    Console.WriteLine("Hmmm.. Ich habe eine Zahl zwischen 1 und 1000 im Kopf, doch welche ist sie?");
                }
                while (check == false)
                {
                    try
                    {
                        Console.WriteLine("                                                                                            ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        schätzen = Convert.ToInt32(Console.ReadLine());
                        check = true;
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                                                                                            ");
                        Console.WriteLine("Ungültige Eingabe");
                        check = false;
                    }
                }
                check = false;
                while (schätzen != number)
                {
                    if (schwierigkeit == 1)
                    {
                        if (schätzen > 100)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error... Du hast eine ungültige Zahl eingegeben. Ich erkenne doch wenn die Zah über 100 ist.");
                        }
                    }
                    if (schwierigkeit == 2)
                        if (schätzen > 500)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error... Du hast eine ungültige Zahl eingegeben. Ich erkenne doch wenn die Zah über 500 ist.");
                        }
                    if (schwierigkeit == 3)
                        if (schätzen > 1000)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error... Du hast eine ungültige Zahl eingegeben. Ich erkenne doch wenn die Zah über 1000 ist.");
                        }
                    if (schätzen < number)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Du liegst da etwas zu tief mit " + schätzen);
                        Versuche++;
                    }
                    if (schätzen > number)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Huh? Du hast ja zu hoch geschätzt mit " + schätzen + "!");
                        Versuche++;
                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("                                                                                            ");
                    Console.WriteLine("Versuche es doch nochmal");
                    while (check == false)
                    {
                        try
                        {
                            Console.WriteLine("                                                                                            ");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            schätzen = Convert.ToInt32(Console.ReadLine());
                            check = true;
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("                                                                                            ");
                            Console.WriteLine("Ungültige Eingabe");
                            check = false;
                        }
                    }
                    check = false;
                }
                Console.Clear();
                if (schätzen == number)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(" _______                  __                    _______                                     ");
                    Console.WriteLine("|    |  |.--.--.--------.|  |--.-----.----.    |     __|.--.--.-----.-----.-----.-----.----.");
                    Console.WriteLine("|       ||  |  |        ||  _  |  -__|   _|    |    |  ||  |  |  -__|__ --|__ --|  -__|   _|");
                    Console.WriteLine("|__|____||_____|__|__|__||_____|_____|__|      |_______||_____|_____|_____|_____|_____|__|  ");
                    Console.WriteLine("                                                                                            ");
                    Console.WriteLine("Warte Was?! Du hast richtig geschätzt!? Wie? das ist doch unmöglich!! Du hast " + Versuche + " versuche gebraucht!");
                    Console.WriteLine("                                                                                            ");
                    Console.WriteLine("Willst du nochmal gegen mich antreten? [Ja][Nein]");
                }
                while (check == false)
                {
                    try
                    {
                        Console.WriteLine("                                                                                            ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        antwort = Convert.ToString(Console.ReadLine());
                        check = true;
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                                                                                            ");
                        Console.WriteLine("Ungültige Eingabe");
                        check = false;
                    }
                }
                check = false;
                Console.Clear();
            } while (antwort == "Ja");
            if (antwort == "Nein")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("                                                                                            ");
                Console.WriteLine("Vielen Dank fürs spielen!");
                System.Threading.Thread.Sleep(1000);
                Environment.Exit(0);
            }
        }
    }
}