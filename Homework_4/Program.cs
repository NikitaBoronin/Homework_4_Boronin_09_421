namespace Homework_4
{
    internal class Program
    {
        
        // 1 Задание!
        static bool NumberExistsInArray(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return true;
                }
            }
            return false;
        }

        static int FindIndex(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return i;
                }
            }
            return -1; 
        }
        static void Taks1()
        {
            Console.WriteLine("1 задача\n");
            Random random = new Random();
            int[] numbers = new int[20];

           
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 100);
                Console.WriteLine($"Значение массива на месте [{i}] - {numbers[i]}");
            }

            Console.WriteLine("Введите два числа из массива, которые хотите поменять местами. У вас есть 2 попытки.");

            int swapCount = 0; 

            while (swapCount < 2)
            {
                Console.WriteLine("Введите первое число:");
                if (!int.TryParse(Console.ReadLine(), out int num1) || !NumberExistsInArray(numbers, num1))
                {
                    Console.WriteLine("Первое число отсутствует в массиве. Попробуйте снова.");
                    continue;
                }

                Console.WriteLine("Введите второе число:");
                if (!int.TryParse(Console.ReadLine(), out int num2) || !NumberExistsInArray(numbers, num2))
                {
                    Console.WriteLine("Второе число отсутствует в массиве. Попробуйте снова.");
                    continue;
                }

                
                int index1 = FindIndex(numbers, num1);
                int index2 = FindIndex(numbers, num2);

                
                Console.WriteLine($"Меняем местами числа {num1} и {num2}.");
                numbers[index1] = num2;
                numbers[index2] = num1;

                swapCount++;
            }

            
            Console.WriteLine("Итоговый массив:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Значение массива на месте [{i}] - {numbers[i]}");
            }

        }

        // 2 задание
        static int Task2(ref int product, out double average, params int[] array)
        {
            Console.WriteLine("2 задание\n");
            
            if (array.Length == 0)
            {
                Console.WriteLine("Массив пуст. Невозможно выполнить вычисления.");
                product = 0;
                average = 0;
                return 0;
            }

            int sum = 0;
            product = 1;

            foreach (int num in array)
            {
                sum += num;
                product *= num;
            }

            average = (double)sum / array.Length;

            Console.WriteLine($"Сумма элементов массива: {sum}");
            Console.WriteLine($"Произведение элементов массива: {product}");
            Console.WriteLine($"Среднее арифметическое элементов массива: {average}");

            return sum;

        }

        // 3 Задача!
        static void DrawNumber(int number)
        {
            
            string[] patterns = new string[]
            {
            "#####\n#   #\n#   #\n#   #\n#####", // 0
            "  #  \n  #  \n  #  \n  #  \n  #  ", // 1
            "#####\n    #\n#####\n#    \n#####", // 2
            "#####\n    #\n#####\n    #\n#####", // 3
            "#   #\n#   #\n#####\n    #\n    #", // 4
            "#####\n#    \n#####\n    #\n#####", // 5
            "#####\n#    \n#####\n#   #\n#####", // 6
            "#####\n    #\n    #\n    #\n    #", // 7
            "#####\n#   #\n#####\n#   #\n#####", // 8
            "#####\n#   #\n#####\n    #\n#####", // 9
            };

            
            Console.WriteLine(patterns[number]);
        }
        static void Task3()
        {
            Console.WriteLine("3 задание\n");
            while (true)
            {
                Console.WriteLine("Введите число от 0 до 9 или команду 'exit'/'закрыть' для выхода:");

                string input = Console.ReadLine();

                
                if (input.ToLower() == "exit" || input.ToLower() == "закрыть")
                {
                    Console.WriteLine("Программа завершена.");
                    break;
                }

                try
                {
                   
                    int number = int.Parse(input);

                    if (number >= 0 && number <= 9)
                    {
                        DrawNumber(number);
                    }
                    else
                    {
                        
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка: число должно быть от 0 до 9!");
                        Thread.Sleep(3000);
                        Console.ResetColor();
                    }
                }
                catch (FormatException)
                {
                   
                    Console.WriteLine("Ошибка: введено не число! Программа завершена с исключением.");
                    throw;
                }
            }
        }

        // 4 Задача!

        struct GrandFather
        {
            public string Name; 
            public GrumbleLevel Level; 
            public string[] Phrases; 
            public int NumberBruises;

            
            public int GetHit(params string[] swearWords)
            {
                foreach (var phrase in Phrases)
                {
                    foreach (var swear in swearWords)
                    {
                        if (phrase.ToLower().Contains(swear.ToLower()))
                        {
                            NumberBruises++;
                        }
                    }
                }
                Console.WriteLine($"Дед {Name} получил {NumberBruises} фингалов.");
                return NumberBruises;
            }
        }

        enum GrumbleLevel
        {
            Low = 1,
            Medium,
            High
        }

        static void Main(string[] args)
        {

            Taks1();
            int number = 10;
            double average;
            int[] numbers = { 1, 2 };
            Task2(ref number, out average, numbers);
            Task3();

            Console.WriteLine("\n 4 задание\n");
            GrandFather[] grandFathers = new GrandFather[5];

            grandFathers[0] = new GrandFather
            {
                Name = "Иван",
                Level = GrumbleLevel.Low,
                Phrases = new string[] { "Черт!", "Какого черта!", "Гады!" },
                NumberBruises = 0
            };

            grandFathers[1] = new GrandFather
            {
                Name = "Петр",
                Level = GrumbleLevel.Medium,
                Phrases = new string[] { "Шкет!", "Дурень!", "Черт побери!" },
                NumberBruises = 0
            };

            grandFathers[2] = new GrandFather
            {
                Name = "Алексей",
                Level = GrumbleLevel.High,
                Phrases = new string[] { "Имбицил!", "Дебил!", "Это просто ужас!" },
                NumberBruises = 0
            };

            grandFathers[3] = new GrandFather
            {
                Name = "Михаил",
                Level = GrumbleLevel.Low,
                Phrases = new string[] { "Кто тут?", "Гады!" },
                NumberBruises = 0
            };

            grandFathers[4] = new GrandFather
            {
                Name = "Семен",
                Level = GrumbleLevel.Medium,
                Phrases = new string[] { "Блин!", "Черт!", "Шимпанзе!" },
                NumberBruises = 0
            };

            
            string[] swearWords = { "блин", "черт", "шимпанзе", "гады", "дебил", "имбицил", "Дурень" };

            
            foreach (var grandfather in grandFathers)
            {
                grandfather.GetHit(swearWords);
            }

        }
        
        


    }
}
