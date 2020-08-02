using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BESTPATH
{
    public class Session
    {
        private int sessionTimeLimit;

        public int getSessionTimeLimit()
        {
            return this.sessionTimeLimit;

        }//end property

        public Session()
        {
            this.sessionTimeLimit = 120;

        }//end constructor

    }//end class

}//end namespace