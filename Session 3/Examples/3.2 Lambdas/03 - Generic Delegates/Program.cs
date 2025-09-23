GenericDelegate<int> del1 = ActionHelper.IntTarget;
del1(87);
GenericDelegate<string> del2 = ActionHelper.StringTarget;
del2("booyah");

public delegate void GenericDelegate<T>(T arg);
//public delegate void GenericDelegate2<T>(T arg);

class ActionHelper
{
    public static void StringTarget(string arg)
    {
        Console.WriteLine("arg in uppercase is: {0}", arg.ToUpper());
    }
    public static void IntTarget(int arg)
    {
        Console.WriteLine("++arg is: {0}", ++arg);
    }
}
