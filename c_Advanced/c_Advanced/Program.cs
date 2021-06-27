using System;
using System.Threading.Tasks;

namespace c_Advanced
{
     static class ex
    {
         
    }
    public class Program
    {
        public string name { get; set; }
        static void Main(string[] args)
        {
            Task t1 = new Task(() => { Console.WriteLine("t1"); });
            t1.Start();
            Console.WriteLine("t2");

        }
        
        
    }
}
