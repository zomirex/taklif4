using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace taklif4
{

    public class Calculator   //this have one virtual methode
    {
        public virtual bool IsTrue(long n)
        {
            return false;
        }



    }
    public class SPrime : Calculator
    {
        public override bool IsTrue(long number)
        {
            bool IsprimeNumber = true;
            long value = Convert.ToInt32(Math.Sqrt(number));
            if (number % 2 == 0)
            {
                IsprimeNumber = false;

                return IsprimeNumber;
            }
            for (long i = 3; i <= value; i = i + 2)
            {
                if (number % i == 0)
                {
                    IsprimeNumber = false;

                    break;
                }


            }
            if (IsprimeNumber)
            {
                return IsprimeNumber;
            }
            else
            {
                return IsprimeNumber;
            }

        }
    }
    public class PPrime : Calculator
    {
        static List<int> primes = new List<int>();
        public List<int> getprime()
            { return primes; }
        public override bool IsTrue(long number)
        {
            bool IsprimeNumber = true;
            int n = 1000;
            int m = 10000000;
            
            int condition;

            

            for (int i = 2; i < n; i++)
            {
                IsprimeNumber = true;
                condition = Convert.ToInt32(Math.Sqrt(i));
                for (int j = 2; (IsprimeNumber && j <= Math.Sqrt(i)); j++)
                    if (i % j == 0)
                        IsprimeNumber= false;

                if (IsprimeNumber)
                    primes.Add(i);

            }

            for (int i = n + 1; i < m; i++)
            {
                IsprimeNumber = true;
                condition = Convert.ToInt32(Math.Sqrt(i));
                for (int j = 0; (IsprimeNumber && primes[j] <= condition); j++)
                    if (i % primes[j] == 0)
                        IsprimeNumber = false;

                if (IsprimeNumber)
                {
                   // Console.Write("{0} ", i);
                    primes.Add(i);
                }
            }

            return IsprimeNumber;
        }
    }
    public class Palindrome1 : Calculator
    {
        public override bool IsTrue(long numberin)
        {
            bool IsMirror= false;   
            long  result=0,n=0, wres=numberin;
            
            while (wres != 0)
            {
                n++;
                wres /= 10;
                
            }
            long x = n / 2;

            while (numberin/Math.Pow(10,x)>0)
            {
                long digit = numberin % 10;
                result = result * 10 + digit;
                numberin /= 10;
                //Console.WriteLine(numberin);
                //Console.WriteLine(result);
                if (result==numberin) 
                    return IsMirror=true;
            }
            return IsMirror;    
            
        }
    }
    public class Palindrome2 : Calculator
    {
    }
}

