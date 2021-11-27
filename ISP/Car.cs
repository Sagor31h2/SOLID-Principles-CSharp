using System;

namespace ISP
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("car is driving");
        }

        public void Fly()
        {
            throw new System.NotImplementedException();
        }
    }
}