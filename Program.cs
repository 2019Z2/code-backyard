using System;
using System.Linq;

namespace AgeOrAnd
{
	public static class Program
	{
		public static void Main()
		{
int age, exp;
Console.WriteLine("Enter your work xp in yrs:");
exp=int.Parse(Console.ReadLine());
Console.WriteLine("Age in yrs:");
age=int.Parse(Console.ReadLine());
if ((exp>=5) || (age>=35) && (age<=45))
Console.WriteLine("May be accepted. Get in touch with HR.");
else
Console.WriteLine("Unemployed under age &&/|| expercy grounds");
		}
	}
}