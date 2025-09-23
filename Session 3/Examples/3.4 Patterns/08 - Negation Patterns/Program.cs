C c = new();
c.DoStuff("Hello world");
c.DoStuff(null);

class C
{
    public void DoStuff(object? o)
    {
        if (o is null)
        {
            throw new ArgumentNullException(nameof(o));
        }

        // Do stuff
    }
}
