using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using taklif4;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace taklif4
{

    public abstract class Calculator   //this have one virtual methode
    {
        public abstract bool IsTrue(long n);
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
                //Console.WriteLine(numberin/10);
                //Console.WriteLine(result);
                if (result==numberin) 
                    return IsMirror=true;
                if (result == numberin / 10)
                    return true;
            }
            return IsMirror;    
            
        }
    }
    //public class Palindrome2 : Calculator
    //{
       
    //    public override bool IsTrue(long numberin)
    //    {
    //        bool IsMirror = false;
    //        long result = 0, n = 0, wres = numberin;

    //        while (wres != 0)
    //        {
    //            n++;
    //            wres /= 10;

    //        }
    //        long x = n / 2;

    //        while (numberin / Math.Pow(10, x) > 0)
    //        {
    //            long digit = numberin % 10;
    //            result = result * 10 + digit;
    //            numberin /= 10;
    //            //Console.WriteLine(numberin);
    //            //Console.WriteLine(result);
    //            if (result == numberin)
    //                return IsMirror = true;
    //        }
    //        return IsMirror;
    //    }
    //    }
    public class Fibonachi : Calculator
    {
        public override bool IsTrue(long number)
        {
            bool istrue = false;
            long a1 = 0, a2 = 1, l = 0;
            l = a1 + a2;
            while (l <= number)
            {
                if (l == number)
                {

                    istrue = true;
                    break;
                }
                a1 = l;
                l = l + a2;
                a2 = a1;

            }

            return istrue;
            
        }
       
        


    }
    public class DecisionTree : Calculator
    {
        public override bool IsTrue(long n = 0 )
        {
            bool x = false,final=false;
            int s=0,e=0;
            int midnumber = (0 +100)/2;
            s = midnumber;
            e= 100;
            while(true)
            {
                
                
                //while(midnumber ==1)
                //{
                //    Console.WriteLine($"is your number {s}");
                //    if (Keyboard.GetYorN())
                //    {
                //        Console.WriteLine($" your number is:\t{s}");
                //        final = true;
                //        break;
                //    }
                //    else
                //        s++;
                        
                //}
                if (final==true) 
                    break;
                Console.WriteLine($"is your number beet win {s} to {e}");
                x = Keyboard.GetYorN();
                if ( x == true )
                {
                    midnumber /= 2;
                    s += midnumber;
                    while (midnumber == 1)
                    {
                        Console.WriteLine($"is your number {s}");
                        if (Keyboard.GetYorN())
                        {
                            Console.WriteLine($" your number is:\t{s}");
                            final = true;
                            break;
                        }
                        else
                            s++;

                    }
                }//37 50//43 50 
                
                else
                {
                    e = s;
                    s-= midnumber*2;
                    //midnumber/=2;
                    s += midnumber;
                    midnumber/=2;
                    while (midnumber == 1)
                    {
                        Console.WriteLine($"is your number {s}");
                        if (Keyboard.GetYorN())
                        {
                            Console.WriteLine($" your number is:\t{s}");
                            final = true;
                            break;
                        }
                        else
                            s++;

                    }
                }//25 50 //40 43




            }
            

            return true; 
        }



      
    }
}
public static class CalculatorFactory
{
    public static Calculator calfactory (char gethomekey ,bool lenght)
    {
        switch (gethomekey)
        {
            case 'A':
                {
                    if(!lenght)
                        return new SPrime();
                    else
                        return new PPrime();

                }
                
            case 'B':
                return new Palindrome1();
            case 'C':
                return new Fibonachi();
            case 'D':
                return new DecisionTree();
            default:
                throw new NotImplementedException("you sed a wrong number");
        }
    }
    

}
