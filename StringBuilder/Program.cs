using System;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IndexOf("mily", 's'));
            Console.WriteLine(IndexOf("mili", 0));
            //Console.WriteLine(IndexOf("emis", 0,2));
        }
        public static int IndexOf(string word, char ch)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ch)
                {
                    return i;
                    break;
                }
            }
            return -1;
        }
        public static int IndexOf(string word, int index)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (i == index)
                {
                    Console.Write($"{word[i]}-given index ");
                    return index;
                    break;
                }
            }
            return -1;
        }
        public static int IndexOf(string word, int index, int count)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (i == index)
                {
                    Console.Write($"{word[i]}-given index ");
                    return index;
                    count++;
                }
            }
            return -1;
        }

    }
}
