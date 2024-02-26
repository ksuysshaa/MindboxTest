using Geometry.Calculator;
using Geometry.Calculator.Figures;

namespace Geometry.Tests;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void Ctor_ValidSides_CreatesTriangle()
    {
        // Arrange
        const double firstSide = 3;
        const double secondSide = 4;
        const double thirdSide = 5;
        
        // Act
        IFigure triangle = new Triangle(firstSide, secondSide, thirdSide);
        
        // Assert
        Assert.IsNotNull(triangle);
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "First side must be positive")]
    public void Ctor_InvalidFirstSide_ThrowsArgumentException()
    {
        // Arrange
        const double firstSide = -3;
        const double secondSide = 4;
        const double thirdSide = 5;
        
        // Act
        IFigure triangle = new Triangle(firstSide, secondSide, thirdSide);
        
        // No assert is needed, the ExpectedException attribute will handle the test
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Second side must be positive")]
    public void Ctor_InvalidSecondSide_ThrowsArgumentException()
    {
        // Arrange
        const double firstSide = 3;
        const double secondSide = -4;
        const double thirdSide = 5;
        
        // Act
        IFigure triangle = new Triangle(firstSide, secondSide, thirdSide);
        
        // No assert is needed, the ExpectedException attribute will handle the test
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Third side must be positive")]
    public void Ctor_InvalidThirdSide_ThrowsArgumentException()
    {
        // Arrange
        const double firstSide = 3;
        const double secondSide = 4;
        const double thirdSide = -5;
        
        // Act
        IFigure triangle = new Triangle(firstSide, secondSide, thirdSide);
        
        // No assert is needed, the ExpectedException attribute will handle the test
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "First side is greater than sum of others")]
    public void Ctor_FirstSideIsLessThanSumOfOthers_ThrowsArgumentException()
    {
        // Arrange
        const double firstSide = 10;
        const double secondSide = 4;
        const double thirdSide = 3;
        
        // Act
        IFigure triangle = new Triangle(firstSide, secondSide, thirdSide);
        
        // No assert is needed, the ExpectedException attribute will handle the test
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Second side is greater than sum of others")]
    public void Ctor_SecondSideIsLessThanSumOfOthers_ThrowsArgumentException()
    {
        // Arrange
        const double firstSide = 3;
        const double secondSide = 10;
        const double thirdSide = 4;
        
        // Act
        IFigure triangle = new Triangle(firstSide, secondSide, thirdSide);
        
        // No assert is needed, the ExpectedException attribute will handle the test
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Third side is greater than sum of others")]
    public void Ctor_ThirdSideIsLessThanSumOfOthers_ThrowsArgumentException()
    {
        // Arrange
        const double firstSide = 3;
        const double secondSide = 4;
        const double thirdSide = 10;
        
        // Act
        IFigure triangle = new Triangle(firstSide, secondSide, thirdSide);
        
        // No assert is needed, the ExpectedException attribute will handle the test
    }
    
    [TestMethod]
    public void CalculateArea_ValidSides_ReturnsArea()
    {
        // Arrange
        const double firstSide = 3;
        const double secondSide = 4;
        const double thirdSide = 5;
        const double expectedArea = 6;
        IFigure triangle = new Triangle(firstSide, secondSide, thirdSide);
        
        // Act
        var actualArea = triangle.CalculateArea();
        
        // Assert
        Assert.AreEqual(expectedArea, actualArea);
    }

    [TestMethod]
    public void IsRightAngled_RightAngledTriangle_ReturnsTrue()
    {
        // Arrange
        const double firstSide = 3;
        const double secondSide = 4;
        const double thirdSide = 5;
        const bool expectedResult = true;
        var triangle = new Triangle(firstSide, secondSide, thirdSide);

        // Act
        var actualResult = triangle.IsRightAngled();

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
    
    [TestMethod]
    public void IsRightAngled_RightAngledTriangle_ReturnsFalse()
    {
        // Arrange
        const double firstSide = 1;
        const double secondSide = 2;
        const double thirdSide = 3;
        const bool expectedResult = false;
        var triangle = new Triangle(firstSide, secondSide, thirdSide);

        // Act
        var actualResult = triangle.IsRightAngled();

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}