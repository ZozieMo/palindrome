using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DalPalindrome;

namespace BllPalindrome
{
    public class PalindromeManagement
    {
        public List<string> GetListPalindromeFromFile(string pFileName)
        {
            FileTextReaderUtility myReader = new FileTextReaderUtility();
            List<string> Readlines = myReader.ReadAllLines(pFileName);
            
            // List<string> PalindromeWord = new List<string>();

            List<string> cleanedList = new List<string>();

            foreach (string line in Readlines)
            {
                // example line contenant aa, un type de lave
                // algorithm creation
                // ONLY aa as final output

                // MINE
                //string WoordBefChar = line.Substring(0, Readlines.IndexOf(","));
                //string WoordBefCharNoBlank = Regex.Replace(WoordBefChar, " ", "");

                //PalindromeWord.Add(WoordBefCharNoBlank[0]);

                string[] splitted = line.Split(',');
                cleanedList.Add(splitted[0].Trim());

            }
            return cleanedList; 
            //return PalindromeWord;
        }
    }
}
