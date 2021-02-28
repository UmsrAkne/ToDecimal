using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDecimal {
    class Program {
        static void Main(string[] args) {
            Console.Write("hex -> decimal : ");

            for(int i = 0; i < args.Length; i++) {
                Console.Write(Convert.ToInt32(args[i], 16));
                Console.Write(" ");
            }

            Console.WriteLine("");
        }
    }
}
