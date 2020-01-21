using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOverload.Excercise
{
    class MisriKlase
    {
        public int LineStart { get; set; }
        private int LineEnd { get; set; }
        public static string LineStartNotice { get; } = "Line starts at ";
        private static string LineEndNotice { get; set; } = "Line ends at ";

        public MisriKlase(int lineStart, int lineEnd)
        {
            if (ValidateEntries(LineStart,lineEnd))
            {
            LineStart = lineStart;
            LineEnd = lineEnd;
            ShowInfo(LineStart, LineEnd);
            }
            else
            {
                Console.WriteLine("Wrong input provided.");
            }
        }
        
        public void ShowLineEnd()
        {
            Console.WriteLine(LineEnd);
        }
        private bool ValidateEntries(int lineStart,int lineEnd)
        {
            return lineStart < lineEnd;
        }

        public static void ChangeLineEndNotice(string notice)
        {
            LineEndNotice = notice;
        }
        private static void ShowInfo(int lineStart, int lineEnd)
        {
            Console.WriteLine(LineStartNotice + lineStart);
            Console.WriteLine(LineEndNotice + lineEnd);
        }
    }
}
