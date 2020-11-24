using System;
using System.Collections;
using MyApplication;

namespace KeyGen
{
    interface Icomparator_value
    {
        public ArrayList comparors(ArrayList dval, ArrayList dresult, int switcher);
    }
    class comparator_value : Icomparator_value
    {

        /// <summary>
        /// DigitComparor:
        /// this function will compare the digits whether they are same are not.
        /// </summary>
        /// <param name="dval"></param>
        /// <param name="dresult"></param>
        /// <param name="switcher"></param>
        /// <returns></returns>
        public ArrayList comparors(ArrayList dval, ArrayList dresult, int switcher)
        {

            int dval_len = dval.Count;
            int dresult_len = dresult.Count;
            ArrayList array_temp = new ArrayList();
            switch (switcher)
            {
                case 1:
                    for (int i = 0; i < dval_len; i++)
                    {
                        Console.WriteLine("loop1: " + dval[i] + "  " + dresult[dresult_len - 1]);
                        if (String.Equals(dval[i].ToString(), dresult[dresult_len - 1].ToString()))
                        //if (dval[i].Equals(dresult[dresult_len - 1]))
                        {
                            Console.WriteLine("got val1");
                            Globals.flag1 = 1;
                            return array_temp;
                        }
                    }

                    break;
                case 2:
                    for (int i = 0; i < dval_len; i++)
                    {
                        Console.WriteLine("loop2: " + dval[i] + "  " + dresult[0]);
                        if (String.Equals(dval[i].ToString(), dresult[0].ToString()))
                        //if (dval[i].Equals(dresult[0]))
                        {
                            Console.WriteLine("got val2");
                            Globals.flag2 = 1;
                            return array_temp;
                        }
                    }


                    break;
            }
            return array_temp;
        }
    };
}
