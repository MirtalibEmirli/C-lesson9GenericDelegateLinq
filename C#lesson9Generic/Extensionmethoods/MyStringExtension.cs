
namespace C_lesson9Generic.Extensionmethoods;

public static class MyStringExtension
{

    public static int Countlines(this string input) => input.Split(Environment.NewLine).Length;
    //{ return input.Split(Environment.NewLine).Length; } ///belede yazlr
    // {return input.Split(' ').Length}
}
