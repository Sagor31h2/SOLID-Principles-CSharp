using System;

namespace ISP
{
    public class Car : ICar
    {

        public void Drive()
        {
            Console.WriteLine("car is driving");
        }
    }
}