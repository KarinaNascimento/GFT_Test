using System;

namespace GFT_Solution_Test_Client_Client
{
    partial class TradesForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewTrades = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonPrivate = new System.Windows.Forms.RadioButton();
            this.radioButtonPublic = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGetCategories = new System.Windows.Forms.Button();
            this.categoriesList = new System.Windows.Forms.ListView();
            this.TradeCategoryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrades)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTrades
            // 
            this.dataGridViewTrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrades.Location = new System.Drawing.Point(12, 130);
            this.dataGridViewTrades.Name = "dataGridViewTrades";
            this.dataGridViewTrades.Size = new System.Drawing.Size(349, 110);
            this.dataGridViewTrades.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "VALUE:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonPrivate);
            this.panel1.Controls.Add(this.radioButtonPublic);
            this.panel1.Location = new System.Drawing.Point(78, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 57);
            this.panel1.TabIndex = 3;
            // 
            // radioButtonPrivate
            // 
            this.radioButtonPrivate.AutoSize = true;
            this.radioButtonPrivate.Location = new System.Drawing.Point(4, 32);
            this.radioButtonPrivate.Name = "radioButtonPrivate";
            this.radioButtonPrivate.Size = new System.Drawing.Size(58, 17);
            this.radioButtonPrivate.TabIndex = 1;
            this.radioButtonPrivate.Text = "Private";
            this.radioButtonPrivate.UseVisualStyleBackColor = true;
            // 
            // radioButtonPublic
            // 
            this.radioButtonPublic.AutoSize = true;
            this.radioButtonPublic.Checked = true;
            this.radioButtonPublic.Location = new System.Drawing.Point(4, 3);
            this.radioButtonPublic.Name = "radioButtonPublic";
            this.radioButtonPublic.Size = new System.Drawing.Size(54, 17);
            this.radioButtonPublic.TabIndex = 0;
            this.radioButtonPublic.TabStop = true;
            this.radioButtonPublic.Text = "Public";
            this.radioButtonPublic.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sector:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(199, 91);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGetCategories
            // 
            this.btnGetCategories.Location = new System.Drawing.Point(115, 260);
            this.btnGetCategories.Name = "btnGetCategories";
            this.btnGetCategories.Size = new System.Drawing.Size(132, 23);
            this.btnGetCategories.TabIndex = 6;
            this.btnGetCategories.Text = "Get Categories";
            this.btnGetCategories.UseVisualStyleBackColor = true;
            this.btnGetCategories.Click += new System.EventHandler(this.btnGetCategories_Click);
            // 
            // categoriesList
            // 
            this.categoriesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TradeCategoryColumn});
            this.categoriesList.GridLines = true;
            this.categoriesList.HideSelection = false;
            this.categoriesList.Location = new System.Drawing.Point(12, 289);
            this.categoriesList.Name = "categoriesList";
            this.categoriesList.Size = new System.Drawing.Size(349, 102);
            this.categoriesList.TabIndex = 7;
            this.categoriesList.UseCompatibleStateImageBehavior = false;
            this.categoriesList.View = System.Windows.Forms.View.List;
            // 
            // TradeCategoryColumn
            // 
            this.TradeCategoryColumn.Text = "Category";
            this.TradeCategoryColumn.Width = 100;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(78, 20);
            this.txtValor.Mask = "0000000";
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(140, 20);
            this.txtValor.TabIndex = 8;
            this.txtValor.ValidatingType = typeof(int);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(296, 10);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 9;
            this.RefreshBtn.Text = "Clear";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // TradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(374, 403);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.categoriesList);
            this.Controls.Add(this.btnGetCategories);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTrades);
            this.HelpButton = true;
            this.Name = "TradesForm";
            this.Text = "Portfolio Form";
            this.Load += new System.EventHandler(this.TradesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrades)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTrades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonPrivate;
        private System.Windows.Forms.RadioButton radioButtonPublic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGetCategories;
        private System.Windows.Forms.ListView categoriesList;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.ColumnHeader TradeCategoryColumn;
        private System.Windows.Forms.Button RefreshBtn;
    }
}

