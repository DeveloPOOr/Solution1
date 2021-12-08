using System;
using System.Text;

namespace ConsoleApp1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var vigen = new Vigenere();
            var hex = new Hex();
            Console.Write("Введите текст для шифра Виженера: ");
            var text = Console.ReadLine();
            Console.Write("Введите кодовое слово для шифра Виженера: ");
            var key = Console.ReadLine();
            Console.WriteLine("Виженер: " + vigen.toVigenere(text, key));
            Console.WriteLine("Hex: " + hex.toHex(text));
            Console.WriteLine("Из Виженера : " + vigen.fromVigenere(vigen.toVigenere(text, key), key));
            Console.WriteLine("Из хекс: "+ hex.fromHex(hex.toHex(text)));

        }

        
    }
}