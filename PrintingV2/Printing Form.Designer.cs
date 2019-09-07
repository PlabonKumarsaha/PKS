namespace PrintingV2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.itemgroupBox = new System.Windows.Forms.GroupBox();
            this.phonenotextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addToCartbtn = new System.Windows.Forms.Button();
            this.unitPricetextBox = new System.Windows.Forms.TextBox();
            this.unitPricelabel = new System.Windows.Forms.Label();
            this.quantitytextBox = new System.Windows.Forms.TextBox();
            this.quantitylabel = new System.Windows.Forms.Label();
            this.clientadresstextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.itemNametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clientNametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CartdataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.totalAmounttextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.printpreviewBtn = new System.Windows.Forms.Button();
            this.printorderbtn = new System.Windows.Forms.Button();
            this.newOrderbtn = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.itemgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartdataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemgroupBox
            // 
            this.itemgroupBox.Controls.Add(this.phonenotextBox);
            this.itemgroupBox.Controls.Add(this.label5);
            this.itemgroupBox.Controls.Add(this.addToCartbtn);
            this.itemgroupBox.Controls.Add(this.unitPricetextBox);
            this.itemgroupBox.Controls.Add(this.unitPricelabel);
            this.itemgroupBox.Controls.Add(this.quantitytextBox);
            this.itemgroupBox.Controls.Add(this.quantitylabel);
            this.itemgroupBox.Controls.Add(this.clientadresstextBox);
            this.itemgroupBox.Controls.Add(this.label4);
            this.itemgroupBox.Controls.Add(this.itemNametextBox);
            this.itemgroupBox.Controls.Add(this.label2);
            this.itemgroupBox.Controls.Add(this.clientNametextBox);
            this.itemgroupBox.Controls.Add(this.label1);
            this.itemgroupBox.Enabled = false;
            this.itemgroupBox.Location = new System.Drawing.Point(61, 26);
            this.itemgroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.itemgroupBox.Name = "itemgroupBox";
            this.itemgroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.itemgroupBox.Size = new System.Drawing.Size(732, 146);
            this.itemgroupBox.TabIndex = 0;
            this.itemgroupBox.TabStop = false;
            this.itemgroupBox.Enter += new System.EventHandler(this.ItemgroupBox_Enter);
            // 
            // phonenotextBox
            // 
            this.phonenotextBox.Location = new System.Drawing.Point(133, 92);
            this.phonenotextBox.Name = "phonenotextBox";
            this.phonenotextBox.Size = new System.Drawing.Size(175, 22);
            this.phonenotextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phone no";
            // 
            // addToCartbtn
            // 
            this.addToCartbtn.Image = global::PrintingV2.Properties.Resources.icons8_shopping_cart_50;
            this.addToCartbtn.Location = new System.Drawing.Point(615, 22);
            this.addToCartbtn.Name = "addToCartbtn";
            this.addToCartbtn.Size = new System.Drawing.Size(95, 93);
            this.addToCartbtn.TabIndex = 2;
            this.addToCartbtn.Text = "Add To Cart";
            this.addToCartbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addToCartbtn.UseVisualStyleBackColor = true;
            this.addToCartbtn.Click += new System.EventHandler(this.AddToCartbtn_Click);
            // 
            // unitPricetextBox
            // 
            this.unitPricetextBox.Location = new System.Drawing.Point(434, 25);
            this.unitPricetextBox.Name = "unitPricetextBox";
            this.unitPricetextBox.Size = new System.Drawing.Size(175, 22);
            this.unitPricetextBox.TabIndex = 1;
            // 
            // unitPricelabel
            // 
            this.unitPricelabel.AutoSize = true;
            this.unitPricelabel.Location = new System.Drawing.Point(346, 28);
            this.unitPricelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitPricelabel.Name = "unitPricelabel";
            this.unitPricelabel.Size = new System.Drawing.Size(68, 16);
            this.unitPricelabel.TabIndex = 0;
            this.unitPricelabel.Text = "Unit Price:";
            // 
            // quantitytextBox
            // 
            this.quantitytextBox.Location = new System.Drawing.Point(434, 64);
            this.quantitytextBox.Name = "quantitytextBox";
            this.quantitytextBox.Size = new System.Drawing.Size(175, 22);
            this.quantitytextBox.TabIndex = 1;
            // 
            // quantitylabel
            // 
            this.quantitylabel.AutoSize = true;
            this.quantitylabel.Location = new System.Drawing.Point(346, 67);
            this.quantitylabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantitylabel.Name = "quantitylabel";
            this.quantitylabel.Size = new System.Drawing.Size(62, 16);
            this.quantitylabel.TabIndex = 0;
            this.quantitylabel.Text = "Quantity :";
            // 
            // clientadresstextBox
            // 
            this.clientadresstextBox.Location = new System.Drawing.Point(133, 57);
            this.clientadresstextBox.Name = "clientadresstextBox";
            this.clientadresstextBox.Size = new System.Drawing.Size(175, 22);
            this.clientadresstextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Client Adress";
            // 
            // itemNametextBox
            // 
            this.itemNametextBox.Location = new System.Drawing.Point(133, 117);
            this.itemNametextBox.Name = "itemNametextBox";
            this.itemNametextBox.Size = new System.Drawing.Size(175, 22);
            this.itemNametextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item name";
            // 
            // clientNametextBox
            // 
            this.clientNametextBox.Location = new System.Drawing.Point(133, 22);
            this.clientNametextBox.Name = "clientNametextBox";
            this.clientNametextBox.Size = new System.Drawing.Size(175, 22);
            this.clientNametextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Name";
            // 
            // CartdataGridView
            // 
            this.CartdataGridView.AllowUserToAddRows = false;
            this.CartdataGridView.AllowUserToDeleteRows = false;
            this.CartdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CartdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartdataGridView.Location = new System.Drawing.Point(61, 191);
            this.CartdataGridView.MultiSelect = false;
            this.CartdataGridView.Name = "CartdataGridView";
            this.CartdataGridView.ReadOnly = true;
            this.CartdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartdataGridView.Size = new System.Drawing.Size(710, 308);
            this.CartdataGridView.TabIndex = 2;
            this.CartdataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CartdataGridView_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 520);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Amount :";
            // 
            // totalAmounttextBox
            // 
            this.totalAmounttextBox.Location = new System.Drawing.Point(580, 517);
            this.totalAmounttextBox.Name = "totalAmounttextBox";
            this.totalAmounttextBox.ReadOnly = true;
            this.totalAmounttextBox.Size = new System.Drawing.Size(175, 22);
            this.totalAmounttextBox.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Image = global::PrintingV2.Properties.Resources.icons8_cancel_64;
            this.cancelbtn.Location = new System.Drawing.Point(70, 520);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(135, 49);
            this.cancelbtn.TabIndex = 1;
            this.cancelbtn.Text = "Cancel  Order";
            this.cancelbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // printpreviewBtn
            // 
            this.printpreviewBtn.Enabled = false;
            this.printpreviewBtn.Image = global::PrintingV2.Properties.Resources.icons8_printer_48;
            this.printpreviewBtn.Location = new System.Drawing.Point(801, 130);
            this.printpreviewBtn.Name = "printpreviewBtn";
            this.printpreviewBtn.Size = new System.Drawing.Size(135, 90);
            this.printpreviewBtn.TabIndex = 1;
            this.printpreviewBtn.Text = "Print Preview";
            this.printpreviewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.printpreviewBtn.UseVisualStyleBackColor = true;
            this.printpreviewBtn.Click += new System.EventHandler(this.PrintpreviewBtn_Click);
            // 
            // printorderbtn
            // 
            this.printorderbtn.Enabled = false;
            this.printorderbtn.Image = global::PrintingV2.Properties.Resources.icons8_label_printer_50;
            this.printorderbtn.Location = new System.Drawing.Point(800, 243);
            this.printorderbtn.Name = "printorderbtn";
            this.printorderbtn.Size = new System.Drawing.Size(134, 94);
            this.printorderbtn.TabIndex = 1;
            this.printorderbtn.Text = "Print Order";
            this.printorderbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.printorderbtn.UseVisualStyleBackColor = true;
            this.printorderbtn.Click += new System.EventHandler(this.Printorderbtn_Click);
            // 
            // newOrderbtn
            // 
            this.newOrderbtn.Image = global::PrintingV2.Properties.Resources.icons8_purchase_order_64;
            this.newOrderbtn.Location = new System.Drawing.Point(801, 26);
            this.newOrderbtn.Name = "newOrderbtn";
            this.newOrderbtn.Size = new System.Drawing.Size(134, 86);
            this.newOrderbtn.TabIndex = 1;
            this.newOrderbtn.Text = "New order";
            this.newOrderbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newOrderbtn.UseVisualStyleBackColor = true;
            this.newOrderbtn.Click += new System.EventHandler(this.NewOrderbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 582);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Developed bt Team  PSH.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(344, 582);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(489, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Contact : business.teampsh@gmail.com,01686131757";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(824, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 615);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CartdataGridView);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.printpreviewBtn);
            this.Controls.Add(this.totalAmounttextBox);
            this.Controls.Add(this.printorderbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newOrderbtn);
            this.Controls.Add(this.itemgroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "BR motors";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.itemgroupBox.ResumeLayout(false);
            this.itemgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartdataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox itemgroupBox;
        private System.Windows.Forms.TextBox unitPricetextBox;
        private System.Windows.Forms.Label unitPricelabel;
        private System.Windows.Forms.TextBox quantitytextBox;
        private System.Windows.Forms.Label quantitylabel;
        private System.Windows.Forms.TextBox itemNametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientNametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addToCartbtn;
        private System.Windows.Forms.Button newOrderbtn;
        private System.Windows.Forms.Button printorderbtn;
        private System.Windows.Forms.Button printpreviewBtn;
        private System.Windows.Forms.DataGridView CartdataGridView;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalAmounttextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.TextBox clientadresstextBox;
        private System.Windows.Forms.Label label4;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox phonenotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

