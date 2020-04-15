using System;

namespace firstProject
{
    class MainClass
    {
        public static string Mid(string word, int init, int lenghtWord)
        {
            string result = word.Substring(init, lenghtWord);
            return result;
        }
        public static void Main(string[] args)
        {
            int i, lenghtWord, j;
            bool validate = false;
            string wordValidate;
            string[] myIntArray = new string[5] { "ana","oso", "seres", "test",  "werj" };

            for (i=0; i < 5; i ++)
            {
                wordValidate = myIntArray[i];
                lenghtWord = wordValidate.Length;
                string inverseWord = "";
                while(lenghtWord > 0)
                {
                    inverseWord = inverseWord + Mid(wordValidate, lenghtWord - 1, 1);
                    lenghtWord = lenghtWord - 1;
                }
                if (inverseWord == wordValidate)
                {
                    validate = true;
                }
                else
                {
                    validate = false;
                }
                Console.WriteLine(wordValidate + " " +validate);
            }
        }
    }
}
