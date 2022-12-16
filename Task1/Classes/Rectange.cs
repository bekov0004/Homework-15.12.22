public class Rectange
{
    public double with;
    public double height;
    public string color;

    public double GetArea()
    {
          double s;
          s = with*height;
          return s;
    }

    public double GetPerimeter()
    {
        double p;
        p = 2*( with+ height);
        return p;
    }
}