using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    public class Triangle
    {
        public string IsItTriangle(int Side1,int Side2,int Side3)
        {
            if(Side1 +Side2 > Side3  && Side2 +Side3 > Side1 && Side1 +Side3 > Side2)
            {
                    if(Side1 ==Side2 &&Side1==Side3)
                {
                    return "Equilateral";
                }
                    else if( Side1 ==Side2 ||Side1 ==Side3||Side3 ==Side2)
                {
                    return "Isoceles"; 
                }                
                else 
                {
                    return "Scalene";
                }    
            }
        
            return "Not a Triangle";
            

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
