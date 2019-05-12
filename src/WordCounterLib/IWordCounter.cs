using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WordCounterLib
{
    [ServiceContract(Namespace = "http://wordcounter.com/")]
    public interface IWordCounter
    {
        [OperationContract]
        int CountWords(string text);
    }
}