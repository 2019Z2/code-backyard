using System;
using System.Linq;
using System.Collections.Generic;

namespace BenDover
{
    public class OpH
    {         
      int day;
      Console.WriteLine("Enter a number between 1-7");
      day=int.Parse(Console(ReadLine()));
      switch(day);
      {
      	case 1:
      	Console.WriteLine("10:00-16:00");
      	break;
      	
      	case 2:
      	Console.WriteLine("12:00-16:00");
      	break;
      	
      	default:
      	Console.WriteLine("08:00-15:30");
      	break;
     
      }
    
   
      	
      }
    }
}