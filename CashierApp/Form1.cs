namespace CashierApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public class Item
        {
            protected string item;
            protected double price;
            protected int quantity;
            protected double total;

            public Item(string item, double price, int quantity)
            {
                this.item = item;
                this.price = price;
                this.quantity = quantity;
                total = 0;
            }

            public double getTotal()
            {
                total = price * quantity;
                return total;

            }
            public void setPay(double amount)
            {

            }
        }
        public class discountItem : Item
        {
            private double item_discount;
            private double discounted_price;
            private double payment_amount;
            private double change;
            private double rec;

            public discountItem(string item, double price, int quantity, double discount) : base(item, price, quantity)
            {
                item_discount = discount * 0.01;
                discounted_price = 0;
            }

            public double getTotal()
            {
                double discountAmount = price * item_discount;
                discounted_price = price - discountAmount;
                total = discounted_price * quantity;
                return total;
            }
            public void setPay(double amount)
            {
                double total = getTotal();
                payment_amount = amount;
                change = payment_amount - total;
            }
            public double getChange()
            {

                return change;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void butt_Compute_Click(object sender, EventArgs e)
        {
            string item = txt_Item.Text;
            double price = Convert.ToDouble(txt_Price.Text);
            int quantity = Convert.ToInt32(txt_Quantity.Text);
            double discount = Convert.ToDouble(txt_Discount.Text);

            discountItem lala = new discountItem(item, price, quantity, discount);

            double total = lala.getTotal();
            lbl_amount.Text = total.ToString();
        }

        private void butt_Submit_Click(object sender, EventArgs e)
        {
            double rec = Convert.ToDouble(txt_payment.Text);
            string item = txt_Item.Text;
            double price = Convert.ToDouble(txt_Price.Text);
            int quantity = Convert.ToInt32(txt_Quantity.Text);
            double discount = Convert.ToDouble(txt_Discount.Text);

            discountItem bla = new discountItem(item, price, quantity, discount);

            bla.setPay(rec);
            double change = bla.getChange();

            lbl_change.Text = change.ToString();
        }

        private void txt_PayRec_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 login = new Form2();
            login.ShowDialog();
            this.Close();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}