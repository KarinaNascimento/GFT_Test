using GFT_Test_Library.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

namespace GFT_Test_Library.DAL
{
    public class TradeCategoryDAL
    {

        public SqlConnection cnnStr;

        public TradeCategoryDAL()
        {
            var cnn = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            if (!string.IsNullOrEmpty(cnn))
            {
                cnnStr = new SqlConnection(cnn);
            }
            else
            {
                throw new Exception("Connection string is not defined in App.Config");
            }
        }

        public TradeCategoryModel SelectTradeCategoryList()
        {
            try
            {
                TradeCategoryModel tradeCategory = new TradeCategoryModel();

                cnnStr.Open();

                SqlCommand cmd = new SqlCommand("select tc.InitialValue, " +
                                                "tc.FinalValue, " +
                                                "c.Category, " +
                                                "s.Sector " +
                                                "from TradeCategory tc(nolock) " +
                                                "inner join Category c(nolock) on tc.Category_id = c.id " +
                                                "inner join Sector s(nolock) on tc.Sector_id = s.id", cnnStr);


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        double finalValue;

                        var maxvalue = Double.TryParse(String.Format("{0}", reader["FinalValue"]), out finalValue);

                        tradeCategory.TradeList.Add(
                        new TradeCategoryModel
                        {
                            InitialValue = Double.Parse(String.Format("{0}", reader["InitialValue"])),
                            FinalValue = finalValue,
                            Category = String.Format("{0}", reader["Category"]),
                            Sector = String.Format("{0}", reader["Sector"])

                        });
                    }

                    return tradeCategory;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnnStr.Close();
            }
        }

        
        public void InsertTradeCategory()
        {
            //....
        }

        public void DeleteTradeCategory()
        {
            //....
        }

        public void UpdateTradeCategory()
        {
            //....
        }
    }
}
