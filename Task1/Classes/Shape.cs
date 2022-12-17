public class Shape
{
   public string Color = "Red"; 
   public string Name = "Mouse"; 
   public int PositionX = 10;
   public int PositionY = 23;

   public void GetPosition(){
     System.Console.WriteLine($" PositionX = {PositionX} \n PositionY = {PositionY}");
   }
   public void GetFullInfo(){
    System.Console.WriteLine($" Name = {Name} \n color = {Color} \n PositionX = {PositionX} \n PositionY = {PositionY} \n");
   }
}