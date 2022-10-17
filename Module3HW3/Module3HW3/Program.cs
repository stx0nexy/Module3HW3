using System;

namespace Module3HW3
{
    public class Program
    {
        public void Show(bool result)
        {
            Console.WriteLine(result);
        }

        public static void Main()
        {
            Program program = new Program();
            var class1 = new Class1();
            var class2 = new Class2();
            class1.DelegateShow = program.Show;
            Console.WriteLine("(4*4)/4:");
            class2.Calc(class1.Pow, 4, 4);
            class1.DelegateShow(class2.Result(4));
            Console.WriteLine("(3*2)/9:");
            class2.Calc(class1.Pow, 3, 2);
            class1.DelegateShow(class2.Result(9));
        }
    }
}
