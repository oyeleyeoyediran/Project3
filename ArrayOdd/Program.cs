using System;

namespace Trial
{
public class Exercise
{
   public static void Main( )
    {
    //     Console.WriteLine("Enter the amount of celsius: "); 
    //     int c = Convert.ToInt32(Console.ReadLine());
 
    //     Console.WriteLine("Kelvin = {0}" ,c + 273);
    //     Console.WriteLine("Fahrenheit ={0} ", c * 18 / 10 + 32);

    //     int number1, number2, temp;
    //         Console.Write("Input the First Number : ");
    //         number1 = int.Parse(Console.ReadLine());
    //         Console.Write("Input the Second Number : ");
    //         number2 = int.Parse(Console.ReadLine());
    //         temp = number1;
    //         number1 = number2;
    //         number2 = temp;
    //         Console.Write("After Swapping : ");
    //         Console.Write("First Number : "+number1);
    //         Console.Write("Second Number : "+number2);
    //         Console.Read();


    //     int a, b, c, d;
    //     Console.WriteLine("enter a value:");
    //     a = Convert.ToInt32(Console.ReadLine());

    //     Console.WriteLine("enter b value:");
    //     b = Convert.ToInt32(Console.ReadLine());
    //     for (d = 1; d <=b; d++)
    //     {
    //         c = a * d;
    //       Console.WriteLine("{0}*{1}={2}",a,d,c);

        

    //     string line = "Display the pattern like pyramid using the alphabet.";
    //     Console.WriteLine("\nOriginal String: " + line);
    //      string result = "";
    //     List < string > wordsList = new List < string > ();
    //     string[] words = line.Split(new [] {
    //     " "
    //     }, StringSplitOptions.None);
    //     for (int i = words.Length - 1; i >= 0; i--) {
    //     result += words[i] + " ";
    //     }
    //     wordsList.Add(result);
    //     foreach(String s in wordsList) {

    //     Console.WriteLine("\nReverse String: " + s);
    //     }


    //          for (int i = 0; i <= 9; i++)
    //     {
    //         Console.Write(i + "\t");
    //         for (int j = 1; j <= 9; j++)
    //         {
    //             if (i > 0) Console.Write(i * j + "\t");
    //             else Console.Write(j + "\t");
    //         }
    //         Console.Write("\n");



    //     }
    //     Console.ReadKey();
    //     {
    //     Console.Write("Input  a number(integer): ");
    //     int n = Convert.ToInt32(Console.ReadLine());
    //     int sum = 0;
    //     while (n != 0) {
    //     sum += n % 10;
    //     n /= 10;
    //     }
    //     Console.WriteLine("Sum of the digits of the said integer: " + sum);
    //     }
        // {
        // int num1, num2;
     
        // Console.Write("Input the first number to multiply: ");
        // num1 = Convert.ToInt32(Console.ReadLine());
     
        // Console.Write("Input the second number to multiply: ");
        // num2 = Convert.ToInt32(Console.ReadLine());
     
        // int result = num1 * num2;
        // Console.WriteLine("Output: {0} x {1} = {2}", num1, num2, result);
        // }
    }    
        // public static void MultiplicationOfNumbers()
        // {
        // int num1, num2;
        
        // Console.Write("Input the first number to multiply: ");
        // num1 = Convert.ToInt32(Console.ReadLine());
        
        // Console.Write("Input the second number to multiply: ");
        // num2 = Convert.ToInt32(Console.ReadLine());
        
        // int result = num1 * num2;
        // Console.WriteLine("Output: {0} x {1} = {2}", num1, num2, result);
        // }
       
        // public static void SubtractionOfNumbers()
        // {
        // int num1, num2;
        
        // Console.Write("Input the first number to multiply: ");
        // num1 = Convert.ToInt32(Console.ReadLine());
        
        // Console.Write("Input the second number to multiply: ");
        // num2 = Convert.ToInt32(Console.ReadLine());
        
        // int result = num1 - num2;
        // Console.WriteLine("Output: {0} - {1} = {2}", num1, num2, result);
        // }
        // public static void AddtionOfNumbers()
        // {
        // int num1, num2;
        
        // Console.Write("Input the first number to multiply: ");
        // num1 = Convert.ToInt32(Console.ReadLine());
        
        // Console.Write("Input the second number to multiply: ");
        // num2 = Convert.ToInt32(Console.ReadLine());
        
        // int result = num1 + num2;
        // Console.WriteLine("Output: {0} + {1} = {2}", num1, num2, result);
        // }
        // public static void DivisionOfNumbers()
        // {
        // int num1, num2;
        
        // Console.Write("Input the first number to multiply: ");
        // num1 = Convert.ToInt32(Console.ReadLine());
        
        // Console.Write("Input the second number to multiply: ");
        // num2 = Convert.ToInt32(Console.ReadLine());
        
        // int result = num1 / num2;
        // Console.WriteLine("Output: {0} / {1} = {2}", num1, num2, result);
        // }

        //      public static void Character()
        //     {
        //         Console.WriteLine(remove_char("CodeLearners", 1));
        //         Console.WriteLine(remove_char("CodeLearners", 3));
        //         Console.WriteLine(remove_char("CodeLearners", 5));     
        //     }
        //    public static string remove_char(string str, int n)
        //     {
        //         return str.Remove(n, 5);
        //     }

        
        // public static void Pst()
        // {
        //     Console.WriteLine(test("abcd"));
        //     Console.WriteLine(test("a"));
        //     Console.WriteLine(test("xy"));
        //     Console.ReadLine();
        // }


        // public static string test(string str)
        // {
        //     return str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        // }   
        // public static void Value()
        // {
        //     Console.WriteLine(SumTriple(2,2));
        //     Console.WriteLine(SumTriple(12,10));
        //     Console.WriteLine(SumTriple(-5,2));          
        // }
        // public static int SumTriple(int a, int b)
        // {
        //     return a == b ? (a + b)*3 : a + b;
        // }

        //          public static void Array()
        //         {
        //         int[] first_array = {1, 3, -5, 4};
        //         int[] second_array = {1, 4, -5, -2};
            
        //         Console.WriteLine("\nArray1: [{0}]", string.Join(", ", first_array));
        //         Console.WriteLine("Array2: [{0}]", string.Join(", ", second_array));
            
        //         Console.WriteLine("\nMultiply corresponding elements of two arrays: ");
            
        //      for (int i = 0; i < first_array.Length; i++){
        //         Console.Write(first_array[i] * second_array[i]+" ");
        //         }
        //         Console.WriteLine("\n");
        //    }
        //          public static void Number()
        //         {
        //            Console.WriteLine("\nInput first integer:");  
        //            int x = Convert.ToInt32(Console.ReadLine());
        //          if (x > 0)
        //            {
        //             Console.WriteLine(x % 3 == 0 || x % 7 == 0);
        //            }
        //         }
        // public static void Number()
        // {
        // Console.WriteLine("\nInput first integer:");  
        // int x = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Input second integer:");  
        // int y = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Input third integer:");  
        // int z = Convert.ToInt32(Console.ReadLine());
                    
        // Console.WriteLine("Largest of three: "+Math.Max(x, Math.Max(y, z)));
        // Console.WriteLine("Lowest of three: "+Math.Min(x, Math.Min(y, z)));
        // }
        // public static void String() 
        // {
        // Console.Write("Input a string : ");
        // string str = Console.ReadLine();
        // var result = string.Empty;
        // for (var i = 0; i < str.Length; i++)
        //     {
        //     if (i % 2 == 0) result += str[i];
        //     }
        // Console.WriteLine(result);
        // }

        //  public static void Main() 
        // {     
        //  int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
        //  Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
        //  var sum = 0;
        //     for (var i = 0; i < nums.Length; i++)
        //     {
        //         sum += nums[i];
        //     }
        //    Console.WriteLine("Sum: "+ sum);
        // }
        
         
        //     public static void Main() 
        // {   
        //     int[] nums1 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
        //     Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums1));
        //     int[] nums2 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5};
        //     Console.WriteLine("\nArray2: [{0}]", string.Join(", ", nums2));
            
        //     Console.WriteLine("\nCheck if the first element or the last element of the two arrays ( length 1 or more) are equal.");
        //     Console.WriteLine((nums1[0].Equals(nums2[0])) || (nums1[nums1.Length - 1].Equals(nums2[nums2.Length - 1])));
        // }
    
        //      public static void Main() 
        //   {
        //      int[] nums = {2, 4, 7, 8, 6};
        //      Console.WriteLine("\nOriginal array: [{0}]", string.Join(", ", nums));
        //      Console.WriteLine("Check if an array contains an odd number? "+even_odd(nums));
        //   }  
            
        //     public static bool even_odd(int[] nums)  
        //     {
        //         foreach (var n in nums)
        //             {
        //                 if (n % 2 != 0) 
        //                 return true;
        //             }
        //         return false;'
                
        // }  

        // public static int centuryFromYear(int year)
        // {
        //     return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
        // }

        // public static void Main()
        // {
        //     Console.WriteLine(centuryFromYear(1799) == 18);
        //     Console.WriteLine(centuryFromYear(1900) == 19);
        //     Console.WriteLine(centuryFromYear(1901) == 19);
        //     Console.WriteLine(centuryFromYear(1901) == 20);
        //     Console.WriteLine(centuryFromYear(1806) == 19);
        //     Console.WriteLine(centuryFromYear(1568) == 20);
        //     Console.WriteLine(centuryFromYear(2010) == 21);
        // }

        // public static void Main() 
        // {
        //     int[] arr1 = new int[10];
        //     int n, i, j, tmp;
            
            
        //     Console.Write("\n\nSort elements of array in ascending order :\n");
        //     Console.Write("----------------------------------------------\n");	

        //     Console.Write("Input the size of array : ");
        //     n = Convert.ToInt32(Console.ReadLine()); 

        //     Console.Write("Input {0} elements in the array :\n",n);
        //     for(i=0;i<n;i++)
        //         {
        //         Console.Write("element - {0} : ",i);
        //         arr1[i] = Convert.ToInt32(Console.ReadLine());  
        //         }

        //     for(i=0; i<n; i++)
        //     {
        //     for(j=i+1; j<n; j++)
        //     {
        //     if(arr1[j] < arr1[i])
        //         {
        //     tmp = arr1[i];
        //     arr1[i] = arr1[j];
        //     arr1[j] = tmp;
        //         }
        //         }
        //         }
        //     Console.Write("\nElements of array in sorted ascending order:\n");
        //     for(i=0; i<n; i++)
        //     {
        //         Console.Write("{0}  ", arr1[i]);
        //     }
        //     Console.Write("\n\n");	
        // }

        //  public static void Main()
        // {
        //         int[] nums = { 1, 3, 5, 7, 9 };
        //     int n = 6;
        //     Console.WriteLine(test(nums, n));
        //     n = 3;
        //     Console.WriteLine(test(nums, n));
        // }
        // public static bool test(int[] arra, int n)
        // {
        //     return arra.Contains(n);
        // }
        
    }
}