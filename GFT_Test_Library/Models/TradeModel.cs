using System;
using System.Collections.Generic;
using System.Text;

namespace GFT_Test_Library.Models
{
   public  class TradeModel
    {
        private double _value;
        private string _clientSector;
        private string _category;

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

        public string Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

    }
}
