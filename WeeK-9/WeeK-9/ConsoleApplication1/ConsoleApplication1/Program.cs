using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //static int cnt;
        static void Main(string[] args)
        {

            
            //cnt = 200;

            

            asd();
        }


        static void Move()
        {

            int x = 0;
            //int y = 0;
            while (true)
            {
                Thread.Sleep(200);
                
                Console.Clear();
                Console.SetCursorPosition(x, 3);
                Console.Write("O");
                x++;
            }
        }

        static void asd()
        {


            Thread t = new Thread(Move);
            t.Start();
            ConsoleKeyInfo btn = Console.ReadKey();
            int m = 0;
            switch (btn.Key)
            {
                case ConsoleKey.Enter:

                    t.Start();
                    
                     break;
                case ConsoleKey.P:
                    t.Suspend();
                    break;


            }

        }
    }
}
