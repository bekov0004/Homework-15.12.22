public class Rectange
{
    public double With;
    public double Height;
    public string Color;

    public double GetArea()
    {
          double s;
          s = With*Height;
          return s;
    }

    public double GetPerimeter()
    {
        double p;
        p = 2*( With+ Height);
        return p;
    }
}