using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyWCF
{
    class WCFServices: IWCFServices
    {

        #region IWCFServices Members

        string IWCFServices.GetTextData()
        {
            return "Hello";
        }

        #endregion
    }
}
