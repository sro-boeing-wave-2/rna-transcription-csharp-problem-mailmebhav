using System;
using System.Collections.Generic;
using System.Text;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            StringBuilder result = new StringBuilder();
            string dna = nucleotide.ToUpper();
            Dictionary<char, char> rnaTransitionDict = new Dictionary<char, char>();
            rnaTransitionDict.Add('G', 'C');
            rnaTransitionDict.Add('C', 'G');
            rnaTransitionDict.Add('T', 'A');
            rnaTransitionDict.Add('A', 'U');
            foreach (char rna in dna)
            {
                result.Append(rnaTransitionDict[rna]);
            }
            return result.ToString();
        }
    }
}
