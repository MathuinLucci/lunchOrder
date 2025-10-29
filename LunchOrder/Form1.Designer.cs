namespace LunchOrder
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
            gbxMainCourse = new GroupBox();
            radSalad = new RadioButton();
            radPizza = new RadioButton();
            radHamburger = new RadioButton();
            groupBox3 = new GroupBox();
            txtOrderTotal = new TextBox();
            label3 = new Label();
            txtSalesTax = new TextBox();
            label2 = new Label();
            txtSubTotal = new TextBox();
            label1 = new Label();
            btnPlaceOrder = new Button();
            btnExit = new Button();
            gbxAddons = new GroupBox();
            cbxAddon3 = new CheckBox();
            cbxAddon2 = new CheckBox();
            cbxAddon1 = new CheckBox();
            btnClearOrder = new Button();
            gbxMainCourse.SuspendLayout();
            groupBox3.SuspendLayout();
            gbxAddons.SuspendLayout();
            SuspendLayout();
            // 
            // gbxMainCourse
            // 
            gbxMainCourse.Controls.Add(radSalad);
            gbxMainCourse.Controls.Add(radPizza);
            gbxMainCourse.Controls.Add(radHamburger);
            gbxMainCourse.Location = new Point(37, 28);
            gbxMainCourse.Margin = new Padding(2, 3, 2, 3);
            gbxMainCourse.Name = "gbxMainCourse";
            gbxMainCourse.Padding = new Padding(2, 3, 2, 3);
            gbxMainCourse.Size = new Size(190, 120);
            gbxMainCourse.TabIndex = 0;
            gbxMainCourse.TabStop = false;
            gbxMainCourse.Text = "Main Course";
            // 
            // radSalad
            // 
            radSalad.AutoSize = true;
            radSalad.Location = new Point(5, 86);
            radSalad.Name = "radSalad";
            radSalad.Size = new Size(116, 24);
            radSalad.TabIndex = 4;
            radSalad.TabStop = true;
            radSalad.Text = "Salad - $6.75";
            radSalad.UseVisualStyleBackColor = true;
            radSalad.CheckedChanged += radSalad_CheckedChanged;
            // 
            // radPizza
            // 
            radPizza.AutoSize = true;
            radPizza.Location = new Point(5, 56);
            radPizza.Name = "radPizza";
            radPizza.Size = new Size(113, 24);
            radPizza.TabIndex = 1;
            radPizza.Text = "Pizza - $6.95";
            radPizza.UseVisualStyleBackColor = true;
            radPizza.CheckedChanged += radPizza_CheckedChanged;
            // 
            // radHamburger
            // 
            radHamburger.AutoSize = true;
            radHamburger.Checked = true;
            radHamburger.Location = new Point(5, 26);
            radHamburger.Name = "radHamburger";
            radHamburger.Size = new Size(155, 24);
            radHamburger.TabIndex = 0;
            radHamburger.TabStop = true;
            radHamburger.Text = "Hamburger - $7.95";
            radHamburger.UseVisualStyleBackColor = true;
            radHamburger.CheckedChanged += radHamburger_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtOrderTotal);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtSalesTax);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtSubTotal);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(37, 185);
            groupBox3.Margin = new Padding(2, 3, 2, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 3, 2, 3);
            groupBox3.Size = new Size(286, 143);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new Point(120, 96);
            txtOrderTotal.Margin = new Padding(2, 3, 2, 3);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new Size(121, 27);
            txtOrderTotal.TabIndex = 5;
            txtOrderTotal.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 99);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 4;
            label3.Text = "Order Total:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSalesTax
            // 
            txtSalesTax.Location = new Point(120, 61);
            txtSalesTax.Margin = new Padding(2, 3, 2, 3);
            txtSalesTax.Name = "txtSalesTax";
            txtSalesTax.ReadOnly = true;
            txtSalesTax.Size = new Size(121, 27);
            txtSalesTax.TabIndex = 3;
            txtSalesTax.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 64);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 2;
            label2.Text = "Tax (7.75%):";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(120, 27);
            txtSubTotal.Margin = new Padding(2, 3, 2, 3);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(121, 27);
            txtSubTotal.TabIndex = 1;
            txtSubTotal.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Subtotal:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(363, 195);
            btnPlaceOrder.Margin = new Padding(2, 3, 2, 3);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(96, 31);
            btnPlaceOrder.TabIndex = 2;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(363, 297);
            btnExit.Margin = new Padding(2, 3, 2, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(96, 31);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // gbxAddons
            // 
            gbxAddons.Controls.Add(cbxAddon3);
            gbxAddons.Controls.Add(cbxAddon2);
            gbxAddons.Controls.Add(cbxAddon1);
            gbxAddons.Location = new Point(246, 28);
            gbxAddons.Name = "gbxAddons";
            gbxAddons.Size = new Size(250, 120);
            gbxAddons.TabIndex = 4;
            gbxAddons.TabStop = false;
            gbxAddons.Text = "Add-on Items ($1.25/each)";
            // 
            // cbxAddon3
            // 
            cbxAddon3.AutoSize = true;
            cbxAddon3.Location = new Point(6, 83);
            cbxAddon3.Name = "cbxAddon3";
            cbxAddon3.Size = new Size(108, 24);
            cbxAddon3.TabIndex = 2;
            cbxAddon3.Text = "French Fries";
            cbxAddon3.UseVisualStyleBackColor = true;
            // 
            // cbxAddon2
            // 
            cbxAddon2.AutoSize = true;
            cbxAddon2.Location = new Point(6, 53);
            cbxAddon2.Name = "cbxAddon2";
            cbxAddon2.Size = new Size(190, 24);
            cbxAddon2.TabIndex = 1;
            cbxAddon2.Text = "Ketchup, mustard, mayo";
            cbxAddon2.UseVisualStyleBackColor = true;
            // 
            // cbxAddon1
            // 
            cbxAddon1.AutoSize = true;
            cbxAddon1.Location = new Point(6, 23);
            cbxAddon1.Name = "cbxAddon1";
            cbxAddon1.Size = new Size(180, 24);
            cbxAddon1.TabIndex = 0;
            cbxAddon1.Text = "Lettuce, tomato, onion";
            cbxAddon1.UseVisualStyleBackColor = true;
            // 
            // btnClearOrder
            // 
            btnClearOrder.Location = new Point(363, 244);
            btnClearOrder.Name = "btnClearOrder";
            btnClearOrder.Size = new Size(94, 29);
            btnClearOrder.TabIndex = 5;
            btnClearOrder.Text = "Clear Order";
            btnClearOrder.UseVisualStyleBackColor = true;
            btnClearOrder.Click += btnClearOrder_Click;
            // 
            // Form1
            // 
            AcceptButton = btnPlaceOrder;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(517, 360);
            Controls.Add(btnClearOrder);
            Controls.Add(gbxAddons);
            Controls.Add(btnExit);
            Controls.Add(btnPlaceOrder);
            Controls.Add(groupBox3);
            Controls.Add(gbxMainCourse);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lunch Order";
            gbxMainCourse.ResumeLayout(false);
            gbxMainCourse.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            gbxAddons.ResumeLayout(false);
            gbxAddons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxMainCourse;
        private GroupBox groupBox3;
        private TextBox txtOrderTotal;
        private Label label3;
        private TextBox txtSalesTax;
        private Label label2;
        private TextBox txtSubTotal;
        private Label label1;
        private Button btnPlaceOrder;
        private Button btnExit;
        private RadioButton radPizza;
        private RadioButton radHamburger;
        private RadioButton radSalad;
        private GroupBox gbxAddons;
        private CheckBox cbxAddon2;
        private CheckBox cbxAddon1;
        private CheckBox cbxAddon3;
        private Button btnClearOrder;
    }
}