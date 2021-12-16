// See https://aka.ms/new-console-template for more information
using rpg_dotnet.scr.Entities;

    class Program
        {
            static void Main(string[] args)
            {
                Hero knight = new Hero("Arus", 23, "Knight");
                Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

                Console.WriteLine(wizard.Attack(1));
                Console.WriteLine(knight.Attack());
            }
        }