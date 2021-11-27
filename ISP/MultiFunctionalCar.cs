using System;
namespace ISP
{
    public class MultiFunctionalCar : IMultifunctionalVehicle
    {


        public void Drive()
        {
            Console.WriteLine("multifunctional car is driving");
        }

        public void Fly()
        {
            Console.WriteLine("multifuntional car is flying");
        }
    }
}