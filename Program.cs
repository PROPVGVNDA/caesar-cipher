using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            // example
            string test = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            int numberToShift = 3;
            string result = CipheredString(test, numberToShift);
            Console.WriteLine(result);
        }

        // inp - String to encrypt
        // numberToShift - number of positions to rotate to left by alphabet

        public static string CipheredString(string inp, int numberToShift)
        {
            var builder = new StringBuilder(); // initialize a StringBuilder to build an encrypted string
            char newLetter; // temp variable to assign encrypted character to
            foreach(var ch in inp)
            {

                // if character is a space, then add space to builder, and go to next iteration
                if (Convert.ToInt32(ch) == 32)
                {
                    builder.Append(' ');
                    continue;
                }

                // if char in ascii table will be less then A, calculations are made from letter X(90 in ascii table)
                if (Convert.ToInt32(ch) - 3 < 65)
                {
                    newLetter = Convert.ToChar((90 + Convert.ToInt32(ch) - 65 - (numberToShift - 1)));
                    builder.Append(newLetter);
                    continue;
                }
                newLetter = Convert.ToChar(Convert.ToInt32(ch) - numberToShift);
                builder.Append(newLetter);
            }
            return builder.ToString();
        }
    }
}
