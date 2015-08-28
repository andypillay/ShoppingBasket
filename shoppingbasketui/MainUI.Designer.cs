namespace ShoppingBasketUI
{
    partial class MainUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.nud_Quantity = new System.Windows.Forms.NumericUpDown();
            this.txt_LatestPrice = new System.Windows.Forms.TextBox();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.dgv_Basket = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_RemoveItem = new System.Windows.Forms.Button();
            this.btn_EditItem = new System.Windows.Forms.Button();
            this.btn_ClearBasket = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NumbItems = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TotalCost = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Basket)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Latest Price:";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(26, 31);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(134, 20);
            this.txt_ProductName.TabIndex = 1;
            // 
            // nud_Quantity
            // 
            this.nud_Quantity.Location = new System.Drawing.Point(194, 32);
            this.nud_Quantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_Quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Quantity.Name = "nud_Quantity";
            this.nud_Quantity.Size = new System.Drawing.Size(104, 20);
            this.nud_Quantity.TabIndex = 2;
            this.nud_Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_LatestPrice
            // 
            this.txt_LatestPrice.Location = new System.Drawing.Point(337, 31);
            this.txt_LatestPrice.Name = "txt_LatestPrice";
            this.txt_LatestPrice.Size = new System.Drawing.Size(132, 20);
            this.txt_LatestPrice.TabIndex = 3;
            this.txt_LatestPrice.TextChanged += new System.EventHandler(this.txt_LatestPrice_TextChanged);
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Location = new System.Drawing.Point(488, 28);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(75, 23);
            this.btn_AddItem.TabIndex = 4;
            this.btn_AddItem.Text = "&Add";
            this.btn_AddItem.UseVisualStyleBackColor = true;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // dgv_Basket
            // 
            this.dgv_Basket.AllowUserToAddRows = false;
            this.dgv_Basket.AllowUserToDeleteRows = false;
            this.dgv_Basket.AllowUserToOrderColumns = true;
            this.dgv_Basket.AllowUserToResizeColumns = false;
            this.dgv_Basket.AllowUserToResizeRows = false;
            this.dgv_Basket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Basket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Basket.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Basket.Location = new System.Drawing.Point(26, 73);
            this.dgv_Basket.Name = "dgv_Basket";
            this.dgv_Basket.ReadOnly = true;
            this.dgv_Basket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Basket.Size = new System.Drawing.Size(443, 305);
            this.dgv_Basket.TabIndex = 11;
            this.dgv_Basket.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Basket_RowEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Basket:";
            // 
            // btn_RemoveItem
            // 
            this.btn_RemoveItem.Location = new System.Drawing.Point(488, 73);
            this.btn_RemoveItem.Name = "btn_RemoveItem";
            this.btn_RemoveItem.Size = new System.Drawing.Size(75, 23);
            this.btn_RemoveItem.TabIndex = 5;
            this.btn_RemoveItem.Text = "&Remove";
            this.btn_RemoveItem.UseVisualStyleBackColor = true;
            this.btn_RemoveItem.Click += new System.EventHandler(this.btn_RemoveItem_Click);
            // 
            // btn_EditItem
            // 
            this.btn_EditItem.Location = new System.Drawing.Point(488, 121);
            this.btn_EditItem.Name = "btn_EditItem";
            this.btn_EditItem.Size = new System.Drawing.Size(75, 23);
            this.btn_EditItem.TabIndex = 6;
            this.btn_EditItem.Text = "&Edit";
            this.btn_EditItem.UseVisualStyleBackColor = true;
            this.btn_EditItem.Click += new System.EventHandler(this.btn_EditItem_Click);
            // 
            // btn_ClearBasket
            // 
            this.btn_ClearBasket.Location = new System.Drawing.Point(488, 166);
            this.btn_ClearBasket.Name = "btn_ClearBasket";
            this.btn_ClearBasket.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearBasket.TabIndex = 7;
            this.btn_ClearBasket.Text = "Clear &Basket";
            this.btn_ClearBasket.UseVisualStyleBackColor = true;
            this.btn_ClearBasket.Click += new System.EventHandler(this.btn_ClearBasket_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(488, 214);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "&Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Number Of Items:";
            // 
            // txt_NumbItems
            // 
            this.txt_NumbItems.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_NumbItems.Location = new System.Drawing.Point(109, 387);
            this.txt_NumbItems.Name = "txt_NumbItems";
            this.txt_NumbItems.ReadOnly = true;
            this.txt_NumbItems.Size = new System.Drawing.Size(73, 20);
            this.txt_NumbItems.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total:";
            // 
            // txt_TotalCost
            // 
            this.txt_TotalCost.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_TotalCost.Location = new System.Drawing.Point(397, 387);
            this.txt_TotalCost.Name = "txt_TotalCost";
            this.txt_TotalCost.ReadOnly = true;
            this.txt_TotalCost.Size = new System.Drawing.Size(73, 20);
            this.txt_TotalCost.TabIndex = 10;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(488, 385);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "E&xit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 423);
            this.Controls.Add(this.dgv_Basket);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_EditItem);
            this.Controls.Add(this.btn_ClearBasket);
            this.Controls.Add(this.btn_RemoveItem);
            this.Controls.Add(this.btn_AddItem);
            this.Controls.Add(this.txt_LatestPrice);
            this.Controls.Add(this.nud_Quantity);
            this.Controls.Add(this.txt_TotalCost);
            this.Controls.Add(this.txt_NumbItems);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainUI";
            this.Text = "Shopping Basket";
            this.Load += new System.EventHandler(this.MainUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Basket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.NumericUpDown nud_Quantity;
        private System.Windows.Forms.TextBox txt_LatestPrice;
        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.DataGridView dgv_Basket;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_RemoveItem;
        private System.Windows.Forms.Button btn_EditItem;
        private System.Windows.Forms.Button btn_ClearBasket;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NumbItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TotalCost;
        private System.Windows.Forms.Button btn_Exit;
    }
}

