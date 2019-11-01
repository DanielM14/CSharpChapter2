using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            string color = "Red";
            string wordEndingEst = "Baddest";
            string bodyPartPlural = "Arms";
            string anAnimal = "Sheeps";
            string aNoun = "Banana";
            string pluralNoun = "Apples";
            int a = 10;
            int b = 5;
            int c;

            c = a - b;

            Console.WriteLine("The " + color + " Dragon is the " + wordEndingEst + " Dragon of all." + " It has " + c 
                + bodyPartPlural + ", and a " + anAnimal + ", shaped like a " + aNoun + ". It loves to eat " + pluralNoun + ", although it will feast on nearly anything.");

        }
    }
}
