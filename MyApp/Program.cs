using System;
using System.Security.Cryptography.X509Certificates;
class Program
{
     static void pattern()
        {
            
        int n=5;
        int k=1;
        for(int i = 1; i <= n; i++)
        {
            for(int j =1 ; j<=i ; j++)
            {
                Console.Write(k);
                k++;
            }
            
            Console.WriteLine();
        }
        }
    static void countDigits()
    {
        // count digits
        Console.WriteLine("Enter number");
        int num=Convert.ToInt32(Console.ReadLine());
        int result=0;
        while(num!=0){
          // int last_digit=num%10;
          result++;
          num=num/10;
          // result=(result*10)+last_digit;
          
        }
        Console.WriteLine(result);
    }
    static void RevNum()
    {
        Console.WriteLine("Enter number");
        int num=Convert.ToInt32(Console.ReadLine());
        int result=0;
        while(num!=0){
          int last_digit=num%10;
          result++;
          num=num/10;
          result=(result*10)+last_digit;
          
        }
        Console.WriteLine(result);
    }
    static void Palindrome()
    {
        
        Console.WriteLine("Enter number");
        int num=Convert.ToInt32(Console.ReadLine());
        int result=0;
        int temp=num;
        while(num!=0){
          int last_digit=num%10;
          num=num/10;
          result=(result*10)+last_digit;
          
        }
        if (result == temp)
        {
        Console.WriteLine("palindrome yes");
        }
        else
        {
        Console.WriteLine("palindrome No");
            
        }
    }
    static void GCD(int a,int b)
    {
        while (b != 0)
        {
            int temp=b;
            b=b%a;
            a=temp;
        }
        Console.WriteLine(a);
    }
    static void armStrong()
    {
        int num=1634;
       int power = (int)Math.Log10(num) + 1; 
       int result=0;
       int temp=num;
        while(num!=0){
          int last_digit=num%10;
          result=Convert.ToInt32(result+Math.Pow(last_digit,power));
          num/=10;
      }
      if(result==temp){
        Console.WriteLine("armstromg");
      }
      else{
        
        Console.WriteLine(" not armstromg");
      }
    }`
    public static void Main(string[] args)
    {
        // Console.WriteLine("BAcK!");
        // pattern();
        // countDigits();
        // RevNum();
        // Palindrome();
    //    GCD(45,5);

    }
}