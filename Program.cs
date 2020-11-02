using System;

namespace _4metoda
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Вы можете совершить четыри операции с двумя аргументами. \nВведите первый аргумент.");
                double firstArg = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите второй аргумент");
                double secondArg = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите операцию (сумма, вычитание, умножение, деление)\nДля выходап напишите 'Exit'");
                string operation = Console.ReadLine();

                string sloj = "сумма";
                string vichit = "вычитание";
                string umnoj = "умножение";
                string delen = "деление";
                string exitWord = "Exit";
                
                if(operation==exitWord)
                {
                    break;
                }
                else if (operation == sloj)
                {
                    Sum(firstArg, secondArg);
                }
                else if (operation == vichit)
                {
                    Sub(firstArg, secondArg);
                }
                else if (operation == umnoj)
                {
                    Mul(firstArg, secondArg);
                }
                else if(operation == delen)
                {
                    Div(firstArg, secondArg);
                }
                
                

            }
            Console.WriteLine("Кстати, Артёмка ЛОХ!!!\n.!.     <3");
            Console.ReadKey();
        }

        static void Sum(double fA, double sA)
        {
            double sum = 0;
            sum = fA + sA;
            Console.WriteLine("Сумма аргументов равна {0}\n",sum);
        }

        static void Sub(double fA, double sA)
        {
            double sub = 0;
            sub = fA - sA;
            Console.WriteLine("Разница аргументов равна {0}\n",sub);
        }

        static void Mul(double fA, double sA)
        {
            double mul = 0;
            mul = fA * sA;
            Console.WriteLine("Произведение аргументов равно {0}\n",mul);
            
        }

        static void Div(double fA, double sA)
        {
            double div = 0;
            div = fA / sA;
            Console.WriteLine("Деление первого аргумента на второй равна {0}\n", div);
        }
    }
}
