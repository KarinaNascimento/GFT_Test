using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GFT_Solution_Test_Client_Client.Model;
using GFT_Solution_Test_Client_Client.Business;

namespace GFT_Solution_Test_Client_Client
{
    public partial class TradesForm : Form
    {
        List<TradeModel> t;

        public TradesForm()
        {
            InitializeComponent();
        }

        private void TradesForm_Load(object sender, EventArgs e)
        {
            t = new List<TradeModel>();
            this.categoriesList.Enabled = false;
            this.btnGetCategories.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string rbtSector = (radioButtonPrivate.Checked) ? radioButtonPrivate.Text : radioButtonPublic.Text;
            double _value = Double.Parse((string.IsNullOrEmpty(txtValor.Text) ? "0" : txtValor.Text));

            if (_value > 0)
            {
                this.dataGridViewTrades.DataSource = null;
                this.dataGridViewTrades.Refresh();

                t.Add(new TradeModel() { Value = _value, ClientSector = rbtSector });
                this.dataGridViewTrades.DataSource = t;
                this.dataGridViewTrades.Refresh();

                if (t.Count > 0)
                {
                    this.categoriesList.Enabled = true;
                    this.btnGetCategories.Enabled = true;
                    this.txtValor.Text = "";
                    this.radioButtonPublic.Checked = true;
                }
            }
        }

        private void btnGetCategories_Click(object sender, EventArgs e)
        {
            try
            {
                //This model implements the ITrade mandatory interface
                List<TradeModel> tradeList = new List<TradeModel>();

                this.categoriesList.Items.Clear();

                if (this.dataGridViewTrades.Rows.Count == 0)
                {
                    MessageBox.Show("Please save at least one value!");
                }
                else
                {
                    for (int i = 0; i < dataGridViewTrades.Rows.Count; i++)
                    {
                        var value = dataGridViewTrades.Rows[i].Cells[0].Value.ToString();
                        var clientSector = dataGridViewTrades.Rows[i].Cells[1].Value.ToString();

                        tradeList.Add(new TradeModel()
                        {
                            Value = Double.Parse(value),
                            ClientSector = clientSector
                        });
                    }

                    if (tradeList.Count > 0)
                    {
                        List<String> resultCat = new TradeBusiness().SeeCategories(tradeList);

                        foreach (var cat in resultCat)
                        {
                            categoriesList.Items.Add(cat);
                            this.t = new List<TradeModel>();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.dataGridViewTrades.DataSource = null;
            this.dataGridViewTrades.Refresh();
            this.categoriesList.Items.Clear();
            this.categoriesList.Enabled = false;
            this.btnGetCategories.Enabled = false;
            this.txtValor.Text = "";
            this.radioButtonPublic.Checked = true;
            this.t = new List<TradeModel>();
        }
    }
}
