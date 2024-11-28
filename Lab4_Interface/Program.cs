﻿using System;


class Solution
{
    static void testAPlusBSquare<T>(T a, T b) where T : IMyNumber<T>
    {
        Console.WriteLine("=== Starting testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
        T aPlusB = a.Add(b);
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("(a + b) = " + aPlusB);
        Console.WriteLine("(a+b)^2 = " + aPlusB.Multiply(aPlusB));
        Console.WriteLine(" = = = ");
        T curr = a.Multiply(a);
        Console.WriteLine("a^2 = " + curr);
        T wholeRightPart = curr;
        curr = a.Multiply(b); // ab
        curr = curr.Add(curr); // ab + ab = 2ab
                               // I’m not sure how to create constant factor "2" in more elegant way,
                               // without knowing how IMyNumber is implemented
        Console.WriteLine("2*a*b = " + curr);
        wholeRightPart = wholeRightPart.Add(curr);
        curr = b.Multiply(b);
        Console.WriteLine("b^2 = " + curr);
        wholeRightPart = wholeRightPart.Add(curr);
        Console.WriteLine("a^2+2ab+b^2 = " + wholeRightPart);
        Console.WriteLine("=== Finishing testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
    }

    static void testSquaresDifference<T>(T a, T b) where T : IMyNumber<T>
    {
        Console.WriteLine("=== Starting testing (a-b)=(a^2-b^2)/(a+b) with a = " + a + ", b = " + b + " ===");
        T aMinusB = a.Subtract(b);
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("(a - b) = " + aMinusB);
        T a2Minusb2 = a.Multiply(a).Subtract(b.Multiply(b));
        Console.WriteLine("(a^2-b^2) = " + a2Minusb2);
        T aPlusB = a.Add(b);
        Console.WriteLine("(a+b)= " + aPlusB);
        Console.WriteLine("(a^2-b^2) / (a+b) = " + a2Minusb2.Divide(aPlusB));
        Console.WriteLine(" = = = ");
              
        Console.WriteLine("=== Finishing testing (a-b)=(a^2-b^2)/(a+b) with a = " + a + ", b = " + b + " ===");
    }

    static void Main(string[] args)
    {
        testAPlusBSquare(new MyFrac(1, 3), new MyFrac(1, 6));
        testAPlusBSquare(new MyComplex(1, 3), new MyComplex(1, 6));
        testSquaresDifference(new MyFrac(1, 3), new MyFrac(1, 6));
        testSquaresDifference(new MyComplex(1, 3), new MyComplex(1, 6));

        MyFrac[] arr =
        {
            new(2,3), new(5,2), new(-6, 7), new(-20, 9), new(1, 20), new(64, 8)
        };

        Array.Sort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i].ToString() + " ");
        }
    }
}