using System;
using System.Collections;
using System.IO;
using System.Text.Json;
using System.Linq;
using KeyGen;

namespace MyApplication
{

    public static class Globals
    {

        public static int flag_g = 0;
        public static int flag1 = 0;
        public static int flag2 = 0;
    }
    

 
    /// <summary>
    /// This proram will generate a random number with given number of size.and with given conditions.
    /// </summary>
    class MyApplication
    {

        static void Main(string[] args)
        {
            //Reading input from the file

                var FileOp = new FileRead();
                var userInputVal = FileOp.ReaderInput();
  
            var digi_check = new Counts_Digits();//instance of Counts_Digit
            var key = new KeyGenerator();//instance of KeyGenerator()
            var digi_r = new digits_twister();//instance of digits_twister

            Console.WriteLine("The Size is: ");
            Console.WriteLine(userInputVal.size);
            int ran_first = digi_r.rand_digits(userInputVal.size);//generating random number
            //Console.WriteLine("First random: "+ ran_first);

            //Reading the second line for "digit should not start with"

            Console.WriteLine("Characters shouldn't start with: ");
            foreach (var val in userInputVal.digit1_not)
                Console.WriteLine(val);
            digi_check.Digi_Counter(userInputVal.digit1_not);
          //  digi_check.Digi_special(userInputVal.digit1_not);

            Console.WriteLine("Characters shouldn't end with: ");
            foreach (var val in userInputVal.digit2_not)
                Console.WriteLine(val);
            digi_check.Digi_Counter(userInputVal.digit2_not);
            //digi_check.Digi_special(userInputVal.digit2_not);

            while (Globals.flag_g == 0)
            {

                var digi_rever = new rand_reverse();
                ArrayList array_reverse = new ArrayList();
                array_reverse = digi_rever.reverse_digiter(ran_first);
                // Console.WriteLine("size" + array_reverse.Count);

                var compar_oper = new comparator_value();
                var compar_oper1 = new comparator_value();

                ArrayList array_compareval = new ArrayList();
                array_compareval = compar_oper.comparors(userInputVal.digit1_not, array_reverse, 1);//comparing digit 1 with the generated random number.
                ArrayList array_compareval1 = compar_oper1.comparors(userInputVal.digit2_not, array_reverse, 2);//comparing digit 2 with the generated random number.

                ran_first = FileOp.IfElseComparator(userInputVal.size,ran_first);

            }
            Console.WriteLine("Finished key generation: " + ran_first);//Printig the final genrated random number.
        }
    };

}
