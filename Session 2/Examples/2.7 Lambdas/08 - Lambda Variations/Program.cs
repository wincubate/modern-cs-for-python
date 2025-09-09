Func<double> vat = () => 25.0;
Console.WriteLine($"Denmark's VAT is {vat()}%");

Func<int,string,bool> alwaysTrue = (_, _) => true;

Func<bool, object> choose = (bool b) => b ? 1 : "two";
Console.WriteLine(choose(false));



