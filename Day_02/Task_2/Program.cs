// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter Float value");
string i=Console.ReadLine();    
//float a=Convert.ToSingle(i);
//Console.WriteLine(a);
//float b=float.Parse(i);
//Console.WriteLine(b);
float c;
bool b1 = float.TryParse(i, out c);
Console.WriteLine($" result is {b1} and float value of c is {c}");

