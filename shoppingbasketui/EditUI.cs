using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QAShoppingBasket;
using System.Globalization;

namespace ShoppingBasketUI
{
    public partial class EditUI : Form
    {

        private string _editedProductName;

        public string EditedProductName
        {
            get { return _editedProductName; }
            set { if (txt_ProductNameEdit.Text == string.Empty)
                {
                    throw new ArgumentOutOfRangeException("Product Name is Empty");
                }_editedProductName = value; }
        }

        private int _editedQuantity;

        public int EditedQuantity
        {
            get { return _editedQuantity; }
            set { if (nud_QuantityEdit.Value < 0)
                {
                    throw new ArgumentOutOfRangeException("Quantity is Negative or Zero");
                }_editedQuantity = value; }
        }
        
        private string _sEditedLatestPrice;

        public string SEditedLatestPrice
        {
            get { return _sEditedLatestPrice; }
            set { if (txt_LatestPriceEdit.Text == string.Empty)
                {
                    throw new ArgumentOutOfRangeException("Latest Price is Empty");
                }
                _sEditedLatestPrice = value; }
        }
        
        public EditUI()
        {
            
        }

        public EditUI(OrderItem oi)
        {
            InitializeComponent();

            //Copied Names of strings from MainUI to EditUI
            txt_ProductNameEdit.Text = oi.ProductName;
            nud_QuantityEdit.Value = oi.Quantity;
            string stringVal = Convert.ToString(oi.LatestPrice);
            txt_LatestPriceEdit.Text = stringVal;  
        }

        private void EditUI_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)//Closes Edit windows
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)//Whatever strings are set in the setbox and stored to be used in the edit item.
        {
            EditedProductName = this.txt_ProductNameEdit.Text;
            EditedQuantity = (int)this.nud_QuantityEdit.Value;
            SEditedLatestPrice = this.txt_LatestPriceEdit.Text;

        }

        private void txt_LatestPriceEdit_TextChanged(object sender, EventArgs e)
        {
            //Remove previous formatting, or the decimal check will fail including leading zeros
            string value = txt_LatestPriceEdit.Text.Replace(",", "").Replace("£", "")
                .Replace(".", "").TrimStart('0');
            decimal ul;
            //Check we are indeed handling a number
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                //Unsub the event so we don't enter a loop
                txt_LatestPriceEdit.TextChanged -= txt_LatestPriceEdit_TextChanged;
                //Format the text as currency
                txt_LatestPriceEdit.Text = string.Format(CultureInfo.CreateSpecificCulture("en-GB"), "{0:C2}", ul);
                txt_LatestPriceEdit.TextChanged += txt_LatestPriceEdit_TextChanged;
                txt_LatestPriceEdit.Select(txt_LatestPriceEdit.Text.Length, 0);
            }
        }
    }
}
