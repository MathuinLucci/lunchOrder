namespace LunchOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.AcceptButton = btnPlaceOrder;
            this.CancelButton = btnExit;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string[] addon = new string[]
        {
            "Lettuce, tomato, onion", "Ketchup, mustard, mayo", "French Fries",
            "Pepperoni", "Sausage", "Olives",
            "Crutons", "Bacon Bits", "Bread Sticks"
        };

        public string[] priceText = new string[]
        {
            "Add-on Items ($1.25/each)", "Add-on Items ($0.75/each)", "Add-on Items ($0.50/each)"
        };

        public double[] addonPrice = new double[]
        {
            1.25d, 0.75d, 0.50d
        };

        public double[] mainPrice = new double[]
        {
            7.95d,6.95d, 6.75d
        };

        public double mainCost;
        public double addonCost;
        public double subtotal;
        public double tax;
        public double orderTotal;

        void ClearTotals()
        {
            txtSubTotal.Text = "";
            txtSalesTax.Text = "";
            txtOrderTotal.Text = "";
            addonCost = 0;
            subtotal = 0;
        }

        void ClearAddOns()
        {
            cbxAddon1.Checked = false;
            cbxAddon2.Checked = false;
            cbxAddon3.Checked = false;
        }

        public void radHamburger_CheckedChanged(object sender, EventArgs e)
        {
            this.ClearAddOns();
            cbxAddon1.Text = addon[0];
            cbxAddon2.Text = addon[1];
            cbxAddon3.Text = addon[2];
            gbxAddons.Text = priceText[0];
        }

        private void radPizza_CheckedChanged(object sender, EventArgs e)
        {
            this.ClearAddOns();
            cbxAddon1.Text = addon[3];
            cbxAddon2.Text = addon[4];
            cbxAddon3.Text = addon[5];
            gbxAddons.Text = priceText[1];
        }

        private void radSalad_CheckedChanged(object sender, EventArgs e)
        {
            this.ClearAddOns();
            cbxAddon1.Text = addon[6];
            cbxAddon2.Text = addon[7];
            cbxAddon3.Text = addon[8];
            gbxAddons.Text = priceText[2];
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

            if (radHamburger.Checked)
            {
                if (cbxAddon1.Checked)
                {
                    subtotal += addonPrice[0];
                }

                if (cbxAddon2.Checked)
                {
                    subtotal += addonPrice[0];
                }

                if (cbxAddon3.Checked)
                {
                    subtotal += addonPrice[0];
                }

                subtotal += mainPrice[0];

            }
            if (radPizza.Checked)
            {
                if (cbxAddon1.Checked)
                {
                    subtotal += addonPrice[1];
                }

                if (cbxAddon2.Checked)
                {
                    subtotal += addonPrice[1];
                }

                if (cbxAddon3.Checked)
                {
                    subtotal += addonPrice[1];
                }

                subtotal += mainPrice[1];

            }

            if (radSalad.Checked)
            {
                if (cbxAddon1.Checked)
                {
                    subtotal += addonPrice[2];
                }

                if (cbxAddon2.Checked)
                {
                    subtotal += addonPrice[2];
                }

                if (cbxAddon3.Checked)
                {
                    subtotal += addonPrice[2];
                }
                subtotal += mainPrice[2];
            }

            subtotal = Math.Round(subtotal, 2);
            tax = subtotal * 0.0775;
            tax = Math.Round(tax, 2);
            orderTotal = Math.Round(subtotal + tax, 2);
            txtSubTotal.Text = subtotal.ToString();
            txtSalesTax.Text = tax.ToString();
            txtOrderTotal.Text = orderTotal.ToString();

        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            radHamburger.Checked = true;
            ClearAddOns();
            ClearTotals();
        }
    }
}