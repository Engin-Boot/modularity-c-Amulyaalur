using System;
using System.Collections.Generic;
using System.Text;
using TelCo.ColorCoder;

namespace TelCo.ColorCoder
{
    class manual
    {

     public static void Tostring()
        {
            int number = 0;
            for(int i = 1; i < Colors.colorMapMinor.Length; i++)
            { 
                for(int j = 1; j < Colors.colorMapMinor.Length; j++)
                {
                    Console.Write("[In]Pair Number: {0}", ++number);
                Colors.ColorPair testPairs= new Colors.ColorPair() { majorColor = Colors.colorMapMajor[i], minorColor = Colors.colorMapMinor[j]};
                    Console.WriteLine("[Out] Colors: {0}\n", testPairs);
                 
                }
            }

        }



    }
}
