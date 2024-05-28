using System;
using System.Text;
using lab1;

var r1 = new Rational(2, 3);
var r2 = new Rational(-5, -2);

Console.WriteLine(r1.ToString());
Console.WriteLine(r2.ToString());

Console.WriteLine(r1 + r2);
Console.WriteLine(r1 - r2);
Console.WriteLine(r1 * r2);
Console.WriteLine(r1 / r2);

Console.WriteLine(-r1);

Console.WriteLine(r1 == r2); 
Console.WriteLine(r1 != r2); 
Console.WriteLine(r1 < r2);
Console.WriteLine(r1 <= r2); 
Console.WriteLine(r1 > r2); 
Console.WriteLine(r1 >= r2);

