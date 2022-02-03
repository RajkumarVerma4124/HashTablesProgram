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
                        //Finding frequency of words in a sentence “To be or not to be”(UC1)
                        string paragraph = "To be or not to be";
                        HashOperations.FreequencyOfWords(paragraph);
                        break;
                    case 2:
                        //Finding frequency of words in a large paragraph(UC2)
                        string largepara = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                        HashOperations.FreequencyOfWords(largepara);
                        break;
                    case 3:
                        //Finding frequency of words entered by user
                        Console.Write("Enter A Line Or Paragraph Of Words : ");
                        string userPara = Console.ReadLine();
                        HashOperations.FreequencyOfWords(userPara);
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
