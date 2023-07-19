

namespace string_task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter words:");
            string words = Console.ReadLine();
            int countVowels = 0;
            int countConsonants = 0;

            string word = words.ToLower();

            for (int i = 0; i < word.Length; i++)
            {
                bool check = char.IsLetter(word[i]);
                if (check == true)
                {
                    if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i'
                        || word[i] == 'o' || word[i] == 'u' || word[i] == 'y')
                    {
                        countVowels++;
                    }
                    else
                    {
                        countConsonants++;
                    }
                }
            }
            Console.WriteLine($"Result: number of vowels {countVowels} and consonants {countConsonants}");
        }
    }
}