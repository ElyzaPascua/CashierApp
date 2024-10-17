namespace CashierApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            panel1 = new Panel();
            lbl_amount = new Label();
            label6 = new Label();
            butt_Compute = new Button();
            txt_Discount = new TextBox();
            label4 = new Label();
            txt_Quantity = new TextBox();
            label3 = new Label();
            txt_Price = new TextBox();
            label2 = new Label();
            txt_Item = new TextBox();
            txt_payment = new TextBox();
            label5 = new Label();
            butt_Submit = new Button();
            label7 = new Label();
            lbl_change = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            zToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitApplicationToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 71);
            label1.Name = "label1";
            label1.Size = new Size(52, 18);
            label1.TabIndex = 0;
            label1.Text = "Item: ";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(lbl_amount);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(butt_Compute);
            panel1.Controls.Add(txt_Discount);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_Quantity);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_Price);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_Item);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 574);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // lbl_amount
            // 
            lbl_amount.AutoSize = true;
            lbl_amount.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_amount.Location = new Point(138, 475);
            lbl_amount.Name = "lbl_amount";
            lbl_amount.Size = new Size(43, 18);
            lbl_amount.TabIndex = 10;
            lbl_amount.Text = "0.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 475);
            label6.Name = "label6";
            label6.Size = new Size(115, 18);
            label6.TabIndex = 9;
            label6.Text = "Total Amount: ";
            // 
            // butt_Compute
            // 
            butt_Compute.BackColor = Color.FromArgb(255, 192, 192);
            butt_Compute.Location = new Point(17, 425);
            butt_Compute.Name = "butt_Compute";
            butt_Compute.Size = new Size(94, 29);
            butt_Compute.TabIndex = 8;
            butt_Compute.Text = "Compute";
            butt_Compute.UseVisualStyleBackColor = false;
            butt_Compute.Click += butt_Compute_Click;
            // 
            // txt_Discount
            // 
            txt_Discount.Location = new Point(17, 372);
            txt_Discount.Name = "txt_Discount";
            txt_Discount.Size = new Size(217, 27);
            txt_Discount.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 351);
            label4.Name = "label4";
            label4.Size = new Size(82, 18);
            label4.TabIndex = 6;
            label4.Text = "Discount: ";
            // 
            // txt_Quantity
            // 
            txt_Quantity.Location = new Point(17, 271);
            txt_Quantity.Name = "txt_Quantity";
            txt_Quantity.Size = new Size(217, 27);
            txt_Quantity.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 250);
            label3.Name = "label3";
            label3.Size = new Size(82, 18);
            label3.TabIndex = 4;
            label3.Text = "Quantity: ";
            // 
            // txt_Price
            // 
            txt_Price.Location = new Point(17, 177);
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new Size(217, 27);
            txt_Price.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 156);
            label2.Name = "label2";
            label2.Size = new Size(56, 18);
            label2.TabIndex = 2;
            label2.Text = "Price: ";
            // 
            // txt_Item
            // 
            txt_Item.Location = new Point(17, 92);
            txt_Item.Name = "txt_Item";
            txt_Item.Size = new Size(217, 27);
            txt_Item.TabIndex = 1;
            // 
            // txt_payment
            // 
            txt_payment.Location = new Point(272, 82);
            txt_payment.Name = "txt_payment";
            txt_payment.Size = new Size(217, 27);
            txt_payment.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(272, 61);
            label5.Name = "label5";
            label5.Size = new Size(155, 18);
            label5.TabIndex = 2;
            label5.Text = "Payment Received: ";
            // 
            // butt_Submit
            // 
            butt_Submit.BackColor = Color.SeaShell;
            butt_Submit.Location = new Point(272, 135);
            butt_Submit.Name = "butt_Submit";
            butt_Submit.Size = new Size(94, 29);
            butt_Submit.TabIndex = 9;
            butt_Submit.Text = "Submit";
            butt_Submit.UseVisualStyleBackColor = false;
            butt_Submit.Click += butt_Submit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(272, 191);
            label7.Name = "label7";
            label7.Size = new Size(72, 18);
            label7.TabIndex = 10;
            label7.Text = "Change: ";
            // 
            // lbl_change
            // 
            lbl_change.AutoSize = true;
            lbl_change.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_change.Location = new Point(350, 191);
            lbl_change.Name = "lbl_change";
            lbl_change.Size = new Size(43, 18);
            lbl_change.TabIndex = 11;
            lbl_change.Text = "0.00";
            lbl_change.Click += label9_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { zToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(86, 28);
            // 
            // zToolStripMenuItem
            // 
            zToolStripMenuItem.Name = "zToolStripMenuItem";
            zToolStripMenuItem.Size = new Size(85, 24);
            zToolStripMenuItem.Text = "z";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(533, 28);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitApplicationToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitApplicationToolStripMenuItem
            // 
            exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            exitApplicationToolStripMenuItem.Size = new Size(224, 26);
            exitApplicationToolStripMenuItem.Text = "Exit Application";
            exitApplicationToolStripMenuItem.Click += exitApplicationToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(533, 554);
            Controls.Add(menuStrip1);
            Controls.Add(lbl_change);
            Controls.Add(label7);
            Controls.Add(butt_Submit);
            Controls.Add(txt_payment);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox txt_Item;
        private Button butt_Compute;
        private TextBox txt_Discount;
        private Label label4;
        private TextBox txt_Quantity;
        private Label label3;
        private TextBox txt_Price;
        private Label label2;
        private TextBox txt_payment;
        private Label label5;
        private Label lbl_amount;
        private Label label6;
        private Button butt_Submit;
        private Label label7;
        private Label lbl_change;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem zToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitApplicationToolStripMenuItem;
    }
}
