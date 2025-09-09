I obj = new B();
obj.DoStuff();

I.M();

interface I
{
    public static void M() => Console.WriteLine("I.M()");

    void DoStuff() => M();
}

class A : I
{
    public void DoStuff() => Console.WriteLine("A.Dostuff()");
}

class B : I
{
}
