using System;
using Desafios.src.Entities;

namespace Desafios
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero1 = new Knight("Arus", 30, "Knight", 500, 80);
            WizardWrite hero2 = new WizardWrite("Jennica", 28, "White Wizard", 450, 70);
            WizardBlack hero3 = new WizardBlack("Topapa", 27, "Black Wizard", 400, 67);
            Ninja hero4 = new Ninja("Wedge", 32, "Ninja", 490, 75);
            
            System.Console.WriteLine();
            System.Console.WriteLine(hero1.Attack(16));
            System.Console.WriteLine();
            System.Console.WriteLine(hero2.Defense());
            System.Console.WriteLine();
            System.Console.WriteLine(hero3.Attack(20));
            System.Console.WriteLine();
            System.Console.WriteLine(hero4.Defense());
            System.Console.WriteLine();
        }
    }
}