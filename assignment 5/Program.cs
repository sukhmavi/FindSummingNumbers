using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_5
{
    class Program
    {
        static void Main(string[] args)
        { new GenerateList().Run(57); }
        
        }
    class GenerateList
    { const int LEN = 100;
        ArrayList listQ;
        public void Run(int AddUpTonumbers) {
            Random r = new Random();

            listQ = new ArrayList();
            for (int i =0; i < LEN; i++) { listQ.Add(r.Next(100)); }
            this.findTwoNumbersThatAddUpTo(AddUpTonumbers);

}
    }
    }
}
