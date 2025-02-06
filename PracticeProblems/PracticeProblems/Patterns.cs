using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class Patterns
    {

        //****
        //****
        //****
        //****
        public static void Rectangle(int n)
        {
            for (int i = 0; i < n; i++)
            {                                        

                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //*
        //**
        //***
        //****
        public static void halfTriangle(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }
        // 1
        // 1 2
        // 1 2 3 
        // 1 2 3 4
        public static void halfNumTriangle(int n)
        {
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <=i; j++)
                    Console.Write(j);

                Console.WriteLine();
            }
        }

        //1
        //2 2
        //3 3 3
        //4 4 4 4 
        public static void halfNummTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(i);

                Console.WriteLine();
            }
        }

        //****
        //***
        //**
        //*
        public static void ReversePattern(int n) {
            for (int i = 0;i<n;i++) {
                for (int j = 0; j <n-i; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        //1 2 3 4
        //1 2 3
        //1 2
        //1
        public static void Reversenum(int n) {
            for (int i = 0; i < n; i++) {
                for (int j = 1; j <= n - i; j++) {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

    }
}
