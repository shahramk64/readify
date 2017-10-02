using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Readify
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Readify" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Readify.svc or Readify.svc.cs at the Solution Explorer and start debugging.
    public class Readify : IReadify
    {
        public Guid Token()
        {
            Guid token = new Guid("03748b40-22e2-484d-a252-ba1315b5b0d5");
            return token;
        }

        public long Fibonacci(long n)
        {
            if (n >= 0)
            {
                if (n == 0)
                    return 0;
                else if (n == 1)
                    return 1;
                else
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            else
            {
                n = -n;
                if ((n % 2) == 0)
                    return (-Fibonacci(n));
                else
                    return Fibonacci(n);
            }
        }


        public string ReverseWords(string s)
        {
            string reversed = "";
            if (s.Length == 0)
                return "";
            string[] words = s.Split(' ');
            foreach (var word in words)
            {
                for (int i=word.Length-1; i >=0; i--)
                {
                    reversed += word[i];
                }
                reversed += " ";
            }
            return reversed;
        }

        public TriangleTypes TriangleType(int a, int b, int c)
        {
            //Check if the triangle exist
            if (a <= 0 || b <= 0 || c <= 0)
                return TriangleTypes.Error;
            if((a + b <= c) || (a + c <= b) || (c + b <= a))
                return TriangleTypes.Error;

            //Check for being equilatteral
            if (a == b && a == c)
                return TriangleTypes.Equilateral;

            //Check for being isosceles
            if (a == b || a == c || b == c)
                return TriangleTypes.Isosceles;

            //Check for being scalene
            if (a != b && a != c && b != c)
                return TriangleTypes.Scalene;

            //This line will never be reached, but necessary for the compiler
            return TriangleTypes.Error;
        }


    }
}
