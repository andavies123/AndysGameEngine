namespace AndysGameEngineLibrary.Test;

[TestClass]
public class Vector3Tests
{
	[TestMethod]
	public void AdditionOperator_ReturnsCorrectValue()
	{
		// Arrange
		Vector3 a = new(10, 15, 20);
		Vector3 b = new(5, 10, 15);
		Vector3 expected = new(15, 25, 35);
		
		// Act
		Vector3 result = a + b;
		
		// Assert
		result.Should().Be(expected);
	}

	[TestMethod]
	public void SubtractionOperator_ReturnsCorrectValue()
	{
		// Arrange
		Vector3 a = new(10, 15, 20);
		Vector3 b = new(5, 10, 15);
		Vector3 expected = new(5, 5, 5);
		
		// Act
		Vector3 result = a - b;
		
		// Assert
		result.Should().Be(expected);
	}

	[TestMethod]
	public void MultiplicationOperator_ReturnsCorrectValue()
	{
		// Arrange
		Vector3 a = new(10, 15, 20);
		Vector3 b = new(5, 10, 15);
		Vector3 expected = new(50, 150, 300);
		
		// Act
		Vector3 result = a * b;
		
		// Assert
		result.Should().Be(expected);
	}

	[TestMethod]
	public void IsEqualToOperator_ReturnsCorrectValue_True()
	{
		// Arrange
		Vector3 a = new(10, 15, 20);
		Vector3 b = new(10, 15, 20);
		const bool expected = true;
		
		// Act
		bool result = a == b;
		
		// Assert
		result.Should().Be(expected);
	}

	[TestMethod]
	public void IsEqualToOperator_ReturnsCorrectValue_False()
	{
		// Arrange
		Vector3 a = new(10, 15, 20);
		Vector3 b = new(13, 12, 21);
		const bool expected = false;
		
		// Act
		bool result = a == b;
		
		// Assert
		result.Should().Be(expected);
	}
}