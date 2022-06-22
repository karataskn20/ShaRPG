using Characters.Magic;
using Characters.Melee;
using ShaRPG.Characters;
using System;

namespace ShaRPG
{
    public static class Tools
    {
        public static void ColorfulWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void TypeSpecificColorfulCW(string message, Character type)
        {
            ConsoleColor color = ConsoleColor.White;

            switch (type)
            {
                case Fighter:
                    color = ConsoleColor.DarkYellow;
                    break;
                case Paladin:
                    color = ConsoleColor.Yellow;
                    break;
                case Rogue:
                    color = ConsoleColor.Gray;
                    break;
                case Wizard:
                    color = ConsoleColor.Blue;
                    break;
                case Necromancer:
                    color = ConsoleColor.DarkMagenta;
                    break;
                case Druid:
                    color = ConsoleColor.Green;
                    break;
                default:
                    color = ConsoleColor.White;
                    break;
            }

            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}