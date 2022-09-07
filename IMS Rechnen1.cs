namespace IMS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 6;
            string Aufgabe2 = "Aufgabe2";
            string Aufgabe1 = "Aufgabe1";
            string Aufgabe3 = "Aufgabe3";
            Console.WriteLine(Aufgabe1);
            Console.WriteLine(8 + 3);
            Console.WriteLine(3 - 10);
            Console.WriteLine(-10 + 3);
            Console.WriteLine(5 * 2);
            Console.WriteLine(5 * 0.5);
            Console.WriteLine(10 / 2);
            Console.WriteLine(10 / 0.5);
            Console.WriteLine(10 % 2);
            Console.WriteLine(5 % 2);
            Console.WriteLine(12 % 6);
            Console.WriteLine(16 % 6);
            Console.WriteLine(8 + 3 * 5);
            Console.WriteLine((8 + 3) * 5);
            Console.WriteLine(3 - 10/ 2);
            Console.WriteLine(8 + 3 % 2);
            Console.WriteLine(8 * 3 % 2);
            Console.WriteLine(3 % 2 * 8);
            Console.WriteLine(i++);
            Console.WriteLine(i++ + 3);
            Console.WriteLine(-3 - i++);
            Console.WriteLine(--i);
            Console.WriteLine(--i * 3);
            Console.WriteLine(-3 + --i);
            Console.WriteLine(--i % 5);

            Console.WriteLine(Aufgabe2);
            int b = 3;
            Console.WriteLine(b);
            Console.WriteLine(b += 6);
            Console.WriteLine(b /= 2);
            Console.WriteLine(b *= 4 - 2);
            Console.WriteLine(b %= 4 * 2);
            Console.WriteLine(b %= --b);

            Console.WriteLine(Aufgabe3);
            bool f = false;
            Console.WriteLine(true == f);
            Console.WriteLine(i == 6);
            Console.WriteLine(3 == i);
            Console.WriteLine(3 < i);
            Console.WriteLine(6 <= i);
            Console.WriteLine(6 >= i);
            Console.WriteLine(3 != 3);  
            Console.WriteLine(f != false);



        }

    }
}