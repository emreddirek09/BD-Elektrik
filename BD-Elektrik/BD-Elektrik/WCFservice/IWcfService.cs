using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace BD_Elektrik.WCFservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWcfService" in both code and config file together.
    [ServiceContract]
    public interface IWcfService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        string ADGetir();

        [OperationContract]
        string DeneMe(string a);
    }
}
