using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOverload.Excercise
{
    class ActionCounter
    {
        private ActionCounter()
        {

        }
       static  public ActionCounter GetInstance()
        {
            return new ActionCounter();
        }
    }

}
