namespace ModernCs.Lab1_1;

class SoftwareEngineer(string firstName, string lastName, int codeLineProduced = 0)
    : Employee(firstName, lastName)
{
    protected int CodeLinesProduced { get; private set; } = codeLineProduced;

    public override sealed string ToString()
    {
        return $"{base.ToString()} [{CodeLinesProduced} C# lines]";
    }

    public override void Work()
    {
        CodeLinesProduced += 487;
    }
}
