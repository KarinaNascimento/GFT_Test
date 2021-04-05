using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using GFT_Test_Library.Models;
using GFT_Test_Library.Business;

namespace GFT_Test_Service
{
    public class Service1 : ITradeCategory
    {
        public List<String> CheckCategory(List<TradeType> tradeList)
        {
            try
            {
                List<TradeModel> list = new List<TradeModel>();
                List<String> listResult = new List<String>();

                if (tradeList.Count > 0)
                {
                    foreach (var trade in tradeList)
                    {
                        list.Add(new TradeModel()
                        {
                            ClientSector = trade.ClientSector,
                            Value = trade.Value
                        });

                    }
                }
                else
                {
                    throw new Exception("There is no value to check!");
                }

                listResult = new TradeCategoriesBusiness().SortCategoryByValue(list);

                return listResult;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
