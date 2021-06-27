using System;
using System.Collections.Generic;
using System.Text;

namespace c_Advanced
{
   public  class client_2
    {
        public event EventHandler finishRegister;

        public void register(string user)
        {
            Console.WriteLine("user register");
            finishRegister.Invoke(this,EventArgs.Empty);
        }
    }
}
