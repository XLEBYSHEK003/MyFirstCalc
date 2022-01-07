using System;

namespace Calc
{
    internal class Program
    {
        public static Version Version { get; set; } = new Version(1, 0, 0);

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(string.Format("Вас приветствует калькулятор v{0}", Version.ToString()));

            Console.WriteLine("Выберите инструмент");

            Console.WriteLine("Калькулятор -- Калькулятор");

            Console.WriteLine("Перевод чисел в другие единицы -- Перевод");

            string ver;

            ver = Console.ReadLine();



            if (ver == "Перевод" | ver == "перевод")
            {
                int y = 1024;

                Console.WriteLine("Введите число");

                if (!double.TryParse(Console.ReadLine(), out double o))
                {
                    Console.WriteLine("Ошибка: Не удалось преобразовать полученный результат в число!");
                    throw new ArgumentException();
                }


                Console.WriteLine("\t\tТип числа.\n\t\t1 - '[биты]' \n\t\t2 - '[байты]'\n\t\t3 - '[Кбайты]'\n\t\t4 - '[Мбайты]'\n\t\t5 - '[Гбайты]'\n\t\t6 - '[Тбайты]'");

                if (!double.TryParse(Console.ReadLine(), out double v))
                {
                    Console.WriteLine("Ошибка: Не удалось преобразовать полученный результат в число!");
                    throw new ArgumentException();
                }

                Console.WriteLine("Введите во что нужно перевести");

                Console.WriteLine("\t\tТип.\n\t\t1 - '[биты]' \n\t\t2 - '[байты]'\n\t\t3 - '[Кбайты]'\n\t\t4 - '[Мбайты]'\n\t\t5 - '[Гбайты]'\n\t\t6 - '[Тбайты]'");

                if (!double.TryParse(Console.ReadLine(), out double g))
                {
                    Console.WriteLine("Ошибка: Не удалось преобразовать полученный результат в число!");
                    throw new ArgumentException();
                }

                if (v < g)


                {
                    double u = g - v;

                    double k = y * u;

                    Console.WriteLine("Результат:", o / k);
                }

                if (v > g)
                {
                    double u = v - g;

                    double k = y * u;

                    Console.WriteLine("Результат:", o * k);
                }


                Console.WriteLine("Developer: Andrei Korban");

                Console.WriteLine("Завершить процесс? (yes)");

                if (Console.ReadLine() == "yes")
                {
                    Environment.Exit(0);
                }

            }



            Console.WriteLine("Добро пожаловать в калькулятор!");

            Console.WriteLine("Введите число");

            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Ошибка: Не удалось преобразовать полученный результат в число!");
                throw new ArgumentException();
            }

            Console.WriteLine("Введите 2 число");

            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Ошибка: Не удалось преобразовать полученный результат в число!");
                throw new ArgumentException();
            }


            Console.WriteLine("\t\tТип операции.\n\t\t1 - '+'\n\t\t2 - '-'\n\t\t3 - '*'\n\t\t4 - '/'\n\t\t5 - '%'");

            if (!int.TryParse(Console.ReadLine(), out int c))
            {
                Console.WriteLine("Ошибка: Не удалось преобразовать полученный результат в число!");
                throw new ArgumentException();
            }

            switch (c)
            {
                case 1:
                    {
                        Console.WriteLine(string.Format("Результат: {0}", a + b));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(string.Format("Результат: {0}", a - b));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(string.Format("Результат: {0}", a * b));
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(string.Format("Результат: {0}", a / b));
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine(string.Format("Результат: {0}", a % b));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Произошла ошибка...");
                        break;
                    }
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n- Нажмите кнопку Escape чтобы выйти -");

            if (Console.ReadKey().Key != ConsoleKey.Escape)
            {

                Main(null);

            }
        }
    }
}