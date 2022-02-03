using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The HashTable Program To Find Frequency Of Words");
            Console.ReadLine();

            while(true)
            {
                Console.WriteLine("1: Find Frequency Of Given Words \n2: Find Frequency Of Large Paragraph \n3: Find Frequency Of Words Entered By User \n4: Exit");
                Console.Write("Enter A Choice From Above : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Finding frequency of words in a sentence “To be or not to be” and remove single word(UC1 & UC3)
                        string sentence = "To be or not to be";
                        string remWord = "or";
                        HashOperations.FrequencyOfWords(sentence, remWord);
                        break;
                    case 2:
                        //Finding frequency of words in a large paragraph and remove single word(UC2 & UC3)
                        string largepara = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                        string remParaWord = "avoidable";
                        HashOperations.FrequencyOfWords(largepara, remParaWord);
                        break;
                    case 3:
                        //Finding frequency of words entered by user
                        Console.Write("Enter A Line Or Paragraph Of Words : ");
                        string userPara = Console.ReadLine();
                        Console.Write("Enter A Word To Remove : ");
                        string userRemWord = Console.ReadLine();
                        HashOperations.FrequencyOfWords(userPara, userRemWord);
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        continue;
                }
            }
           

        }
    }
}
