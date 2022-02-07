using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KEYBOARD_Efficiency_Program
{
    class Word
    {
        static char[] lette = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        static char[] lette2 = { 'A', 'B', 'B', 'C', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        static char[] left = { 'a', 'q', 'z', 'w', 's', 'x', 'e', 'd', 'c', 'r', 'f', 'v', 't', 'g', 'b' };
        static char[] right = { 'y', 'h', 'n', 'u', 'j', 'm', 'i', 'k', 'o', 'l', 'p' };
        String word = "";

        public Word(String iword)
        {
            word = iword;

        }

        public static String getRandomWord()
        {
            string rando = "";
            var rand = new Random();
            int nb = rand.Next(4, 8);
            for (int i = 0; i < nb; i++)
            {
                int j = rand.Next(0, 25);
                rando += lette[j];

            }
            return rando;
        }
        public static String getCapWord()
        {
            string rando = "";
            var rand = new Random();
            int nb = rand.Next(4, 8);
            for (int i = 0; i < nb; i++)
            {
                int j = rand.Next(0, 26);
                int b = rand.Next(1, 3);
                if (b == 2)
                {
                    rando += lette2[j];
                }
                else
                {
                    rando += lette[j];
                }


            }
            return rando;
        }
        public static String getLeft()
        {
            string rando = "";
            var rand = new Random();
            int nb = rand.Next(4, 8);
            for (int i = 0; i < nb; i++)
            {
                int j = rand.Next(0, 15);
                int b = rand.Next(2, 3);
                if (b == 2)
                {
                    rando += left[j];
                }
                else
                {
                    rando += Char.ToUpper(left[j]);
                }


            }
            return rando;
        }
        public static String getRight()
        {
            string rando = "";
            var rand = new Random();
            int nb = rand.Next(4, 8);
            for (int i = 0; i < nb; i++)
            {
                int j = rand.Next(0, 11);
                int b = rand.Next(2, 3);
                if (b == 2)
                {
                    rando += right[j];
                }
                else
                {
                    rando += Char.ToUpper(right[j]);
                }


            }
            return rando;
        }
    }
}
