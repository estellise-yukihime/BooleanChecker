namespace BooleanChecker;

public static class CheckerExtension
{
    private static readonly Checker Checker = new Checker();
    
    public static bool IsTrue(this bool value)
    {
        return Checker.IsTrue(value);   
    }
    
    public static bool IsFalse(this bool value)
    {
        return Checker.IsFalse(value);
    }
}