using System;
using System.Collections.Generic;
using System.Text;

namespace GFT_Test_Library.Models
{
    public class TradeCategoryModel
    {
        private string _category;
        private double _initialValue;
        private double _finalValue;
        private string _sector;
        private List<TradeCategoryModel> _tradeCategorieList;

        public TradeCategoryModel()
        {
            this._tradeCategorieList = new List<TradeCategoryModel>();
        }

        public double InitialValue
        {
            get { return this._initialValue; }
            set { this._initialValue = value; }
        }

        public double FinalValue
        {
            get { return this._finalValue; }
            set { this._finalValue = value; }
        }

        public string Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        public string Sector
        {
            get { return this._sector; }
            set { this._sector = value; }
        }

        public List<TradeCategoryModel> TradeList
        {
            get { return this._tradeCategorieList; }
            set { this._tradeCategorieList = value; }
        }
    }
}
