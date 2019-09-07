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

        //variables
       // private int itemCountPerPage = 0;
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
            phonenotextBox.Enabled = true;
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
            phonenotextBox.Enabled = false;

            clientNametextBox.Clear();
            phonenotextBox.Clear();
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
            if (clientadresstextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Client adress is not inputed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clientadresstextBox.Focus();
                return false;
            }

            if (phonenotextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Client phone number is not inputted!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phonenotextBox.Focus();
                return false;
            }
            else if (phonenotextBox.Text.Length < 11  )
            {
                MessageBox.Show("invalid phone no is not inputed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phonenotextBox.Focus();
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
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;
        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Resources.pks2_project;
            e.Graphics.DrawImage(image, 70, 0,image.Width,image.Height);


            e.Graphics.DrawString("12345", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(0, 0));


            e.Graphics.DrawString("Date : " + DateTime.Now, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(600, 310));

            e.Graphics.DrawString("Client Name : " + clientNametextBox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 310));

            e.Graphics.DrawString("Client Adress : " + clientadresstextBox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 340));

            e.Graphics.DrawString("Phone no : " + phonenotextBox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 370));

            e.Graphics.DrawString("________________________________________________________________________________________________ ".Trim()
                , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 380));

            e.Graphics.DrawString("SL"
              , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 410));

            e.Graphics.DrawString("Item Name "
              , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(100, 410));

            e.Graphics.DrawString("Quantity "
              , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(520, 410));
            e.Graphics.DrawString("Unit price  "
              , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(630, 410));

            e.Graphics.DrawString("Total price  "
              , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(730, 410));

            e.Graphics.DrawString("________________________________________________________________________________________________ ".Trim()
                , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 420));
            int yPosition = 450;
            //int cnt = 1;

            for (int i = numberOfItemsPrintedSoFar; i<shopCart.Count;i++)
            {
                numberOfItemsPerPage++;
                if (numberOfItemsPerPage <= 20)
                {
                    numberOfItemsPrintedSoFar++;
                    if (numberOfItemsPrintedSoFar <= shopCart.Count)
                    {
                        e.Graphics.DrawString((numberOfItemsPrintedSoFar).ToString() + "."
                     , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, yPosition));


                        e.Graphics.DrawString(shopCart[i].itemName, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(100, yPosition));

                        e.Graphics.DrawString(shopCart[i].quantity.ToString()
                      , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(520, yPosition));

                        e.Graphics.DrawString(shopCart[i].unitPrice.ToString()
                      , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(630, yPosition));


                        e.Graphics.DrawString(shopCart[i].totalPrice.ToString()
                      , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(730, yPosition));


                        yPosition = yPosition + 32;
                    }
                    else { e.HasMorePages = false;
                    }
                }
                else
                {
                    e.HasMorePages = true;
                    numberOfItemsPerPage = 0;
                    return;
                    
                }
               // cnt++;

            }

            e.Graphics.DrawString("___________________________________________________________________________________________ ".Trim()
               , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, yPosition));

            e.Graphics.DrawString("Total Amount in tk : " + totalAmounttextBox.Text.Trim()
              , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(570, yPosition + 30));
            //Reseting the variables!!
            numberOfItemsPerPage = 0;
          numberOfItemsPrintedSoFar = 0;

    }

        private void PrintpreviewBtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void Printorderbtn_Click(object sender, EventArgs e)
        {
            //go to control panel >>Devices & printers >>select a printer;
            try
            { printDocument.Print(); }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
    }

