using System;
using System.Collections.Generic;
using System.Text;

namespace KeyGen
{
    interface Idigits_twister
    {
        public int rand_digits(int size);
    }
    class digits_twister : Idigits_twister
    {
        /// <summary>
        /// Random Digits
        /// based on the size of user input it will generate random number
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public int rand_digits(int size)
        {
            int r_d = 0;
            var key = new KeyGenerator();
            switch (size)
            {
                case 1:
                    r_d = key.RandomKey(1, 10);
                    break;
                case 2:
                    r_d = key.RandomKey(10, 100);
                    break;
                case 3:
                    r_d = key.RandomKey(100, 1000);
                    break;
                case 4:
                    r_d = key.RandomKey(1000, 9999);
                    break;
                case 5:
                    r_d = key.RandomKey(10000, 99999);
                    break;
                case 6:
                    r_d = key.RandomKey(100000, 999999);
                    break;
                case 7:
                    r_d = key.RandomKey(1000000, 9999999);
                    break;
                case 8:
                    r_d = key.RandomKey(10000000, 99999999);
                    break;
                case 9:
                    r_d = key.RandomKey(10000000, 999999999);
                    break;
                default:
                    Console.WriteLine("Maximum 9 size is allowed");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                    break;


            }

            return r_d;

        }
    };
}
