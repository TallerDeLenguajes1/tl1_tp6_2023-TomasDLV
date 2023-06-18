Console.WriteLine("Hello, World!");
float a;
float b;
a=10;
b=a;
string s = "108";
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
if (float.TryParse(s,out a))
{
    if (a > 0)
    {
        Console.WriteLine(a);
        Console.WriteLine(1/a);    
    }
}