﻿using System;

//Não precisa do using pois foi colocado a classe DateTimeExtensions no namespace System
//using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 02, 05, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
