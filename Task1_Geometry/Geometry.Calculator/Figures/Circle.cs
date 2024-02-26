namespace Geometry.Calculator.Figures;

public class Circle: IFigure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Error. Radius must be greater than zero.");
        
        _radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(_radius,2);
    }
}