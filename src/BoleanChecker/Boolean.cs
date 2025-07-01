namespace BooleanChecker;

public class Boolean
{
    private static readonly Checker Checker = new Checker();

    public static bool IsTrue(bool value)
    {
        return Checker.IsTrue(value);
    }

    public static bool IsFalse(bool value)
    {
        return Checker.IsFalse(value);
    }
}