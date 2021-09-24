namespace AbstractClasses
{

    public class Dodge : Vehicle
    {
        public override void Drive()
        {
            System.Console.WriteLine("The Dodge is driving");
        }

          public override void Alarm(){
          System.Console.WriteLine("This Dodge alarm is off");  
        }

         public override void hasCamera() { 
             System.Console.WriteLine("The Dodge has a camera");
             }
    }
}