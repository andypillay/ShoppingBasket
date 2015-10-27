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
using System.IO;


namespace ShoppingBasketUI
{
    public partial class MainUI : Form
    {
        
        ShoppingBasket shop = new ShoppingBasket();// Creates new ShoppingBasket when Program is opened.

        private int ActiveIndex;

        public MainUI()
        {
            InitializeComponent();
            ActiveIndex = -1;
        }
        private void UpdateReadOnlys()//Updates the read onlys.
        {
            //Sets dgv_Basket Datasource as null, then re-populates it.
            dgv_Basket.DataSource = null;
            dgv_Basket.DataSource = shop.OrderItems;
            dgv_Basket.Refresh();
            //Caculates the number of products in the list and changes that .Text
            txt_NumbItems.Text = shop.NumberOfProduct.ToString();
            //Caculates the total cost in the list and changes that .Text
            txt_TotalCost.Text = String.Format("{0:C}", shop.BasketTotal);
        }
        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            decimal latestPrice;
            int quantity = (int)nud_Quantity.Value;
            if (!string.IsNullOrWhiteSpace(txt_LatestPrice.Text) && (!string.IsNullOrWhiteSpace(txt_ProductName.Text)))
            {
                //Will convert string to decimal allowing it to be taken out as a parameter.
                if (Decimal.TryParse((this.txt_LatestPrice.Text.Remove(0, 1)), out latestPrice))
                {
                    //Adds Product using the infomation inputted by user.
                    shop.AddProduct(txt_ProductName.Text, latestPrice, quantity);
                    UpdateReadOnlys();
                }
            }
            else//Will keep showing unless values are entered.
            {
                MessageBox.Show("Please enter values");
            }

        }//Adds Item when clicked.
        private void btn_RemoveItem_Click(object sender, EventArgs e)//Remove Item when row is selected.
        {
            //Only continues if Row has been selected
            if (this.dgv_Basket.SelectedRows.Count > 0)
            {
                //Makes rows selected select full row.
                this.dgv_Basket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //Rows selected is equal to an item in OrderItems.
                this.dgv_Basket.DataSource = shop.OrderItems;
                //Finds Index of selected row and removes it from list.
                shop.OrderItems.RemoveAt(this.dgv_Basket.SelectedRows[0].Index);
                UpdateReadOnlys();
            }
            else //Will keep showing unless a row is selected.
            {
                MessageBox.Show("Please select one row");
            }
        }
        private void btn_EditItem_Click(object sender, EventArgs e)//Edit values of selected item of selected row 
        {
            //Only continues if Row has been selected
            if (this.dgv_Basket.SelectedRows.Count > 0)
            {
                //Makes rows selected select full row.
                this.dgv_Basket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //Rows selected is equal to an item in OrderItems.
                this.dgv_Basket.DataSource = shop.OrderItems;
                //Create new item (oi) using data in selected rows.
                OrderItem oi = new OrderItem((dgv_Basket.CurrentRow.Cells[0].Value.ToString()),
                    Convert.ToDecimal(dgv_Basket.CurrentRow.Cells[2].Value),
                    Convert.ToInt32(dgv_Basket.CurrentRow.Cells[1].Value));
                //Uses oi so the data can be used in other form (EditUI)
                EditUI edit = new EditUI(oi);
                //Continues only after user clicks OK on EditUI Form.
                if (edit.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //Convert string to decimal.
                    decimal editedLatestPrice;
                    if (Decimal.TryParse((edit.SEditedLatestPrice.Remove(0, 1)), out editedLatestPrice))
                    {
                        // Use the new inputted data from EditUI to create and add the item to the list.
                        OrderItem ni = new OrderItem(edit.EditedProductName, editedLatestPrice, edit.EditedQuantity);
                        shop.EditProduct(oi.ProductName, edit.EditedProductName, editedLatestPrice, edit.EditedQuantity, ni);
                        dgv_Basket.Update();
                        UpdateReadOnlys();
                    }
                }
            }
            else //Will keep showing unless a row is selected.
            {
                MessageBox.Show("Please select one row");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }// Close Program

        private void MainUI_Load(object sender, EventArgs e)
        {
            //Added Tooltips for each respective button.
            ToolTip tTAdd = new ToolTip();
            tTAdd.ShowAlways = true;
            tTAdd.SetToolTip(btn_AddItem, "Add Item to List");
            ToolTip tTRemove = new ToolTip();
            tTAdd.ShowAlways = true;
            tTAdd.SetToolTip(btn_RemoveItem, "Remove selected Item in List");
            ToolTip tTEdit = new ToolTip();
            tTAdd.ShowAlways = true;
            tTAdd.SetToolTip(btn_EditItem, "Edit selected Item in List");
            ToolTip tTClear = new ToolTip();
            tTAdd.ShowAlways = true;
            tTAdd.SetToolTip(btn_ClearBasket, "Clears all Items in list");
            ToolTip tTSave = new ToolTip();
            tTAdd.ShowAlways = true;
            tTAdd.SetToolTip(btn_Save, "Saves basket to a .txt file as a receipt");
            ToolTip tTExit = new ToolTip();
            tTAdd.ShowAlways = true;
            tTAdd.SetToolTip(btn_Exit, "Exit out Shopping Basket");
        }

        private void txt_LatestPrice_TextChanged(object sender, EventArgs e) 
            // Validates, corrects and confirms values inputed are numeric and adds "£".
            //e.g 3.30 becomes £3.30
        {
            //Remove previous formatting, or the decimal check will fail including leading zeros
            string value = txt_LatestPrice.Text.Replace(",", "").Replace("£", "")
                .Replace(".", "").TrimStart('0');
            decimal ul;
            //Check we are indeed handling a number
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                //Unsub the event so we don't enter a loop
                txt_LatestPrice.TextChanged -= txt_LatestPrice_TextChanged;
                //Format the text as currency
                txt_LatestPrice.Text = string.Format(CultureInfo.CreateSpecificCulture("en-GB"), "{0:C2}", ul);
                txt_LatestPrice.TextChanged += txt_LatestPrice_TextChanged;
                txt_LatestPrice.Select(txt_LatestPrice.Text.Length, 0);
            }
        }

        private void dgv_Basket_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ActiveIndex = e.RowIndex;
        }

        private void btn_ClearBasket_Click(object sender, EventArgs e)//Clear all in basket.
        {
            if (shop.EmptyBasket() == false)
            {
                if (MessageBox.Show("Are you sure you want to clear all Items in your Basket?", "Clear basket", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    shop.ClearAll();
                    dgv_Basket.Update();
                    UpdateReadOnlys();
                }
            }
            else //Will keep showing unless there are items in the basket.
            {
                MessageBox.Show("There are no items in the basket to clear");
            }
        }// Clear

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Check if basket has products inside before continuing.
            if (!shop.EmptyBasket())
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Text Files | *.txt";
                saveFileDialog1.DefaultExt = "txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    shop.SaveBasket(saveFileDialog1.FileName);
                }
            }
            else //Will keep showing unless there are items in the basket.
            {
                MessageBox.Show("There are no items in the basket");
            }

        }// Saves basket to .txt file.
    }
}
