using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AdvancedC
{
    class studen
    {
        public string name { get; set; }
        public string color { get; set; }

        public virtual void Foo()
        { //do stuff	} 

        }

        class cc : studen
    {
            public sealed override void Foo()
            {// do other stuff} 

            }

            class MyClient
    {

        
        public static void Main()
        {
            string json = File.ReadAllText(@"C:\Users\Core\source\repos\AdvancedC\AdvancedC\json.json");
            studen ahmed = JsonConvert.DeserializeObject<studen>(json);

            Console.WriteLine(ahmed.name);
           
        }


        static void loo()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}