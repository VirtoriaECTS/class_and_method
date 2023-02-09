using System;
using class_and_methotds;

namespace class_and_method
{
    class Program
    {

        static void Main(string[] args)
        {
            //Задание 1 и 2
            Tel call = new Tel();
            Console.WriteLine("Введите день раговора");
            call.day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите время разговора");
            call.time = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость");
            call.price = Convert.ToDouble(Console.ReadLine());
            call.telephone_call();

            //Задание 3
            Find_square zad3 = new Find_square();
            zad3.first_number = 1;
            zad3.last_number = 10;
            zad3.find_number = 25;
            zad3.method_stop_sqare();
            Console.ReadLine();
        }


    }
}



