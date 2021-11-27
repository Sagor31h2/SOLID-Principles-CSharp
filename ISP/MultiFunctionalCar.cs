using System;
namespace ISP
{
    public class MultiFunctionalCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("multifunctional car is driving");
        }

        public void Fly()
        {
            Console.WriteLine("multifunctional car is flying");
        }
    }
}