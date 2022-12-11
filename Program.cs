//WorkWithIntegers();
OrderPrecedence();
TestLimits();
DoubleType();

void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);


    // subtraction
    c = a - b;
    Console.WriteLine(c);

    // multiplication
    c = a * b;
    Console.WriteLine(c);

    // division
    c = a / b;
    Console.WriteLine(c);
}

void OrderPrecedence()
{
    int a = 7;
    int b = 4;
    int c = 3;
    int d = (a + b) / c;
    int e = (a + b) % c;
    Console.WriteLine($"quotient: {d}");
    Console.WriteLine($"remainder: {e}");
    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"The range of the integers is {min} to {max}");
    int what = max + 3;
    Console.WriteLine($"An example of overflow: {what}");
}

void TestLimits()
{
    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"The range of the integers is {min} to {max}");
    int what = max + 3;
    Console.WriteLine($"An example of overflow: {what}");
}

void DoubleType()
{
    double a = 5;
    double b = 4;
    double c = 2;
    double d = (a + b) / c;
    Console.WriteLine(d);
//more complicated;
    double e = 19;
    double f = 23;
    double g = 8;
    double h = (e + f) / g;
    Console.WriteLine(h);
//scientific notation;
    double max = double.MaxValue;
    double min = double.MinValue;
    Console.WriteLine($"The range of double is {min} to {max}");
    double third = 1.0 / 3.0;
    Console.WriteLine(third);
//decimals
    decimal Min = decimal.MinValue;
    decimal Max = decimal.MaxValue;
    Console.WriteLine($"The range of the decimal type is {Min} to {Max}");
    double a1 = 1.0;
    double b1 = 3.0;
    Console.WriteLine(a1 / b1);
    decimal c1 = 1.0M;
    decimal d1 = 3.0M;
    Console.WriteLine(c1 / d1);
    //using pi
    double Radius=2.50;
    double pi=Math.PI;
    double area =pi*(Radius*Radius);
    Console.WriteLine(area);
}
