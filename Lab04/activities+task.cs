using System;

class Program{
    static void Main(string[] args){
        Program z=new Program();
        Console.WriteLine("Activities");
        Console.WriteLine("Activity 1");
        z.oned();
        Console.WriteLine("Activity 2");
        z.twod();
        Console.WriteLine("Activity 3");
        z.Array();
        Console.WriteLine("Exercise");
        Console.WriteLine("Exercise 1");
        Task1();
        Console.WriteLine("Exercise 2");
        Task2();
        Console.WriteLine("Exercise 3");
        
        Console.WriteLine("Exercise 4");
        Task4();
        Console.WriteLine("Exercise 5");
        Task5();
     



    }
    public void twod()
    {
        int[,] numbers2d = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
        foreach (int i in numbers2d) {
            Console.WriteLine(i);
        } }
         public void oned()
          {
            int[] nums = { 1, 2, 3, 4, 5 };
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

          }
    public void Array() 
    {
        string[] days = {"sunday","monday","tuesday","wednesday","thursday","friday","saturday","sunday" };
        PrintArray(days);
        changeArrayElements(days);
        Changearray(days);

    }
    public void PrintArray(string[] array)
    {
        foreach (string day in array)
        {
            Console.WriteLine(day);
        }
    }
    public void changeArrayElements(string[] array)
    {
        Console.WriteLine("After change Array Elements : ");
        array[0] = "sat";
        array[1] = "tues";
        array[2] = "monday";
        PrintArray(array);
    }
    public void Changearray(string[] array)
    {
        Console.WriteLine("After Reverse : ");
        array =(array.Reverse()).ToArray();
        PrintArray(array);    }
    static void Task1()
    {
        int[,] numbers2D = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        Print2DArray(numbers2D);
    }

    static void Print2DArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Task2()
    {
        string[] s = { "hello ", "and ", "welcome ", "to ", "this ", "demo! " };
        string merge=string.Concat(s);
        Console.WriteLine(merge);
    }
    static void Task4()
    {
        int[] ratings = { 5, 4, 3, 5, 2, 1, 4, 5, 5, 3, 2, 4, 3, 5, 4, 2, 1, 1, 5, 4,
                          3, 5, 5, 4, 3, 2, 1, 5, 4, 3, 5, 5, 2, 1, 5, 4, 3, 5,
                          5, 4, 3, 5 };

        int[] frequency = new int[5];
        foreach (int rating in ratings)
        {
            frequency[rating - 1]++;
        }

        for (int i = 0; i < frequency.Length; i++)
        {
            Console.WriteLine($"Response {i + 1} given by: {frequency[i]} people");
        }
    }
    static void Task5()
    {
        Console.WriteLine("Enter a decimal number:");
        int decimalNumber = int.Parse(Console.ReadLine());
        string binaryNumber = ConvertToBinary(decimalNumber);
        Console.WriteLine($"Binary of {decimalNumber} is: {binaryNumber}");

        Console.WriteLine("Enter a binary number:");
        string binaryInput = Console.ReadLine();
        int decimalFromBinary = ConvertFromBinary(binaryInput);
        Console.WriteLine($"Decimal of {binaryInput} is: {decimalFromBinary}");
    }

    static string ConvertToBinary(int number)
    {
        return Convert.ToString(number, 2);
    }

    static int ConvertFromBinary(string binary)
    {
        return Convert.ToInt32(binary, 2);
    }
}

