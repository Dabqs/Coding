using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOverload.Utils
{
    static class StringUtils
    {
        static StringUtils()
        {
            VersionData = "V" + MajorVersion +"."+MinorVersion;
        }
        public const int MinorVersion = 10;
        public const int MajorVersion = 2;
        public static readonly string VersionData;
         public const int MaxStringLenght = 10000;
        //gera static funkcija, gauna info, ja sukramto, grazina ir pamirsta (negalima saugoti programos būsenos)
        //bloga static funkcija         static private string myData; (nes panaudosi, bet vis dar laikys reikšmę viduje

        static public List<string> CutStringIntoWords(string data)
        {
            string[] splitWords = data.Split(new char[]{' ',',','!','?','.' });
            List<string> returnValue = new List<string>(splitWords);
            returnValue.RemoveAll(string.IsNullOrWhiteSpace);
            return returnValue;
        }

        private static bool TestIfEmpty(string data)
        {
            return data == string.Empty;
        }
    }
}
