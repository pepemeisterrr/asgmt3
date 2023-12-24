using System;
using System.Numerics;

namespace asgmt3
{
    internal class Program
    {
        public static int InputInt() //ввод целых чисел с обработкой исключений
        {
            string input = Console.ReadLine();
            int output = 0;
            bool parsed = int.TryParse(input, out output);
            while (!parsed)
            {
                Log.Error($"Invalid input. Entered \"{input}\" Try again...", 1);
                Log.Error("Please enter an integer", 1);
                Log.Input();
                input = Console.ReadLine();
                parsed = int.TryParse(input, out output);
            }
            return output;
        }
        public static void Task1() //делится ли введенное число на 3 и на 7
        {
            Log.Info("Task #1", 1);
            Log.Info("Enter a number", 1);
            Log.Input();
            int num = InputInt();
            if ((num % 3 == 0) && (num % 7 == 0))
                Log.Info($"{num} is divisible by 3 and by 7", 1);
            else { Log.Info($"{num} is not divisible by 3 and by 7", 1); }
        }
        public static void Task2() //сравнение двух целых чисел 
        {
            Log.Info("Task #2", 1);
            Log.Info("Please enter the first integer", 1);
            Log.Input();
            int value1 = InputInt();
            Log.Info("Please enter the second integer", 1);
            Log.Input();
            int value2 = InputInt();
            if (value1 == value2) Log.Info($"{value1} = {value2}", 1);
            else if (value1 > value2) Log.Info($"{value1} > {value2}", 1);
            else { Log.Info($"{value1} < {value2}", 1); }
        }
        public static void Task3() //определенние дня недели по введенному числу
        {
            Log.Info("Task #3", 1);
            int value;
            do
            {
                Log.Info("Please enter an integer in the range from [1] to [7]", 1);
                Log.Input();
                value = InputInt();
                if ((value < 1) || (value > 7)) { Log.Error($"{value} is out of range 1 to 7", 1); }
            } while ((value < 1) || (value > 7));
            switch (value)
            {
                case 1: Log.Info("Monday", 1); break;
                case 2: Log.Info("Tuesday", 1); break;
                case 3: Log.Info("Wednesday", 1); break;
                case 4: Log.Info("Thursday", 1); break;
                case 5: Log.Info("Friday", 1); break;
                case 6: Log.Info("Saturday", 1); break;
                case 7: Log.Info("Sunday", 1); break;
                default: Log.Error("Something went wrong...", 1); break;
            }
        }
        //public static void Task4() //сумма двух нечетных чисел, используя цикл do while
        //{
        //    Log.Info("Task #4", 1);
        //    Log.Info("Please enter two odd numbers", 1);
        //    int value1 = 0;
        //    do 
        //    { 
        //        Log.Info("First number", 1);
        //        Log.Input();
        //        value1 = InputInt();
        //        if (value1 %2 == 0) { Log.Error("Number should be odd. Retry...", 1); }
        //    } while (value1 %2 == 0);
        //    int value2 = 0;
        //    do
        //    {
        //        Log.Info("Second number", 1);
        //        Log.Input();
        //        value2 = InputInt();
        //        if ((value2 %2) == 0) { Log.Error("Number should be odd. Retry...", 1); }
        //    } while (value2 %2 == 0);
        //    Log.Info($"{value1} + {value2} = {value1 + value2}", 1);
        //}

        public static void Task4() //сумма двух нечетных чисел, используя цикл while
        {
            Log.Info("Task #4", 1);
            Log.Info("Please enter two odd numbers", 1);
            int value1 = 0;
            while (value1 %2 == 0)
            {
                Log.Info("First number", 1);
                Log.Input();
                value1 = InputInt();
                if (value1 % 2 == 0) { Log.Error("Number should be odd. Retry...", 1); }
            }
            int value2 = 0;
            while(value2 %2 == 0)
            {
                Log.Info("Second number", 1);
                Log.Input();
                value2 = InputInt();
                if ((value2 % 2) == 0) { Log.Error("Number should be odd. Retry...", 1); }
            }
            Log.Info($"{value1} + {value2} = {value1 + value2}", 1);
        }

        //public static void Task5() // вывод n кол-ва элементов последовательности Фибоначчи
        //{
        //    Log.Info("Task #5", 1);
        //    ulong[] fibonacci = [0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597,
        //        2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040,
        //        1346269, 2178309, 3524578, 5702887, 9227465, 14930352, 24157817, 39088169, 63245986, 102334155,
        //        165580141, 267914296, 433494437, 701408733, 1134903170, 1836311903, 2971215073, 4807526976,
        //        7778742049, 12586269025, 20365011074, 32951280099, 53316291173, 86267571272, 139583862445,
        //        225851433717, 365435296162, 591286729879, 956722026041, 1548008755920, 2504730781961, 4052739537881,
        //        6557470319842, 10610209857723, 17167680177565, 27777890035288, 44945570212853, 72723460248141,
        //        117669030460994, 190392490709135, 308061521170129, 498454011879264, 806515533049393, 1304969544928657,
        //        2111485077978050, 3416454622906707, 5527939700884757, 8944394323791464, 14472334024676221,
        //        23416728348467685, 37889062373143906, 61305790721611591, 99194853094755497, 160500643816367088,
        //        259695496911122585, 420196140727489673, 679891637638612258, 1100087778366101931, 1779979416004714189,
        //        2880067194370816120, 4660046610375530309, 7540113804746346429, 12200160415121876738];
        //    int n = 0;
        //    do
        //    {
        //        Log.Info("Please enter how many elements of the fibonacci sequence to output", 1);
        //        Log.Input();
        //        n = InputInt();
        //        if ((n < 1) || (n > 94)) { Log.Error($"{n} is out of range 1 to 94", 1); }
        //    } while ((n < 1) || (n > 94));
        //    for (int i = 0; i < n; i++)
        //    {
        //        Log.Num($"{fibonacci[i]}", i, 1);
        //    }
        //}
        public static void Task5() // вывод n кол-ва элементов последовательности Фибоначчи
        {
            Log.Info("Task #5", 1);
            int amount = 0;
            while ((amount < 1) || (amount > 94))
            {
                Log.Info("Please enter how many elements of the fibonacci sequence to output", 1);
                Log.Input();
                amount = InputInt();
                if ((amount < 1) || (amount > 94)) { Log.Error($"{amount} is out of range 1 to 94", 1); }
            }
            int i = 2;
            ulong n0 = 0, n1 = 1, nn = 0;
            Log.Num($"{n0}", i - 2, 1);
            Log.Num($"{n1}", i - 1, 1);
            while (i < amount)
            {
                nn = n1 + n0;
                n0 = n1;
                n1 = nn;
                Log.Num($"{nn}", i, 1);
                i++;
            }
        }

        public static void Main(string[] args)
        {
            ConsoleKeyInfo option;
            do
            {
                Log.Input("Select Task [1] - [5] or [esc] to exit >", 0);
                option = Console.ReadKey(true);
                Console.WriteLine();
                switch (option.Key)
                {
                    case ConsoleKey.D1: Task1(); break;
                    case ConsoleKey.D2: Task2(); break;
                    case ConsoleKey.D3: Task3(); break;
                    case ConsoleKey.D4: Task4(); break;
                    case ConsoleKey.D5: Task5(); break;

                    case ConsoleKey.NumPad1: Task1(); break;
                    case ConsoleKey.NumPad2: Task2(); break;
                    case ConsoleKey.NumPad3: Task3(); break;
                    case ConsoleKey.NumPad4: Task4(); break;
                    case ConsoleKey.NumPad5: Task5(); break;

                    default:
                        if (option.Key != ConsoleKey.Escape)
                        {
                            Log.Error($"[{option.Key}] is out of range [1] to [5]", 1);
                        }
                        break;
                }
            } while (option.Key != ConsoleKey.Escape);
            Log.Info("Goodbye", 1);
        }   
    }
}
