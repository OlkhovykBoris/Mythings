using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellowrld
{
    class Hello
    {
        static void Main()
        {
            int a=10;
            int b=1;
            a += b;

            Console.WriteLine(a);
            
            if(a>10)
            {
                Console.WriteLine("Hello wrld");

                Console.WriteLine("Press any key to exist");
                Console.ReadKey();
            }
            
        }
    }
}
