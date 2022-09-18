using System;

namespace очередняра
{
    using System;

    namespace c_
    {
        class Program
        {
            static void Main(string[] args)
            {

                string cont;

                do
                {

                    double fn;
                    double sn;
                    string o;
                    double answ;

                    Console.Clear();
                    Console.WriteLine("Первое число: ");
                    fn = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Действие %, *, /, +, - : ");
                    o = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Второе число: ");
                    sn = Convert.ToDouble(Console.ReadLine());

                    if (o == "+")
                    {

                        answ = fn + sn;
                        Console.WriteLine("Результат: " + answ);

                    }

                    if (o == "-")
                    {

                        answ = fn - sn;
                        Console.WriteLine("Результат: " + answ);

                    }

                    if (o == "*")
                    {

                        answ = fn * sn;
                        Console.WriteLine("Результат: " + answ);

                    }

                    if (o == "/")
                    {

                        answ = fn / sn;
                        Console.WriteLine("Результат: " + answ);

                    }

                    if (o == "%")
                    {

                        answ = fn % sn;
                        Console.WriteLine("Результат: " + answ);

                    }

                    Console.WriteLine("Совершить еще одну операцию?");
                    cont = Convert.ToString(Console.ReadLine());

                } while (cont == "yes");
                Console.ReadKey();
            }
        }
    }
}







