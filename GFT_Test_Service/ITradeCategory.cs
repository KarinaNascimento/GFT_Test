using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GFT_Test_Service
{
    [ServiceContract]
    public interface ITradeCategory
    {
        [OperationContract]
        List<String> CheckCategory(List<TradeType> tradeList);
    }

    [DataContract]
    public class TradeType
    {
        double _value;
        string _clientSector;

        [DataMember]
        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }

        [DataMember]
        public string ClientSector
        {
            get { return _clientSector; }
            set { _clientSector = value; }
        }
    }

}
