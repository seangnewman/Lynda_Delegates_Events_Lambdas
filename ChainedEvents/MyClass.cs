using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedEvents
{
    class MyClass
    {
        private string theVal;
        // declare the event handler
        public event myEventHandler valueChanged;
        public event EventHandler<objChangeEventArgs> objChanged;

        public string Val
        {
            set
            {
                this.theVal = value;
                // when the value changes, fire the event
                this.valueChanged(theVal);
                this.objChanged(this, new objChangeEventArgs()
                {
                    propChanged = "Val"
                });

            }
        }
    }
}
