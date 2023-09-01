using System;

namespace cvbooster
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] pw = new char[10];
            Random rnd = new Random();

            string str1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string str2 = "abcdefghijklmnopqrstuvwxyz";
            string str3 = "!@#$%^&*()_+-=:;'\"|?/\\`~";
                
            for (int i=0; i<7; i+=2)
            {
                int n = rnd.Next(0,25);
                pw[i] = str1[n];
            }

            for(int i=1; i<8; i += 2)
            {
                int n = rnd.Next(0,25);
                pw[i] = str2[n];
            }

            for(int i=8; i<10; i++)
            {
                int n = rnd.Next(0,23);
                pw[i] = str3[n];
            }

            Console.WriteLine(pw);
        }
    }
}