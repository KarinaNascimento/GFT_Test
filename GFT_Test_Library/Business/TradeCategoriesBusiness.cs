using GFT_Test_Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using GFT_Test_Library.DAL;
using System.Linq;


namespace GFT_Test_Library.Business
{
    public class TradeCategoriesBusiness
    {
        public TradeCategoryModel AllCategories()
        {
            try
            {
                TradeCategoryModel tradecategories = new TradeCategoryDAL().SelectTradeCategoryList();

                if (tradecategories.TradeList.Count > 0)
                {
                    return tradecategories;
                }
                else
                {
                    throw new Exception("No category classification found!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<String> SortCategoryByValue(List<TradeModel> tradeList)
        {
            try
            {
                TradeCategoryModel tradecategories = this.AllCategories();

                if (tradeList.Count > 0)
                {
                    List<String> catList = new List<string>();

                    foreach (var trade in tradeList)
                    {
                        var category = tradecategories.TradeList.Where(tc => tc.InitialValue < trade.Value &&
                                                                          (tc.FinalValue > trade.Value || tc.FinalValue == 0) &&
                                                                          tc.Sector.ToLower() == trade.ClientSector.ToLower()).ToList();


                        if (category.Count == 0)
                        {
                            throw new Exception("There is no information to evaluate the category for value - " + trade.Value);
                        }

                        if (category.Count() > 1)
                        {
                            throw new Exception("There are more than one category for the informed value - " + trade.Value);
                        }


                        catList.Add(category.First().Category);
                    }

                    return catList;
                }
                else
                {
                    throw new Exception("At least one value is required for the category to be evaluated!");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
