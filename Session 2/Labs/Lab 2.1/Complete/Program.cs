using ModernCs.Lab1_1;

Employee se = new SoftwareEngineer("John", "Doe", 25763);
Employee sa = new SoftwareArchitect("Jane", "Doe", 176);

Console.WriteLine(sa);
Console.WriteLine(se);
sa.Work();
se.Work();
Console.WriteLine(sa);
Console.WriteLine(se);
