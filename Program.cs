using System;
using System.Security.Cryptography.X509Certificates;

namespace taskss2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string value1 = "35";
            //string value2 = "12";
            //if (Value(value1))
            //{
            //    Console.WriteLine(value1);
            //}
            //else
            //{
            //    Console.WriteLine("tam eded deyil");
            //}
            //if (Value(value2))
            //{
            //    Console.WriteLine(value2);
            //}
            //else
            //{
            //    Console.WriteLine("tam eded deyil");
            //}
            //Console.WriteLine(value1+value2);



            //static bool Value(string value)
            //{
            //    int result;
            //    return int.TryParse(value, out result);
            //}
            //static int Sum(int value1, int value2)
            //{
            //    return value1+value2;
            //}

            Car car = new Car();
            {
                car.Model="SClass";
                car.Brand = "Mercedes";
                car.CurrentFuel = 3;
                car.FuelFor1Km = 1;
                car.Millage = 150;
                car.Drive = 10;

                Car car1 = new Car(30.0);
                Car.Drive(20.0);
            }
            public void Drive(int drive)
            {
                if (drive >= FuelFor1Km)
                {
                    drive-=CurrentFuel
                }
                else
                {
                    Console.WriteLine("benzin kifayet etmir");
                }
            }




            

        }

      
        
    }
    class Car
    {
        public string Model;
        public string Brand;
        public double CurrentFuel;
        public double FuelFor1Km;
        public double Millage;
        public int Drive;
    }
}
