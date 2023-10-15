// SplitterTests/SplitterTests.cs
using MySplitterLibrary;
using Xunit;

public class MySplitterTests
{
    [Fact]
    public void SplitAmount_EqualAmountAndPeople_ReturnsAmountPerPerson()
    {
        // Arrange
        var splitter = new Splitter();
        decimal amount = 100;
        int numberOfPeople = 5;

        // Act
        decimal result = splitter.SplitAmount(amount, numberOfPeople);

        // Assert
        Assert.Equal(20, result);
    }

    [Fact]
    public void SplitAmount_ZeroAmount_ReturnsZeroPerPerson()
    {
        // Arrange
        var splitter = new Splitter();
        decimal amount = 0;
        int numberOfPeople = 4;

        // Act
        decimal result = splitter.SplitAmount(amount, numberOfPeople);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void SplitAmount_DecimalAmountAndPeople_ReturnsCorrectPerPerson()
    {
        // Arrange
        var splitter = new Splitter();
        decimal amount = 123.45M;
        int numberOfPeople = 3;

        // Act
        decimal result = splitter.SplitAmount(amount, numberOfPeople);

        // Assert
        Assert.Equal(41.15M, result);
    }
}
