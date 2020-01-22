using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOverload.ExtraExercises
{
    static class StringHelper
    {
        public static List<string> ExtractWords(string message)
        {
            List<string> words = new List<string>();

            words = message.Split(new char[] { ' ', '.',',','-' } ).ToList();
            words.RemoveAll(String.IsNullOrWhiteSpace);
            return words;
        }
        public static string SplitCammelCase(string message)
        {
            string result = string.Empty;
            result = message[0].ToString().ToUpper();
            for (int i = 1; i < message.Length; i++)
            {
                if (char.IsUpper(message[i]))
                {
                    result += " " + message[i].ToString().ToLower();
                }
                else
                {
                    result += message[i];
                }

            }

            return result;
        }
    }
}
