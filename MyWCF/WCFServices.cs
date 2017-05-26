using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyWCF
{
    class WCFServices: IWCFServices
    {

        #region IWCFServices Members

        public string GetTextData()
        {
            return "Hello Pappu";
        }


        public List<Student> GetTopper(List<Student> LS)
        {
            //Student pv; Student ws;
            //LS.Sort(
            //foreach (Student s in LS)
            //{
            //    pv = s;
            //    if ((s.m1+s.m2+s.m3) > (pv.m1+pv.m2+pv.m3))
            //    {
            //        ws = s;
            //    }
                
            //}
            //return ws;
            List<Student> SortedStudent = LS.OrderBy(o => (o.m1 + o.m2 + o.m3)).ToList();
            return SortedStudent;
        }

        #endregion
    }
}
