using System;
using System.Collections;

namespace KeyGen
{
    interface Irand_reverse
    {
        public ArrayList reverse_digiter(int inputnum);
    }
    class rand_reverse : Irand_reverse
{
    /// <summary>
    /// This function will parse the interger data into array list. the data will be in reverse manner. 
    /// </summary>
    /// <param name="inputnum"></param>
    /// <returns></returns>
    public ArrayList reverse_digiter(int inputnum)
    {
        int i = 0, m;
        ArrayList reverse_array = new ArrayList();
        while (inputnum > 0)
        {
            m = inputnum % 10;
            reverse_array.Add(m);
            inputnum = inputnum / 10;
            i++;
        }
        return reverse_array;
    }
};
}
