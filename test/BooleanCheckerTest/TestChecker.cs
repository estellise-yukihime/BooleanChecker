using BooleanChecker;

namespace BooleanCheckerTest;

public class TestChecker
{
    private readonly Checker _checker = new Checker();

    [Fact]
    public void TestIsTrue()
    {
        // arrange
        var value = true;
        
        // act
        var actual = _checker.IsTrue(value);
        
        // assert
        Assert.True(actual);
    }

    [Fact]
    public void TestIsFalse()
    {
        // arrange
        var value = false;

        // act
        var actual = _checker.IsTrue(value);
        
        // assert
        Assert.False(actual);
    }
}
