using System;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Collections;
using MyApplication;

namespace KeyGen
{
    class UserInput
    {
        public int size { get; set; }
        public ArrayList digit1_not { get; set; }
        public ArrayList digit2_not { get; set; }
    }
    class FileRead
{
    public UserInput ReaderInput()
    {
        StreamReader ReaderFile = new StreamReader(@"C:\Users\CTEA\Documents\input.json");
 

            string str = ReaderFile.ReadToEnd();

            try
            {
                JsonSerializer.Deserialize<UserInput>(str);
            }
            catch (Exception e)
            {

                Console.WriteLine("Invalid File Input: Check Json");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            var userInputVal = JsonSerializer.Deserialize<UserInput>(str);
            return userInputVal;
    }

    public int IfElseComparator(int size, int ran_first)
    {
        var digi_r1 = new digits_twister();

        if (Globals.flag1 == 1)//checking if digit1 matches with generated random number 
        {
            ran_first = digi_r1.rand_digits(size);
            Globals.flag1 = 0;
        }
        else if (Globals.flag2 == 1)//checking if digit2 matches with generated random number 
        {
            ran_first = digi_r1.rand_digits(size);
            Globals.flag2 = 0;
        }
        else//exiting the loop
        {
            Globals.flag_g = 1;
            Console.WriteLine("else");
        }
        return ran_first;
    }
}
}
