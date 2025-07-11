using FluentAssertions;

namespace POCTemplate.Tests;

public class UnitTest1
{
    /// <summary>
    /// Tests that a constant boolean value is true.
    /// </summary>
    [Fact]
    public void Test1()
    {
        // Arrange
        const bool expected = true;

        // Act

        // Assert
        expected.Should().BeTrue();
    }
}
