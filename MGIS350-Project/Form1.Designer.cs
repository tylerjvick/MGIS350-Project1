namespace MGIS350_Project
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
            this.rdoDough = new System.Windows.Forms.RadioButton();
            this.rdoSauce = new System.Windows.Forms.RadioButton();
            this.rdoCheese = new System.Windows.Forms.RadioButton();
            this.numAddInv = new System.Windows.Forms.NumericUpDown();
            this.lblAddInv = new System.Windows.Forms.Label();
            this.btnAddInv = new System.Windows.Forms.Button();
            this.lblDough = new System.Windows.Forms.Label();
            this.lblSauce = new System.Windows.Forms.Label();
            this.lblCheese = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.numOrder = new System.Windows.Forms.NumericUpDown();
            this.lblPizzaQty = new System.Windows.Forms.Label();
            this.chkSauce = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAddInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoDough
            // 
            this.rdoDough.AutoSize = true;
            this.rdoDough.Location = new System.Drawing.Point(12, 46);
            this.rdoDough.Name = "rdoDough";
            this.rdoDough.Size = new System.Drawing.Size(57, 17);
            this.rdoDough.TabIndex = 0;
            this.rdoDough.TabStop = true;
            this.rdoDough.Text = "Dough";
            this.rdoDough.UseVisualStyleBackColor = true;
            // 
            // rdoSauce
            // 
            this.rdoSauce.AutoSize = true;
            this.rdoSauce.Location = new System.Drawing.Point(12, 69);
            this.rdoSauce.Name = "rdoSauce";
            this.rdoSauce.Size = new System.Drawing.Size(56, 17);
            this.rdoSauce.TabIndex = 1;
            this.rdoSauce.TabStop = true;
            this.rdoSauce.Text = "Sauce";
            this.rdoSauce.UseVisualStyleBackColor = true;
            // 
            // rdoCheese
            // 
            this.rdoCheese.AutoSize = true;
            this.rdoCheese.Location = new System.Drawing.Point(12, 92);
            this.rdoCheese.Name = "rdoCheese";
            this.rdoCheese.Size = new System.Drawing.Size(61, 17);
            this.rdoCheese.TabIndex = 2;
            this.rdoCheese.TabStop = true;
            this.rdoCheese.Text = "Cheese";
            this.rdoCheese.UseVisualStyleBackColor = true;
            // 
            // numAddInv
            // 
            this.numAddInv.Location = new System.Drawing.Point(100, 12);
            this.numAddInv.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAddInv.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.numAddInv.Name = "numAddInv";
            this.numAddInv.Size = new System.Drawing.Size(77, 20);
            this.numAddInv.TabIndex = 3;
            // 
            // lblAddInv
            // 
            this.lblAddInv.AutoSize = true;
            this.lblAddInv.Location = new System.Drawing.Point(9, 14);
            this.lblAddInv.Name = "lblAddInv";
            this.lblAddInv.Size = new System.Drawing.Size(88, 13);
            this.lblAddInv.TabIndex = 4;
            this.lblAddInv.Text = "Add to Inventory:";
            // 
            // btnAddInv
            // 
            this.btnAddInv.Location = new System.Drawing.Point(197, 10);
            this.btnAddInv.Name = "btnAddInv";
            this.btnAddInv.Size = new System.Drawing.Size(75, 23);
            this.btnAddInv.TabIndex = 5;
            this.btnAddInv.Text = "Submit";
            this.btnAddInv.UseVisualStyleBackColor = true;
            this.btnAddInv.Click += new System.EventHandler(this.btnAddInv_Click);
            // 
            // lblDough
            // 
            this.lblDough.AutoSize = true;
            this.lblDough.Location = new System.Drawing.Point(75, 48);
            this.lblDough.Name = "lblDough";
            this.lblDough.Size = new System.Drawing.Size(29, 13);
            this.lblDough.TabIndex = 6;
            this.lblDough.Text = "0 lbs";
            // 
            // lblSauce
            // 
            this.lblSauce.AutoSize = true;
            this.lblSauce.Location = new System.Drawing.Point(75, 71);
            this.lblSauce.Name = "lblSauce";
            this.lblSauce.Size = new System.Drawing.Size(27, 13);
            this.lblSauce.TabIndex = 7;
            this.lblSauce.Text = "0 oz";
            // 
            // lblCheese
            // 
            this.lblCheese.AutoSize = true;
            this.lblCheese.Location = new System.Drawing.Point(75, 94);
            this.lblCheese.Name = "lblCheese";
            this.lblCheese.Size = new System.Drawing.Size(27, 13);
            this.lblCheese.TabIndex = 8;
            this.lblCheese.Text = "0 oz";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(12, 126);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(77, 13);
            this.lblOrder.TabIndex = 9;
            this.lblOrder.Text = "Build an Order:";
            // 
            // numOrder
            // 
            this.numOrder.Location = new System.Drawing.Point(12, 142);
            this.numOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOrder.Name = "numOrder";
            this.numOrder.Size = new System.Drawing.Size(77, 20);
            this.numOrder.TabIndex = 10;
            this.numOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOrder.ValueChanged += new System.EventHandler(this.numOrder_ValueChanged);
            // 
            // lblPizzaQty
            // 
            this.lblPizzaQty.AutoSize = true;
            this.lblPizzaQty.Location = new System.Drawing.Point(97, 144);
            this.lblPizzaQty.Name = "lblPizzaQty";
            this.lblPizzaQty.Size = new System.Drawing.Size(89, 13);
            this.lblPizzaQty.TabIndex = 11;
            this.lblPizzaQty.Text = "Number of Pizzas";
            // 
            // chkSauce
            // 
            this.chkSauce.AutoSize = true;
            this.chkSauce.Location = new System.Drawing.Point(12, 169);
            this.chkSauce.Name = "chkSauce";
            this.chkSauce.Size = new System.Drawing.Size(57, 17);
            this.chkSauce.TabIndex = 12;
            this.chkSauce.Text = "Sauce";
            this.chkSauce.UseVisualStyleBackColor = true;
            this.chkSauce.CheckedChanged += new System.EventHandler(this.chkSauce_CheckedChanged);
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Location = new System.Drawing.Point(12, 192);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(62, 17);
            this.chkCheese.TabIndex = 13;
            this.chkCheese.Text = "Cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            this.chkCheese.CheckedChanged += new System.EventHandler(this.chkCheese_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(12, 216);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 14;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 248);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.chkCheese);
            this.Controls.Add(this.chkSauce);
            this.Controls.Add(this.lblPizzaQty);
            this.Controls.Add(this.numOrder);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.lblCheese);
            this.Controls.Add(this.lblSauce);
            this.Controls.Add(this.lblDough);
            this.Controls.Add(this.btnAddInv);
            this.Controls.Add(this.lblAddInv);
            this.Controls.Add(this.numAddInv);
            this.Controls.Add(this.rdoCheese);
            this.Controls.Add(this.rdoSauce);
            this.Controls.Add(this.rdoDough);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAddInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoDough;
        private System.Windows.Forms.RadioButton rdoSauce;
        private System.Windows.Forms.RadioButton rdoCheese;
        private System.Windows.Forms.NumericUpDown numAddInv;
        private System.Windows.Forms.Label lblAddInv;
        private System.Windows.Forms.Button btnAddInv;
        private System.Windows.Forms.Label lblDough;
        private System.Windows.Forms.Label lblSauce;
        private System.Windows.Forms.Label lblCheese;
        private System.Windows.Forms.Label lblOrder;
        public System.Windows.Forms.NumericUpDown numOrder;
        private System.Windows.Forms.Label lblPizzaQty;
        public System.Windows.Forms.CheckBox chkSauce;
        public System.Windows.Forms.CheckBox chkCheese;
        public System.Windows.Forms.Button btnOrder;
    }
}

