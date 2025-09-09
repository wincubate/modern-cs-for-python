namespace ModernCs.Lab1_1;

class SoftwareArchitect(string firstName, string lastName, int drawingsCreated = 0)
    : Employee(firstName, lastName)
{
    protected int DrawingsCreated { get; private set; } = drawingsCreated;

    public override sealed string ToString()
    {
        return $"{base.ToString()} [{DrawingsCreated} drawings]";
    }

    public override void Work()
    {
        DrawingsCreated += 2;
    }
}