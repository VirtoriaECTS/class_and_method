using System;
namespace class_and_methotds
{
    public class Input
    {
        public void input_sqare()
        {
            Console.WriteLine("Квадрат числа больше 25!");
        }
    }

    public class Find_square
    {
        public int first_number;
        public int last_number;
        public int find_number;

        public void method_stop_sqare() //Ищет квадрат числа от одного до десяти
        {
            for(int i = first_number; i <= last_number; i ++)
            {
                int sqare_number = i * i;
                if(sqare_number > find_number)
                {
                    Input txt = new Input();
                    txt.input_sqare();
                    break;
                }
                Console.WriteLine(sqare_number);

            }
        }
    }
	
}

