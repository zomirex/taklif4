﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace taklif4
{
    public class Keyboard   // this have 4 methode to get specific value frome user
    {
        public static long GetNumber(string pagename,out bool lenght)
        {
            lenght = false;
            Console.WriteLine($" {pagename}");
            Console.WriteLine("**************\tplease enter number\t************** ");
            char R='a';
            long r=0;
            string result = "";
            int validate = 0;
            do
            {

                R =Console.ReadKey(true).KeyChar;

                while (  char.IsNumber(R))
                {
                    result = result + R;
                    r *=10;
                    r += R - '0'; 
                    R = Console.ReadKey(true).KeyChar;

                    validate++;
                }
                //Console.WriteLine(result);
               
                if ((R!='y'||R!='Y'|| R != 'n' || R != 'N')&& validate>0)
                {
                    Console.WriteLine($"is  your number?????  {r}  \n\r if it is prees y \n\r if not press n");

                    R = Console.ReadKey(true).KeyChar;

                }
                if ((R == 'y' || R == 'Y') && validate > 0)
                    break;
                else if ((R =='n'||R=='N')&& validate>0)
                {
                    r = 0;
                    validate = 0;
                    Console.WriteLine("*********please enter number again********");
                }
                  
            } while (R != 'y' || R != 'Y' );
           
            if (r >= 1000) lenght = true;
            Console.WriteLine($"********\ryou are quit the code\r*******\n\r\ryour number is :  {r} and it is bigger than 1000 :{ lenght} ");
            return r;
        }
        public static bool GetYorN()
        {
            while (true)
            {
                
                Console.WriteLine("**********\tplease press Y :for yes\tor\tpress  N : for no\t************");
                char input = char.MinValue;
                input = char.ToUpper(Console.ReadKey(true).KeyChar);
                if (input == 'Y')
                {
                    return true;
                }
                else if(  input == 'N')
                {
                    return false;

                }
                       


            }
        }
        public static char GetHomekey (out string pagename)
        {
            pagename = "f";
                int n = 0;
                if(n== 0)   
                    Console.WriteLine("*************************\rplease enter\r*********************************\n\n\r***\tyou are in the Hmepage\t***\n\rA : for check the prime number\n\rB : for checke the palindome number\n\rC : for check the fibonachi number\n\rD : for decision tree\n\r\n\n \n\n for escape : press esc");
                char input = char.MinValue;
            char result;
            bool contin = false;
            do
            {
               
                switch(input = char.ToUpper(Console.ReadKey(true).KeyChar))
                {
                    case 'A':
                        {
                            pagename = "simple/pro prime";
                            result = 'A';
                            contin = false;
                            break;
                        }
                    case 'B':
                        {
                            pagename = "palindrom";
                            result = 'B';
                            contin = false;
                            break;
                        }
                    case 'C':
                        {
                            pagename = "fibunachi";
                            result = 'C';
                            contin = false;
                            break;
                        }
                    case 'D':
                        {
                            pagename = "decision tree";
                            result = 'D';
                            contin = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("please enter right format");
                            n++;
                            result =char.MinValue;
                            contin = true;
                            break;
                        }
                       
                }                            
            }while (contin);
            return result;
        }
    }
    
   
    
}
