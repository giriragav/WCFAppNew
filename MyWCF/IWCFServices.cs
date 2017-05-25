using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MyWCF
{
    [ServiceContract]
    interface IWCFServices
    {
        [OperationContract]
         string GetTextData();
      
    }
}
