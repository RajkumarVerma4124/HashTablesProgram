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
        //finding frequency of words in a sentence like “To be or not to be”
        public static void FreequencyOfWords(string paragraph)
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

            //Displaying the freqyency of words
            hash.Display();
        }
    }
}
