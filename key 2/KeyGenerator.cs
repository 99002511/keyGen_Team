using System;
using System.Collections.Generic;
using System.Text;

namespace KeyGen
{
    interface IKeyGenerator
    {
        public int RandomKey(int min, int max);
    }
    class KeyGenerator:IKeyGenerator
{
    /// <summary>
    /// Random Key  Generator
    /// it gets min and max value as parameter and return a Random number
    /// </summary>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <returns></returns>

    public int RandomKey(int min, int max)
    {
        Random ran = new Random();
        int a = ran.Next(min, max);
        return a;
    }
};
}
