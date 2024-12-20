﻿namespace SyntaxSugarDemoCSharp_53;

class Program
{
    static void Main(string[] args)
    {
        //Explicit typingint
        int number = 10;
        string word;

        //Inferrred typing
        var myVariable = "word";

        //Inline if statement (ternary operator)

        var age = 33;
        
        Console.WriteLine(age >= 18 ? "You're an adult." : age < 5 ? "You're a child." : "You're a minor."); 
        
        //string interpolation vs concatenation

        var middleInitial = 'B';
        
        Console.WriteLine($"Bryseida {middleInitial} Hernandez");
        Console.WriteLine("Bryseida" + " " + middleInitial + " Hernandez");
    } 
}
