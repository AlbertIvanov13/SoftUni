﻿using System.Security.Cryptography.X509Certificates;

namespace GenericArrayCreator
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");

            int[] integers = ArrayCreator.Create(10, 33);
        }
    }
}