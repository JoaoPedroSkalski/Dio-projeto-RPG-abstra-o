using System;
using RPG.src.Entities;

namespace RPG.src
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knigth");
            Wizard Mago = new Wizard("Jenica", 23, "White Wizard");
            BlackWizard MagoNegro = new BlackWizard("Topapa", 23, "Black Wizard");
            Ninja ninja = new Ninja("Wedge", 23, "Ninja");


            Console.WriteLine(Mago.attack(6));
            Console.WriteLine(arus.attack(2));
            Console.WriteLine(MagoNegro.attack(6));
            Console.WriteLine(ninja.attack(3));
        }
    }
    




}