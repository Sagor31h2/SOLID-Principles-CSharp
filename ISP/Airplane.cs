using System;

namespace ISP
{
    public class Airplane : IVehicle
    {
        public void Drive()
        {
            throw new System.NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("arirplane is flyong");
        }
    }
}