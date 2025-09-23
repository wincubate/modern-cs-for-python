MathOperation m = SimpleMath.Multiply;
m += SimpleMath.Add;
m(5, 7);

//foreach( Delegate d in m.GetInvocationList() )
//{
//   Console.WriteLine( "Method Name: {0}", d.Method );
//   Console.WriteLine( "Type Name: {0}", d.Target );
//}

delegate void MathOperation(int i, int j);

class SimpleMath
{
    public static void Add(int i, int j)
    {
        Console.WriteLine("{0} + {1} = {2}", i, j, i + j);
    }

    public static void Multiply(int i, int j)
    {
        Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
    }
}
