using System;

    class Progam {
     public static void Main (string[] args)
        {
            Addition();
            Subtraction();
            Multiplication();
            Division();
            DecDivision();
            Modulus ();
        }

        public static void Addition()
        {
                        Console.WriteLine("provide a number for the addition operation:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + " is a great choice. now choose another number:");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = a + b;
            Console.WriteLine("another great choice!! the addition operation with these 2 inputs would be " + a + " + " + b + " = " + result);
        }

        public static void Subtraction()
        {
                        Console.WriteLine("now, provide a number for the subtraction operation:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("there is no number better than " + c + ". now another one:");
            int d = Convert.ToInt32(Console.ReadLine());
            int result = c - d;
            Console.WriteLine("the subtraction operation with these 2 inputs would be " + c + " - " + d + " = " + result);
        }

        public static void Multiplication()
        {
            Console.WriteLine("now, provide a number for the multiplication operation:");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("i think " + e + " is perfect. another one:");
            int f = Convert.ToInt32(Console.ReadLine());
            int result = e * f;
            Console.WriteLine("the multiplication operation with these 2 inputs would be " + e + " x " + f + " = " + result);
        }

        public static void Division()
        {
            Console.WriteLine("provide a number for the division with integers operation:");
            int g = Convert.ToInt32(Console.ReadLine()!);
            Console.WriteLine("one more:");
            int h = Convert.ToInt32(Console.ReadLine()!);
            int result = g / h;
            Console.WriteLine("the division operation with these 2 inputs would be " + g + " / " + h + " = " + result);
        }

         public static void DecDivision()
        {
            Console.WriteLine("provide a number for the division with decimals operation:");
            double i = Double.Parse(Console.ReadLine()!);
            Console.WriteLine("aaaaand again:");
            double j = Double.Parse(Console.ReadLine()!);
            double result = i / j;
            Console.WriteLine("the division operation with these 2 inputs would be " + i + " / " + j + " = " + result);
        }

        public static void Modulus()
        {
            Console.WriteLine("inally we are almost done!! provide a number for the modulus operation:");
            int k = Convert.ToInt32(Console.ReadLine()!);
            Console.WriteLine("ONE LAST ONEEEE");
            int l = Convert.ToInt32(Console.ReadLine()!);
            int result = k % l;
            Console.WriteLine("the modulus operation with these 2 inputs would be " + k + " % " + l + " = " + result);
        }
    }
