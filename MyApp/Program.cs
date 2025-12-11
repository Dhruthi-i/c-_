
/*
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
    }
    static void printDivisors()
  {
    Console.Write("Enter a number: ");
    int n = int.Parse(Console.ReadLine());

    for(int i = 1; i * i <= n; i++)
    {
      if (n % i == 0)
      {
        Console.Write(i+" ");
        if (i != n/i)
        {
          Console.Write(n/i+" ");
        }
      }
    }
  }


    public static void Main(string[] args)
    {
        // Console.WriteLine("BAcK!");
        // pattern();
        // countDigits();
        // RevNum();
        // Palindrome();
        //  GCD(45,5);
        // armStrong();
        // printDivisors();

      
    }
}

*/

// using System;

// class Program
// {
//     static void PrintNumbers(int current, int n)
//     {
//         if (current < 0)
//             return;

//         Console.Write(current + " ");
//         PrintNumbers(current - 1, n);
//     }

//     static void Main()
//     {
//         int n = 10;
//         PrintNumbers(10, n);
//     }
// }

// Sum of first N numbers
// using System;
// class Program
// {
//   public static int sumOfNum(int i, int n)
//   {
//     if(n<i) return 0;

    
//     return n+sumOfNum(1,n-1);

//   }

  
//   public static void Main()
//   {
//     int n=5;
//     int result= sumOfNum(1,n);
//     Console.WriteLine(result);
//   }
// }

// Factorial of N numbers
// using System;
// class Program
// {
//   public static int factorial(int n)
//   {
//     if(n==1||n==0) return 1;
//     return n*factorial(n-1);
//   }
//   public static void Main()
//   {
//     Console.Write(factorial(5));
//   }
// }

	
// Reverse an array
// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] arr = { 1, 2, 3, 4, 5 };

//         Console.WriteLine("Original Array: " + string.Join(", ", arr));

//         // Built-in reverse
//         Array.Reverse(arr);

//         Console.WriteLine("Reversed Array: " + string.Join(", ", arr));
//     }
// }

// using System;

// class Program
// // {
// //     static void ReverseArray(int[] arr, int start, int end)
// //     {
// //         if (start >= end) return;

// //         int temp = arr[start];
// //         arr[start] = arr[end];
// //         arr[end] = temp;

// //         ReverseArray(arr, start + 1, end - 1);
// //     }

// //     static void Main()
// //     {
// //         int[] arr = { 1, 2, 3, 4, 5 };

// //         Console.WriteLine("Original Array: " + string.Join(", ", arr));

// //         ReverseArray(arr, 0, arr.Length - 1);

// //         Console.WriteLine("Reversed Array: " + string.Join(", ", arr));
// //     }
// // }


// // Check if a string is palindrome or not

// // using System;

// // class Program
// // {
// //     static bool IsPalindrome(string str, int left, int right)
// //     {
// //         if (left >= right) // base case
// //             return true;

// //         if (str[left] != str[right])
// //             return false;

// //         return IsPalindrome(str, left + 1, right - 1);
// //     }

// //     static void Main()
// //     {
// //         Console.Write("Enter a string: ");
// //         string input = Console.ReadLine();

// //         if (IsPalindrome(input, 0, input.Length - 1))
// //             Console.WriteLine("Palindrome");
// //         else
// //             Console.WriteLine("Not Palindrome");
// //     }
// // }

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter N: ");
//         int n = int.Parse(Console.ReadLine());

//         int a = 0, b = 1;

//         Console.WriteLine("Fibonacci numbers up to N:");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write(a + " ");

//             int next = a + b;
//             a = b;
//             b = next;
//         }
//     }
// }



