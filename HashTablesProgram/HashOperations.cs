using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesProgram
{
    //Performing hash operation
    public class HashOperations
    {
        //finding frequency of words in a sentence or large paragraph(UC1 & UC2)
        public static void FrequencyOfWords(string paragraph, string wordToRemove)
        {
            int length = paragraph.Split(' ').Count();
            MyMapNode<string, int> hash = new MyMapNode<string, int>(length);

            //Splitting the paragraph in single words to add in hash tabel 
            string[] words = paragraph.Split(' ');

            foreach (string word in words)
            {
                if (hash.Exists(word.ToLower()))
                    hash.Add(word.ToLower(), hash.Get(word) + 1);
                else
                    hash.Add(word.ToLower(), 1);
            }

            //Displaying the frequency of words before removing
            Console.WriteLine("Frequency Of Words Before Removing");
            hash.Display();

            //Removing the given word(UC3)
            hash.Remove(wordToRemove);

            //Displaying the frequency of words after removing
            Console.WriteLine("Frequency Of Words After Removing");
            hash.Display();
        }
    }
}
