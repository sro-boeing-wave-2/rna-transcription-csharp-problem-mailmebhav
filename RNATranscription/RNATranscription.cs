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
            foreach (char rna in dna)
            {
                switch (rna)
                {
                    case 'G':
                        {
                            result.Append('C');
                            break;
                        }
                    case 'C':
                        {
                            result.Append('G');
                            break;
                        }
                    case 'T':
                        {
                            result.Append('A');
                            break;
                        }
                    case 'A':
                        {
                            result.Append('U');
                            break;
                        }
                }
            }
            return result.ToString();
        }
    }
}
