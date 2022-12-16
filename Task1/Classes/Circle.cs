public class Circle
{
   public const double pi =3.14;
   public double radius;
   public string color;

   public double GetArea()
   {
    double a;
    a = pi*radius*radius;
    return a;
   }

   public double  GetCircumference()
   {
      double c;
      c = 2*pi*radius;
      return c;
   }
}