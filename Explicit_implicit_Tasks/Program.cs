using System;

namespace Explicit_implicit_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock(); // 1 задание. Класс clock
            int val = 34;
            clock = (Clock)val;
            val = (int)clock;
            Console.WriteLine(clock.Hours);
            Console.WriteLine(val);

            Fahrenheit fahrenheit1 = new Fahrenheit(); // 2 задание. Классы Celcius и Fahrenheit
            fahrenheit1.Gradus = 70;
            Celcius celcius1 = (Celcius)fahrenheit1; // перевод из фаренгейта в цельсий
            Console.WriteLine(celcius1.Gradus);

            Celcius celcius2 = new Celcius();
            celcius2.Gradus = 43;
            Fahrenheit fahrenheit2 = (Fahrenheit)celcius2; // перевод из цельсий в фаренгейты
            Console.WriteLine(fahrenheit2.Gradus);

            Euro euro1 = new Euro(); // 3 задание. Классы Dollar и Euro
            euro1.Sum = 20;
            Dollar dollar1 = euro1; // неявный перевод из евро в доллары
            Console.WriteLine(dollar1.Sum);

            Dollar dollar2 = new Dollar();
            dollar2.Sum = 45;
            Euro euro2 = (Euro)dollar2; // явный перевод ид долларов в евро
            Console.WriteLine(euro2.Sum);
        }
    }
}
