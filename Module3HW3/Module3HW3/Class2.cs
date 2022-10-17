using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW3
{
    public class Class2
    {
        private int Value { get; set; }
        public Predicate<int> Calc(Func<int, int, int> delegatePow, int x, int y)
        {
            Value = delegatePow(x, y);

            return new Predicate<int>(Result);
        }

        public bool Result(int number)
        {
            return Value % number == 0;
        }
    }
}
