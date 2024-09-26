using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Assignment
{
    public class BeerOrMilkSongClass
    {
        public string Song() {
            //variable declaration
            string firstSentence, middleSentence, thirdSentence, combinition;

            //variable assignment
            firstSentence = "of beer on the wall";
            middleSentence = "of beer";
            thirdSentence = "Take one down and pass it around";

            //iterator
            for (int a = 99; a >= 1; a = a - 1)
            {
                //conditional statements
                if (a <= 99 && a != 1)
                {
                    //output
                    Console.WriteLine(a + " bottles " + firstSentence + ", " + a + " bottles " + middleSentence + ". " + thirdSentence + ",");
                    Console.WriteLine();
                }
                else if ( a == 1)
                {
                    //output
                    Console.WriteLine(a + " bottle " + firstSentence + ", " + a + " bottle " + middleSentence + ". " + thirdSentence + ".");
                    Console.WriteLine();
                }
            }
            return combinition = firstSentence + middleSentence + thirdSentence;
        }        
    }
}