﻿using System.Numerics;
using System.Security.Cryptography;
using taklif4;
using static System.Runtime.InteropServices.JavaScript.JSType;

bool lenght=false;

char gethomekey = char.MinValue;
while (gethomekey != 27) 
{
    
    bool continu = true;
    Console.WriteLine("************\t HELLO \t************");
    Console.ForegroundColor = ConsoleColor.Blue;
    string pagemane = string.Empty;
    gethomekey = Keyboard.GetHomekey(out pagemane); // get home key always  is upper case letter

    Console.ForegroundColor = ConsoleColor.White;
    Calculator cal = CalculatorFactory.calfactory(gethomekey, lenght);
    long x = 0;
    while (continu)
    {
        Console.Clear();
        if (gethomekey != 'D')
            x = Keyboard.GetNumber(pagemane, out lenght);
        Console.Write($"\t\tis {pagemane} :{cal.IsTrue(x)} \n");
        Console.WriteLine(" do you wana quit??");
        continu = !Keyboard.GetYorN();

    }

    Console.Clear();

    /*                                   this is something beetwin abstract factory and methode factory
     *                                   taklif amirhossein naseh */ 
    //    switch (gethomekey)
    //    {
    //        case 'A':
    //            {

    //                while(continu)
    //                { Console.Clear();
    //                    long number2 =Keyboard.GetNumber(  lenght: out  lenght,pagename:"**\t**\tPRIME NUMBER\t**\t**");

    //                    if(lenght==false)
    //                    { calculator = new SPrime();
    //                        int number1 = Convert.ToInt32(number2);
    //                        Console.WriteLine($"\n\rthe number :{number1}       is prime :{calculator.IsTrue(number1)} \n");
    //                    }

    //                    else
    //                    {
    //                        calculator = new PPrime();
    //                        Console.WriteLine($"\n\rthe number :{number2}       is prime :{calculator.IsTrue(number2)} \n");

    //                    }

    //                    Console.WriteLine("if you wana continue ");
    //                    continu = Keyboard.GetYorN();

    //                }

    //                Console.WriteLine("\r\ryou gonao goto the home page\r\r");
    //                Console.Clear();
    //                break;
    //            }
    //        case 'B':
    //            {



    //                while (continu)
    //                {

    //                    Console.Clear();
    //                    long number1 = Keyboard.GetNumber(lenght:out lenght, pagename :"**\t**\tMIRRORE NUMBER\t**\t**"  );
    //                    int number2= Convert.ToInt32(number1);

    //                    calculator = new Palindrome1();
    //                     Console.WriteLine($"\nthe number :{number1}       is palindrome :     {calculator.IsTrue(number1)} \n");


    //                    //else
    //                    //{ 
    //                    //    calculator = new Palindrome2();
    //                    //    Console.WriteLine($"\nthe number :{number2}       is palindrome :     {calculator.IsTrue(number2)} \n");
    //                    //}


    //                    Console.WriteLine("if you wana continue ");
    //                    continu = Keyboard.GetYorN();
    //                    Console.Clear();
    //                }
    //                Console.Clear();
    //                Console.WriteLine("\r\ryou gonao goto the home page\r\r");


    //                break ;


    //            }
    //        case 'C':
    //            {
    //                Console.Clear();
    //                while (continu)
    //                {
    //                    Console.Clear();
    //                    long number2 = Keyboard.GetNumber(lenght: out lenght, pagename: "**\t**\tfibonachi NUMBER\t**\t**");
    //                    calculator = new Fibonachi();    
    //                    int number1 = Convert.ToInt32(number2);
    //                    Console.WriteLine($"\n\rthe number :{number1}       is in fibonachi :{calculator.IsTrue(number1)} \n");




    //                    Console.WriteLine("if you wana continue ");
    //                    continu = Keyboard.GetYorN();

    //                }

    //                Console.WriteLine("\r\ryou gonao goto the home page\r\r");
    //                Console.Clear();

    //                break ;
    //            }
    //        case 'D':
    //            {
    //                Console.Clear();
    //                Console.WriteLine("please choose number beetwin 0 to 100");

    //                calculator = new DecisionTree();
    //                while (continu)
    //                {
    //                    Console.Clear();
    //                    //Console.WriteLine($"is your number beet win {0} to {50}");
    //                    calculator.IsTrue(0 );
    //                    Console.WriteLine("\vif you wana continue ");
    //                    continu  = Keyboard.GetYorN();
    //                }

    //                Console.WriteLine("\r\ryou gonao goto the home page\r\r");
    //                Console.Clear();

    //                break;
    //            }







    //    }

}
//Console.WriteLine("Bye Bye");






