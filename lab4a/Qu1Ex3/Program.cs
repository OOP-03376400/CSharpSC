using System;

delegate int NumberChanger(int n);
namespace Qu1Ex3
{
    class Program
    {
        static int num = 10;

        public static int AddNum(int p)
        {
          //10 + 5 = 15
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
          //15 * 5 = 75
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            nc = nc1;
            nc += nc2;

            nc(5);
            //getNum() returns 75
            Console.WriteLine("Value of Num: {0}", getNum());
            //Value of Num: 75
            Console.ReadKey();
        }
    }
}
