namespace Tumakov_lab_09_421_BoroninNikita
{
    internal class Program
    {
        // 1 Задание!
        static int GetMax(int a, int b)
        {
            Console.WriteLine("Упражнение 5.1");
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        // 2 Задание!
        static void Swap(ref int a, ref int b)
        {
            
            int temp = a;
            a = b;
            b = temp;
        }

        // 3 Задание!
        static bool Factorial(int n, out ulong result)
        {
            result = 1;

            
            if (n < 0)
            {
                Console.WriteLine("Факториал отрицательного числа не существует.");
                result = 0;
                return false;
            }

            
            if (n > 20)
            {
                Console.WriteLine("Факториал слишком большого числа не может быть вычислен из-за переполнения.");
                result = 0;
                return false;
            }

            try
            {
                checked
                {
                    for (int i = 1; i <= n; i++)
                    {
                        result *= (ulong)i;
                    }
                }
                return true;
            }
            catch (OverflowException)
            {
                result = 0;
                return false;
            }
        }

        // 4 Задание!
        static bool RecursiveFactorial(int n, out ulong result)
        {
            result = 1;

            
            if (n < 0)
            {
                Console.WriteLine("Факториал отрицательного числа не существует.");
                result = 0;
                return false;
            }

            
            if (n > 20)
            {
                Console.WriteLine("Факториал слишком большого числа не может быть вычислен из-за переполнения.");
                result = 0;
                return false;
            }

            try
            {
                checked
                {
                    
                    result = CalculateFactorial(n);
                }
                return true;
            }
            catch (OverflowException)
            {
                result = 0; 
                return false;
            }
        }


        private static ulong CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
                return 1; 

            return (ulong)n * CalculateFactorial(n - 1); 
        }

        // 5 Task
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        
        static int GCD(int a, int b, int c)
        {
            return GCD(GCD(a, b), c); 
        }


        // 6 Task
        static long Fibonacci(int n)
        {
            if (n <= 1) // Базовый случай: F(0) = 0, F(1) = 1
            {
                return n;
            }
            else
            {
                // Рекурсивный вызов: F(n) = F(n-1) + F(n-2)
                return Fibonacci(n - 1) + Fibonacci(n - 2);
           }
        }

        static void Main(string[] args)
        {
            // 1 Task
            int num1 = 5;
            int num2 = 10;

            int max = GetMax(num1, num2);
            Console.WriteLine($"Наибольшее число из {num1} и {num2} = {max}");


            // 2 Task
           
            Console.WriteLine("\nУпражнение 5.2");
            Console.WriteLine($"До обмена: num1 = {num1}, num2 = {num2}");

          
            Swap(ref num1, ref num2);
            Console.WriteLine($"После обмена: num1 = {num1}, num2 = {num2}");


            // 3 Task
            Console.WriteLine("\nУпражнение 5.3");
            int number = 2; // Пример числа для вычисления факториала
            ulong resultTT;
            bool success = Factorial(number, out resultTT);

            if (success)
            {
                Console.WriteLine($"Факториал числа {number} равен {resultTT}");
            }
            else
            {
                Console.WriteLine($"Произошло переполнение при вычислении факториала числа {number}");
            }


            // 4 Task
            Console.WriteLine("\nУпражнение 5.4");
            if (RecursiveFactorial(5, out ulong result))
            {
                Console.WriteLine($"Факториал числа 5: {result}");
            }
            else
            {
                Console.WriteLine("Ошибка при вычислении факториала.");
            }


            // 5 Task
            Console.WriteLine("\nДомашнее задание 5.1");
            int nums1 = 56, nums2 = 98;
            int num3 = 42;

            
            int result2 = GCD(nums1, nums2);
            Console.WriteLine($"НОД чисел {nums1} и {nums2} = {result2}");

            
            int result3 = GCD(nums1, nums2, num3);
            Console.WriteLine($"НОД чисел {nums1}, {nums2} и {num3} = {result3}");


            // 6 Task
            Console.WriteLine("\nДомашнее задание 5.2");
            int n = 10; // Вы можете изменить это значение для получения другого числа ряда Фибоначчи
            long resultss = Fibonacci(n);

            Console.WriteLine($"Число Фибоначчи для n = {n} равно {resultss}");

        }
    }
}
