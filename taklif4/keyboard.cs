using System;
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
        public int GetNumber()
        {
            Console.WriteLine("*******************\rplease enter number\r******************* ");
            char R='a';
            int r=int.MinValue;
            string result = "";
            
            do
            {

                R =Console.ReadKey(true).KeyChar;

                while (  char.IsNumber(R))
                {
                    result = result + R;
                    r *=10;
                    r += R - '0'; 
                    R = Console.ReadKey(true).KeyChar;
                    
                  
                }
                Console.WriteLine(result);
                if (R!=27)
                    Console.WriteLine("you dont enter a num if you wana exit press esc");
            } while (R != 27);
            Console.WriteLine("********\ryou are quit the code\r*******");
            return r;
        }
        public char GetYorN()
        {
            while (true)
            {
                Console.WriteLine("*******************\rplease press Y :for yes or N : for no\r***********************");
                char input = char.MinValue;
                input = char.ToUpper(Console.ReadKey(true).KeyChar);
                if (input == 'Y'|| input=='N')
                {
                    return input;
                }
               
            }
        }
        public char GetHomekey ()
        {
            while (true)
            {
                int n = 0;
                if(n== 0)   
                    Console.WriteLine("*************************\rplease enter\r*********************************\n\rH : for goto main page\n\rA : for goto simple prime for numbers under 1000\n\rB : for numbers biger than 1000\n\rC : for cheke mirror number \n\rD : for idk    ");
                char input = char.MinValue;
                input=char.ToUpper(Console.ReadKey(true).KeyChar);
                if (input == 'H' || input == 'A' || input == 'B' || input == 'C' || input == 'D')
                    return input;
                else
                {
                    Console.WriteLine("please enter right format");
                    n++;
                }
                    




            }





            
        
        }
    }
    
    public class Cons
    {   
        public  void ColorChange ( ConsoleColor x , string tex )
        {
            Console.ForegroundColor = x;
            Console.WriteLine(tex);
            Console.ForegroundColor= ConsoleColor.White;

        }
        public void ConForm(List<string> form , int indexnum)
        {
            foreach (string s in form) { 
                string start  = (s.Substring(0, indexnum)).ToUpper();
                Console.WriteLine($" {start}______{s , 8} :  \n\r   ");
            }


        }

    }
    
}
