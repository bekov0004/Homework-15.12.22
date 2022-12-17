public class Circle
{
   public const double PI =3.14;
   public double Radius;
   public string Color;

   public double GetArea()
   {
    double a;
    a = PI*Radius*Radius;
    return a;
   }

   public double  GetCircumference()
   {
      double c;
      c = 2*PI*Radius;
      return c;
   }
}