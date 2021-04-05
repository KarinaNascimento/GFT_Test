using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GFT_Solution_Test_Client_Client.Model;
using GFT_Solution_Test.TradeCategoryService;

namespace GFT_Solution_Test_Client_Client.Business
{
    public class TradeBusiness
    {
        public List<String> SeeCategories(List<TradeModel> tradeList)
        {
            try
            {
                String[] categoryList;

                TradeCategoryClient client = new TradeCategoryClient();

                List<TradeType> listTradeType = new List<TradeType>();

                foreach (var trade in tradeList)
                {
                    listTradeType.Add(new TradeType() { Value = trade.Value, ClientSector = trade.ClientSector });
                }

                categoryList = client.CheckCategory(listTradeType.ToArray());

                return categoryList.ToList<String>();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
