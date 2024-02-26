using Geometry.Calculator;
using Geometry.Calculator.Figures;

namespace Geometry.Tests;

[TestClass]
public class CircleTests
{
    [TestMethod]
    public void Ctor_ValidRadius_CreatesCircle()
    {
        // Assert
        const double radius = 5;
        
        // Act
        IFigure circle = new Circle(radius);
        
        // Assert
        Assert.IsNotNull(circle);
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Radius must be non-negative.")]
    public void Ctor_InvalidRadius_ThrowsArgumentException()
    {
        // Assert
        const double radius = -5;
        
        // Act
        IFigure circle = new Circle(radius);
        
        // No assert is needed, the ExpectedException attribute will handle the test
    }
    
    [TestMethod]
    public void CalculateArea_ValidRadius_ReturnsCorrectArea()
    {
        // Assert
        const double radius = 5;
        const double expectedArea = Math.PI * radius * radius;
        IFigure circle = new Circle(radius);
        
        // Act
        var actualArea = circle.CalculateArea();
        
        // Assert
        Assert.AreEqual(expectedArea, actualArea);
    }
}