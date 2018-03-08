﻿using System;

namespace NameInProgress.Runner
{
    /// <summary>
    /// Temporary project, for testing.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Program started...");
            var builder = NameInProgressBuilder
                .GetClasses()
                .WithName().EqualTo("LowerFilter")
                .Build();
            var classes = builder.Execute(typeof(Strinken.Parser.IToken).Assembly.Location);
            foreach (var @class in classes)
            {
                Console.WriteLine(@class.ToString());
            }
        }
    }
}