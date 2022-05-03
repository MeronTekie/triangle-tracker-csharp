using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    public class Triangle
    {
        public bool IsItTriangle(int Side1,int Side2,int Side3)
        {
            if(Side1 +Side2 > Side3  && Side2 +Side3 > Side1 && Side1 +Side3 > Side2)
            {
                if( Side1 ==Side2 ||Side1 ==Side3||Side3 ==Side2)
                {
                    return true; 
                } 
                else 
                {
                    return false;
                }    
            }
        
            return false;
            

        }
        // static void Main()
        // {
        //     Console.WriteLine("Hi, enter a string below")  ;
        //     // int Side1= ""
        //     string input = Console.ReadLine();
        //     Console.WriteLine(input);
        // }
    }
}
