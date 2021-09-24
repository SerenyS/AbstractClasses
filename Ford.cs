namespace AbstractClasses
{

    public class Ford : Vehicle
    {
        public string Color { get; set; }

        public override void Drive()
        {
            System.Console.WriteLine("The Ford is driving");
        }
//Assignment 
        public override void Alarm(){
          System.Console.WriteLine("This Ford alarm is on");  
        }

         public override void hasCamera() { 
             System.Console.WriteLine("The Ford has a camera");
             }

        public override void Start()
        {
            System.Console.WriteLine("The Ford has started");
        }

        public override void ShowColor()
        {
            Make = "Ford";
            Model = "Probe";
            Color = "Tan";

            System.Console.WriteLine($"The color is {Color}");

        }
    }
}