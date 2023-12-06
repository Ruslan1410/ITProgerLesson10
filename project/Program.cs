using System;

namespace project {

    class Program {

        static void Main(){
            // Print("Hello");
            // string word = "Hello world";
            // Print(word);
            int res1 = Summa (5,9);
            int a = 4, b = 7;
            int res2 = Summa(a, b);

            Print(res1.ToString());
            Print(res2.ToString());
        }

        public static void Print(string word) {
            Console.WriteLine (word);

        }


        public static int Summa(int x, int y) {
            return x + y;
        }
    }
}