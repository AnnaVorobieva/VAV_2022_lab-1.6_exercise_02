using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    class Program
    {
        /*Ввести с
клавиатуры предложение.Предложение представляет собой слова, разделенные
пробелом.Знаки препинания не используются. Составить программу, определяющую
является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома
– «А роза упала на лапу Азора»)*/

        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");

            
            string firstString = Console.ReadLine();

            
            string myString = firstString.Replace(" ", "");

            
            myString = myString.ToLower();

            

            if (myString == new string(myString.Reverse().ToArray()))

            {
                Console.Write("\nПредложение \n{0} \nпалиндром", firstString);
            }
            else
            {
                Console.Write("\nПредложение \n{0} \nне палиндром", firstString);
            }

            Console.ReadKey();
        }

    }
}
