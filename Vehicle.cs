namespace AbstractClasses
{
    //Create a new abstract method
    //Create a new virtual method
    //Implement  in two of your concrete classes
    public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public abstract void Alarm();
        public abstract void Drive();
        public virtual void ShowColor() { }

        public virtual void hasCamera() {
            System.Console.WriteLine("The vehicle has no Camera");
         }

        public virtual void Start()
        {
            System.Console.WriteLine("The vehicle has started");
        }

        public virtual void Stop()
        {
            System.Console.WriteLine("The vehicle is stopped");
        }

    }
}
