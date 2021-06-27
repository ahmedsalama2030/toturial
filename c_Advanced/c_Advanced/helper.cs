using System;
using System.Collections.Generic;
using System.Text;

namespace c_Advanced
{
    public class helper
    {
        public event EventHandler ProcessCompleted; // event

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            // some code here..
            OnProcessCompleted(EventArgs.Empty);
        }


        protected virtual void OnProcessCompleted(EventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }
    }
}
