public class Shape
{
   public string color = "Red"; 
   public string Name = "Mouse"; 
   public int PositionX = 10;
   public int PositionY = 23;

   public void GetPosition(){
     System.Console.WriteLine($" PositionX = {PositionX} \n PositionY = {PositionY}");
   }
   public void GetFullInfo(){
    System.Console.WriteLine($" Name = {Name} \n color = {color} \n PositionX = {PositionX} \n PositionY = {PositionY} \n");
   }
}