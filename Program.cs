using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Ford ford = new Ford();
            ford.Start();
            ford.Drive();
            ford.ShowColor();
            ford.Alarm();
            ford.hasCamera();

            Dodge dodge = new Dodge();
            dodge.Start();
            dodge.Drive();
            dodge.ShowColor();
            dodge.Alarm();
            dodge.hasCamera();




        }
    }
}
