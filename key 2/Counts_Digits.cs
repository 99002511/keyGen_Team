using System;
using System.Collections;

namespace KeyGen
{
    interface ICounts_Digits
    {
        public void Digi_Counter(ArrayList digis);
    }
    class Counts_Digits : ICounts_Digits
    {
        /// <summary>
        /// DigitConter:
        /// this function will count the digits.if it is more than 3 digits program will show an error message and exit.
        /// </summary>
        /// <param name="digis"></param>
        public void Digi_Counter(ArrayList digis)
        {
            if (digis.Count > 3)
            {
                Console.WriteLine("Maximum three digits are accepted");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
        }
        public void Digi_special(ArrayList digits)
        {
                
            /*String digi_str = digits.ToString();
            char[] digi_char = digi_str.ToCharArray();

            for (int i = 0; i < digi_char.Length; i++)
            {
                Console.WriteLine("Characters: " + digi_char[i]);
                if (Char.IsLetter(digi_char[i]))
                {
                    Console.WriteLine("No Characters allowed in input");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                }

            }*/

        }
    }
}
