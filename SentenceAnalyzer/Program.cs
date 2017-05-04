using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

/*
 * Name: Sean Frazier
 */

namespace SentenceAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {

            String sentence = Interaction.InputBox("Enter Any Sentence:", "Vowel Analyzer");

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            char[] cons = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            int[] vowelCount = { 0, 0, 0, 0, 0 };
            int[] consCount = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0 };

            String outputStr = "Your sentence was:\n\n";

            outputStr += "\"" + sentence + "\"\n\n";

            sentence = sentence.ToLower();

            int vowelTotal = 0, vowelMax = 0, vowelMin = sentence.Length;
            int consTotal = 0, consMax = 0, consMin = sentence.Length;
            int fullTotal =0;
            char maxChar = ' ', minChar = ' ';

            for (int i = 0; i < sentence.Length; ++i)
                for (int j = 0; j < vowels.Length; ++j)
                    if (sentence[i] == vowels[j])
                    {
                        vowelCount[j]++;
                        vowelTotal++;
                    }

            //outputStr += "Total number of wowels: " + vowelTotal + "\n\n";


            for (int i = 0; i < sentence.Length; ++i)
                for (int j = 0; j < cons.Length; ++j)
                    if (sentence[i] == cons[j])
                    {
                        consCount[j]++;
                        consTotal++;
                    }

            //outputStr += "Total number of consanants: " + consTotal + "\n\n";


             fullTotal += vowelTotal + consTotal;

            outputStr += "Total number of characters: " + fullTotal + "\n\n";

            for (int i = 0; i < vowelCount.Length; ++i)
                if (vowelCount[i] > 0)
                    outputStr += "Number of " + vowels[i] + "'s: " + vowelCount[i] + "\n";


            for(int i = 0; i < consCount.Length; ++i)
                if (consCount[i] > 0)
                outputStr += "Number of " + cons[i] + "'s: " + consCount[i] + "\n";




            for (int i = 0; i < vowelCount.Length; ++i)
            {
                if (vowelCount[i] > vowelMax)
                {
                    vowelMax = vowelCount[i];
                    maxChar = vowels[i];
                }
                if (vowelCount[i] > 0 && vowelCount[i] < vowelMin)
                {
                    vowelMin = vowelCount[i];
                    minChar = vowels[i];
                }
            }
 outputStr += "\nThe most frequent vowel was " + maxChar + "\n";
            outputStr += "The least frequent vowel was " + minChar + "\n";

            for (int i = 0; i < consCount.Length; ++i)
            {
                if (consCount[i] > consMax)
                {
                    consMax = consCount[i];
                    maxChar = cons[i];
                }
                if (consCount[i] > 0 && consCount[i] < consMin)
                {
                    consMin = consCount[i];
                    minChar = cons[i];
                }
            }
            outputStr += "\nThe most frequent Consonant was " + maxChar + "\n";
            outputStr += "The least frequent Consonan was " + minChar + "\n";


            MessageBox.Show(outputStr, "Vowel Analyzer");


        }
    }
}
