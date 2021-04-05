using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GFT_Solution_Test_Client_Client.Inteface;

namespace GFT_Solution_Test_Client_Client.Model
{
    public class TradeModel : ITrade
    {
        private double _value;
        private string _clientSector;

        public double Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        public string ClientSector
        {
            get { return this._clientSector; }
            set { this._clientSector = value; }
        }

    }
}

