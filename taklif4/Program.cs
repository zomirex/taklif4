using taklif4;

while(true)
{
    Console.WriteLine("Hello, World!");
    //this is a main file of homework
    Calculator palindrome1 = new Palindrome1();
    Console.WriteLine(palindrome1.IsTrue(123456654321));
    PPrime palindrome2 = new PPrime();
    Console.WriteLine(palindrome2.IsTrue(65198613298328956));
    //Console.WriteLine(palindrome2.getprime());
    //foreach ( int p in palindrome2.getprime())
    //{
    //    Console.WriteLine(p);
    //}
    Keyboard x = new Keyboard();

    Console.WriteLine(x.GetHomekey());

}







