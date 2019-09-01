using PrintingV2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintingV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private List<CartItem> shopCart = new List<CartItem>();



        private void ItemgroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NewOrderbtn_Click(object sender, EventArgs e)
        {
            newOrderbtn.Enabled = false;
            printorderbtn.Enabled = true;
            printpreviewBtn.Enabled = true;
            addToCartbtn.Enabled = true;
            clientNametextBox.Enabled = true;
            quantitytextBox.Enabled = true;
            itemNametextBox.Enabled = true;
            unitPricetextBox.Enabled = true;
            itemgroupBox.Enabled = true;
            clientadresstextBox.Enabled = true;
            clientNametextBox.Focus();





        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {


            newOrderbtn.Enabled = true;
            printorderbtn.Enabled = false;
            printpreviewBtn.Enabled = false;
            addToCartbtn.Enabled = false;
            clientNametextBox.Enabled = false;
            quantitytextBox.Enabled = false;
            itemNametextBox.Enabled = false;
            unitPricetextBox.Enabled = false;
            itemgroupBox.Enabled = false;
            clientadresstextBox.Enabled = false;

            clientNametextBox.Clear();
            quantitytextBox.Clear();
            unitPricetextBox.Clear();
            itemNametextBox.Clear();
            totalAmounttextBox.Text = "0";
            CartdataGridView.DataSource = null;
            shopCart.Clear();



        }

       

        private void AddToCartbtn_Click(object sender, EventArgs e)
        {

            if(isValidate())
            {
                CartItem item = new CartItem();
                {
                    item.itemName = itemNametextBox.Text;
                    item.quantity = Convert.ToInt32(quantitytextBox.Text.Trim());
                    item.unitPrice =Convert.ToDouble(unitPricetextBox.Text.Trim());
                    item.totalPrice = Convert.ToDouble(Convert.ToInt32(quantitytextBox.Text.Trim())* Convert.ToDouble(unitPricetextBox.Text.Trim()));


                };
                shopCart.Add(item);
                CartdataGridView.DataSource = null;
                CartdataGridView.DataSource = shopCart;
                double totalAmount = shopCart.Sum(x => x.totalPrice);
                totalAmounttextBox.Text = totalAmount.ToString();

                itemNametextBox.Clear();
                quantitytextBox.Clear();
                unitPricetextBox.Clear();



            }


        }


        public bool isValidate()
        {

            if(clientNametextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Client Name is not inputed!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                clientNametextBox.Focus();
                return false;
            }
            
            if (itemNametextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Item is not seected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                itemNametextBox.Focus();
                return false;
            }

            if (quantitytextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Item Quantity is not seected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quantitytextBox.Focus();
                return false;
            }
            else
            {
                int tempquantity;
                bool isNumaric = int.TryParse(quantitytextBox.Text.Trim(),out tempquantity);
                if (!isNumaric)
                { MessageBox.Show("Quantity should be integer!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    quantitytextBox.Clear();
                    quantitytextBox.Focus();
                    return false;


                }

            }

            if (unitPricetextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Unit Price is not inputed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                unitPricetextBox.Focus();
                return false;
            }
          else
            {
                int tempquantity;
                bool isNumaric = int.TryParse(unitPricetextBox.Text.Trim(), out tempquantity);
                if (!isNumaric)
                {
                    MessageBox.Show("Quantity should be integer!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    unitPricetextBox.Clear();
                    unitPricetextBox.Focus();
                    return false;


                }

            }


            return true;
        }

        private void CartdataGridView_MouseDown(object sender, MouseEventArgs e)
        {

            if(e.Button==System.Windows.Forms.MouseButtons.Right)
            {
                //finding the click point!
                var hti = CartdataGridView.HitTest(e.X, e.Y);
                //finding out the row where is hitted/clicked!
                CartdataGridView.Rows[hti.RowIndex].Selected=true;

                //showing the menustript where the row is being clicked!
                contextMenuStrip1.Show(CartdataGridView,e.X,e.Y);

            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = CartdataGridView.CurrentCell.RowIndex;
            shopCart.RemoveAt(index);
            CartdataGridView.DataSource = null;
            CartdataGridView.DataSource = shopCart;
            double totalAmount = shopCart.Sum(x => x.totalPrice);
            totalAmounttextBox.Text = totalAmount.ToString();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Resources.car_flat;
           // e.Graphics.DrawImage(image, 0, 0,image.Width,image.Height);
            e.Graphics.DrawString("      M/S B.R. MOTORS   "
              , new Font("Arial", 30, FontStyle.Regular), Brushes.Red, new Point(180, 40));

            e.Graphics.DrawString("\n 54,North Brook Hall Road(Samata tower)\n Bangla Bazar(downstairs of UCB bank)    "
             , new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(25, 100));
            e.Graphics.DrawString("Mobile No : 01712387151\n                    01715024317 \n                    01972387151    "
             , new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(680, 100));

            e.Graphics.DrawString("Date : " + DateTime.Now, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(700, 160));

            e.Graphics.DrawString("Client Name : " + clientNametextBox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 190));

            e.Graphics.DrawString("Client Adress : " + clientadresstextBox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 220));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------ ".Trim()          
                , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 240));

            e.Graphics.DrawString("SL no "
              , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 270));

            e.Graphics.DrawString("Item Name "
              , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(130, 270));

            e.Graphics.DrawString("Item Quantity "
              , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(330, 270));
            e.Graphics.DrawString("Unit price  "
              , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(530, 270));

            e.Graphics.DrawString("Total price  "
              , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(730, 270));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------ ".Trim()
                , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 290));
            int yPosition = 320;
            int cnt = 1 ;

            foreach(var i in shopCart)
            {
                e.Graphics.DrawString(cnt.ToString()+"."
             , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, yPosition));


                e.Graphics.DrawString(i.itemName, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(130, yPosition));

                e.Graphics.DrawString(i.quantity.ToString()
              , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(330, yPosition));

                e.Graphics.DrawString(i.unitPrice.ToString()
              , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(530, yPosition));

                e.Graphics.DrawString(i.unitPrice.ToString()
              , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(530, yPosition));

                e.Graphics.DrawString(i.unitPrice.ToString()
              , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(730, yPosition));


                yPosition = yPosition + 32;
                cnt++;
            }

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------ ".Trim()
               , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, yPosition));

            e.Graphics.DrawString("Total Amount in tk : "+totalAmounttextBox.Text.Trim()
              , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(550, yPosition+20));


        }


        private void PrintpreviewBtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void Printorderbtn_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }
    }
}
