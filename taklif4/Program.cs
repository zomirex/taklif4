using System.Security.Cryptography;
using taklif4;
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
                    long number =start.GetNumber(  lenght: out  lenght,pagename:"**\t**\tPRIME NUMBER\t**\t**");
                    if(lenght==false)            
                          calculator = new SPrime();
                    else
                          calculator = new PPrime();
                    Console.WriteLine($"\n\rthe number :{number}       is prime :{calculator.IsTrue(number)} \n");
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
                    

                    long number = start.GetNumber(lenght:out lenght, pagename :"**\t**\tMIRRORE NUMBER\t**\t**"  );
                    if (lenght == false)
                        calculator = new Palindrome1();
                    else
                        calculator = new Palindrome2();
                   
                    Console.WriteLine($"\nthe number :{number}       is palindrome :     {calculator.IsTrue(number)} \n");
                    continu = start.GetYorN();
                    Console.Clear();
                }
                Console.Clear();
                Console.WriteLine("\r\ryou gonao goto the home page\r\r");
                

                break ;


            }
        
             
         
           



            
       
    }
    
}
Console.WriteLine("Bye Bye");






