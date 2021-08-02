using System;

namespace RefOutArrayString
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Value, reference types

            #region Value types

            //int a = 5;
            //int b = a; // int b = 5;
            //b = 10;

            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");

            #endregion

            #region Reference Types

            //int[] arr = { 1, 2, 3 };
            //int[] arr1 = arr;

            //arr1[0] = 10;

            //foreach (int item in arr)
            //{
            //    Console.Write(item);
            //}

            //Console.WriteLine();

            //foreach (int item in arr1)
            //{
            //    Console.Write(item);
            //}

            #region Immutable type

            //string text = "Salam";
            //string text1 = text;

            //text1 = "Sagol";

            //Console.WriteLine($"Text = {text}");
            //Console.WriteLine($"Text1 = {text1}");

            #endregion

            #endregion

            #endregion

            #region Ref, out

            //int a = 10;
            //ChangeNumber(ref a);
            //Console.WriteLine($"A = {a}");

            //int b;
            //ChangeNumber2(out b);
            //ChangeNumber2(out int b);
            //Console.WriteLine($"B = {b}");

            //int[] arr = { 1, 2, 3 };
            //ChangeIndex(arr);
            //Console.WriteLine($"Arr[0] = {arr[0]}");

            #endregion

            #region String

            //string text = "  Salam     ";
            //Console.WriteLine(text.Length);
            //Console.WriteLine(text.ToUpper());
            //Console.WriteLine(text.ToLower());
            //Console.WriteLine(text.Trim());
            //Console.WriteLine(text.TrimStart());
            //Console.WriteLine(text.TrimEnd());

            //string names = "Elnur,Rail,Fagan";
            //string[] result = names.Split(",");
            //foreach (string item in result)
            //{
            //    Console.WriteLine(item + " P318");
            //}

            #endregion

            #region Return methods

            //Print("Rail");
            //Console.WriteLine(IsMarried("Rail"));

            #endregion

            #region Task 1

            //Console.WriteLine("Text-i daxil edin:");
            //string text = Console.ReadLine();

            //Console.WriteLine("Symbol-u daxil edin:");
            //char symbol = char.Parse(Console.ReadLine());

            //int result = FindCharCount(text, symbol);
            //Console.WriteLine($"Netice: {result}");

            #endregion

            #region Task 2

            //string result = Reverse("runlE");
            //Console.WriteLine(result);

            #endregion

            //Salam P318 Qrupu - malaS 813P upurQ
        }

        #region Ref, out

        static void ChangeIndex(int[] numbers)
        {
            numbers[0] = 10;
            Console.WriteLine($"Method numbers[0] = {numbers[0]}");
        }

        static void ChangeNumber(ref int number)
        {
            number = 50;
            Console.WriteLine($"Method number = {number}");
        }

        static void ChangeNumber2(out int number)
        {
            number = 50;
            Console.WriteLine($"Method number = {number}");
        }

        #endregion

        #region Return methods

        static bool IsMarried(string name)
        {
            return name != "Rail";
        }

        static void Print(string name)
        {
            if (name == "Rail")
            {
                Console.WriteLine($"Bye {name}");
                return;
            }
            Console.WriteLine("Hello " + name);
        }

        #endregion

        #region Task 1

        static int FindCharCount(string text, char symbol)
        {
            int count = 0;

            foreach (char item in text)
            {
                if (symbol == item)
                {
                    count++;
                }
            }

            return count;
        }


        #endregion

        #region Task 2

        static string Reverse(string text)
        {
            string result = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                result += text[i];
            }
            return result;
        }

        #endregion
    }
}
