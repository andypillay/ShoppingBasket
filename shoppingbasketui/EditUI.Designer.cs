namespace ShoppingBasketUI
{
    partial class EditUI
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
            this.txt_LatestPriceEdit = new System.Windows.Forms.TextBox();
            this.nud_QuantityEdit = new System.Windows.Forms.NumericUpDown();
            this.txt_ProductNameEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_QuantityEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_LatestPriceEdit
            // 
            this.txt_LatestPriceEdit.Location = new System.Drawing.Point(98, 88);
            this.txt_LatestPriceEdit.Name = "txt_LatestPriceEdit";
            this.txt_LatestPriceEdit.Size = new System.Drawing.Size(113, 20);
            this.txt_LatestPriceEdit.TabIndex = 9;
            this.txt_LatestPriceEdit.TextChanged += new System.EventHandler(this.txt_LatestPriceEdit_TextChanged);
            // 
            // nud_QuantityEdit
            // 
            this.nud_QuantityEdit.Location = new System.Drawing.Point(98, 50);
            this.nud_QuantityEdit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_QuantityEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_QuantityEdit.Name = "nud_QuantityEdit";
            this.nud_QuantityEdit.Size = new System.Drawing.Size(113, 20);
            this.nud_QuantityEdit.TabIndex = 8;
            this.nud_QuantityEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_ProductNameEdit
            // 
            this.txt_ProductNameEdit.Location = new System.Drawing.Point(98, 15);
            this.txt_ProductNameEdit.Name = "txt_ProductNameEdit";
            this.txt_ProductNameEdit.Size = new System.Drawing.Size(113, 20);
            this.txt_ProductNameEdit.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Latest Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product Name:";
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(34, 131);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 10;
            this.btn_OK.Text = "O&k";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(115, 131);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "&Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // EditUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 170);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_LatestPriceEdit);
            this.Controls.Add(this.nud_QuantityEdit);
            this.Controls.Add(this.txt_ProductNameEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditUI";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.EditUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_QuantityEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_LatestPriceEdit;
        private System.Windows.Forms.NumericUpDown nud_QuantityEdit;
        private System.Windows.Forms.TextBox txt_ProductNameEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
    }
}