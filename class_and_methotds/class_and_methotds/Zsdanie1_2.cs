using System;
namespace class_and_methotds
{
    public class Tel
    {
        public int day;
        public double time;
        public double price;

        public void telephone_call()
        {
            if (day > 0 & day < 8)
            {
                if (day == 6 || day == 7)
                {
                    price *= 0.9;
                }
                double full_call_price = day * time * price;
                Console.WriteLine("Стоимость телефоного разговора равна " + full_call_price);
            }
            else Console.WriteLine("Ошибка. Введите данные повторно");
        }
    }

}

