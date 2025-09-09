int i = 87;
object o1 = i; // Boxing
Console.WriteLine(o1.ToString());

//object o2 = i;
//Console.WriteLine(o1 == o2);

int j = (int) o1; // Unboxing
Console.WriteLine(++j);
