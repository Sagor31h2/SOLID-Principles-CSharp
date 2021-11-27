using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Drive();

            var airplane = new Airplane();
            airplane.Fly();

            var mfc = new MultiFunctionalCar();
            mfc.Drive();
            mfc.Fly();

        }
    }
}
