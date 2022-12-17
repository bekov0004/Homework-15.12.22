System.Console.WriteLine();
System.Console.WriteLine($"Object Rectange");
Rectange areaPeri = new Rectange();
areaPeri.With=4;
areaPeri.Height=15;
Console.WriteLine($" Area = {areaPeri.GetArea()}"); 
Console.WriteLine($" Perimeter = {areaPeri.GetPerimeter()}");

System.Console.WriteLine();
System.Console.WriteLine($"Object Circle");
Circle areaCircum = new Circle();
areaCircum.Radius=2.5;
Console.WriteLine($" Area = {areaCircum.GetArea()}");
Console.WriteLine($" Circumference = {areaCircum.GetCircumference()}");

System.Console.WriteLine();
System.Console.WriteLine($"Object Shape");
Shape positioninfo = new Shape();
positioninfo.GetPosition();
positioninfo.GetFullInfo();
