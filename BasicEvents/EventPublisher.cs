using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicEvents
{
    class EventPublisher
    {
        private string theVal;

        //declare the event
        public event myEventHandler valueChanged;

        
        public string  Val
        {
             
            set {
                this.theVal = value;
                //when the value changes, fire the event
                this.valueChanged(theVal);
            }
        }

    }
}
