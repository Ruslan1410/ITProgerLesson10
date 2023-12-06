using System;

namespace project {

    class Program {

        static void Main(){
             byte [] nums = {1, 5, 6, 7, 2};
            byte res1 = Summa(nums);
            Console.WriteLine("Результат: " + res1);
        }

        public static byte Summa(byte[] digits){
            byte summ = 0;
            foreach(byte el in digits)
                summ += el;

                return summ;
        }

    }

}

