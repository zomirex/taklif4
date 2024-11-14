using System.Security.Cryptography;
using taklif4;
using static System.Runtime.InteropServices.JavaScript.JSType;
Keyboard start =new Keyboard();
bool lenght=false;

char gethomekey = char.MinValue;
while (gethomekey != 27) 
{
    Calculator calculator;
    bool continu = true;
    Console.WriteLine("************\t HELLO \t************");
    Console.ForegroundColor = ConsoleColor.Blue;
    gethomekey = start.GetHomekey(); // get home key always  is upper case letter

    Console.ForegroundColor = ConsoleColor.White;

    switch (gethomekey)
    {
        case 'A':
            {
               
                while(continu)
                { Console.Clear();
                    long number2 =start.GetNumber(  lenght: out  lenght,pagename:"**\t**\tPRIME NUMBER\t**\t**");
                    
                    if(lenght==false)
                    { calculator = new SPrime();
                        int number1 = Convert.ToInt32(number2);
                        Console.WriteLine($"\n\rthe number :{number1}       is prime :{calculator.IsTrue(number1)} \n");
                    }
                         
                    else
                    {
                        calculator = new PPrime();
                        Console.WriteLine($"\n\rthe number :{number2}       is prime :{calculator.IsTrue(number2)} \n");

                    }

                          
                    continu = start.GetYorN();
                    
                }

                Console.WriteLine("\r\ryou gonao goto the home page\r\r");
                Console.Clear();
                break;
            }
        case 'B':
            {


                
                while (continu)
                {
                    

                    long number1 = start.GetNumber(lenght:out lenght, pagename :"**\t**\tMIRRORE NUMBER\t**\t**"  );
                    int number2= Convert.ToInt32(number1);
                    if (lenght == false)
                    {calculator = new Palindrome1();
                     Console.WriteLine($"\nthe number :{number1}       is palindrome :     {calculator.IsTrue(number1)} \n");
                    }

                    else
                    { 
                        calculator = new Palindrome2();
                        Console.WriteLine($"\nthe number :{number2}       is palindrome :     {calculator.IsTrue(number2)} \n");
                    }
                       
                   
                    
                    continu = start.GetYorN();
                    Console.Clear();
                }
                Console.Clear();
                Console.WriteLine("\r\ryou gonao goto the home page\r\r");
                

                break ;


            }
        case 'C':
            {
                while (continu)
                {
                    Console.Clear();
                    long number2 = start.GetNumber(lenght: out lenght, pagename: "**\t**\tfibonachi NUMBER\t**\t**");
                    calculator = new Fibonachi();    
                    int number1 = Convert.ToInt32(number2);
                    Console.WriteLine($"\n\rthe number :{number1}       is in fibonachi :{calculator.IsTrue(number1)} \n");
                    

                    


                    continu = start.GetYorN();

                }

                Console.WriteLine("\r\ryou gonao goto the home page\r\r");
                Console.Clear();

                break ;
            }
             
         
           



            
       
    }
    
}
Console.WriteLine("Bye Bye");






