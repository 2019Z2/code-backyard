
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp120123
{
    Class Program
    {
       int num;
    Console.Write("enter a number between 1-99");
    num=int.Parse(Console.ReadLine());
    if ((num %7==10) || (num/10==7) || (num%10==7))
    Console.WriteLine("Boom!"); 
         
        }
    }