using System.Globalization;
using System.Text;

namespace task10._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK-1

            string sentence = "   Xeyal huseynoV gRouP ab104,   Technical uniVersitY";

            string changedSentence = ChangeSentence(sentence);

            Console.WriteLine(changedSentence);
        }
        static string ChangeSentence(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
                return string.Empty;

            string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                if (result.Length > 0)
                {
                    result.Append(' ');
                }

                string changedWord = char.ToUpper(word[0]) + word.Substring(1).ToLower();
                result.Append(changedWord);
            }

            return result.ToString();
        }
    }
}