using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Text;

namespace MyWCF
{
    [ServiceContract]
    interface IWCFServices
    {
        [OperationContract]
         string GetTextData();
        [OperationContract]
        List<Student> GetTopper(List<Student> LS);      
    }

    [DataContract]
    class Student
    {
        [DataMember]
        public int sid {get; set;}
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public double m1 { get; set; }
        [DataMember]
        public double m2 { get; set; }
        [DataMember]
        public double m3 { get; set; }
    }
}
