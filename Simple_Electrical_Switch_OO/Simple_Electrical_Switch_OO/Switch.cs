using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Electrical_Switch_OO
{
    public class Switch
    {
        Status _switch_status;

        public Status Switch_status
        {
            get { return _switch_status; }
            set { _switch_status =value; }
        }

        public void Set_Switch_Status()
        {
            if (Switch_status == Status.off)
            {
                Switch_status = Status.on;
            }
            else if (Switch_status==Status.on)
            {
                Switch_status = Status.off;
            }
        }

        public override string ToString()
        {
            return string.Format("Switch Status is : {0}",this._switch_status);
        }

    }

    public enum Status
    { 
        on,
        off,
    }
    
}
