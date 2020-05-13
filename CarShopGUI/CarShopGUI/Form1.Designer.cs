namespace CarShopGUI
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
            this.gb_createcar = new System.Windows.Forms.GroupBox();
            this.bn_create = new System.Windows.Forms.Button();
            this.Tb_price = new System.Windows.Forms.TextBox();
            this.Tb_year = new System.Windows.Forms.TextBox();
            this.Tb_model = new System.Windows.Forms.TextBox();
            this.Tb_make = new System.Windows.Forms.TextBox();
            this.Lb_price = new System.Windows.Forms.Label();
            this.Lb_year = new System.Windows.Forms.Label();
            this.Lb_make = new System.Windows.Forms.Label();
            this.Lb_model = new System.Windows.Forms.Label();
            this.gb_carinventory = new System.Windows.Forms.GroupBox();
            this.list_inventory = new System.Windows.Forms.ListBox();
            this.gb_shoppingcart = new System.Windows.Forms.GroupBox();
            this.list_shopping = new System.Windows.Forms.ListBox();
            this.bn_addCart = new System.Windows.Forms.Button();
            this.lb_costlabel = new System.Windows.Forms.Label();
            this.lb_costtotal = new System.Windows.Forms.Label();
            this.bn_checkout = new System.Windows.Forms.Button();
            this.gb_generate = new System.Windows.Forms.GroupBox();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.lb_gamount = new System.Windows.Forms.Label();
            this.bn_generate = new System.Windows.Forms.Button();
            this.bn_Error = new System.Windows.Forms.Button();
            this.bn_remove = new System.Windows.Forms.Button();
            this.tb_Range = new System.Windows.Forms.TextBox();
            this.lb_Range = new System.Windows.Forms.Label();
            this.CB_electric = new System.Windows.Forms.CheckBox();
            this.gb_createcar.SuspendLayout();
            this.gb_carinventory.SuspendLayout();
            this.gb_shoppingcart.SuspendLayout();
            this.gb_generate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_createcar
            // 
            this.gb_createcar.Controls.Add(this.CB_electric);
            this.gb_createcar.Controls.Add(this.lb_Range);
            this.gb_createcar.Controls.Add(this.tb_Range);
            this.gb_createcar.Controls.Add(this.bn_create);
            this.gb_createcar.Controls.Add(this.Tb_price);
            this.gb_createcar.Controls.Add(this.Tb_year);
            this.gb_createcar.Controls.Add(this.Tb_model);
            this.gb_createcar.Controls.Add(this.Tb_make);
            this.gb_createcar.Controls.Add(this.Lb_price);
            this.gb_createcar.Controls.Add(this.Lb_year);
            this.gb_createcar.Controls.Add(this.Lb_make);
            this.gb_createcar.Controls.Add(this.Lb_model);
            this.gb_createcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_createcar.ForeColor = System.Drawing.SystemColors.Control;
            this.gb_createcar.Location = new System.Drawing.Point(12, 12);
            this.gb_createcar.Name = "gb_createcar";
            this.gb_createcar.Size = new System.Drawing.Size(200, 253);
            this.gb_createcar.TabIndex = 0;
            this.gb_createcar.TabStop = false;
            this.gb_createcar.Text = "Create a car:";
            // 
            // bn_create
            // 
            this.bn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.bn_create.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_create.FlatAppearance.BorderSize = 0;
            this.bn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bn_create.ForeColor = System.Drawing.Color.Gainsboro;
            this.bn_create.Location = new System.Drawing.Point(3, 210);
            this.bn_create.Name = "bn_create";
            this.bn_create.Size = new System.Drawing.Size(194, 40);
            this.bn_create.TabIndex = 1;
            this.bn_create.Text = "Create";
            this.bn_create.UseVisualStyleBackColor = false;
            this.bn_create.Click += new System.EventHandler(this.CreateCar_Click);
            // 
            // Tb_price
            // 
            this.Tb_price.Location = new System.Drawing.Point(65, 112);
            this.Tb_price.Name = "Tb_price";
            this.Tb_price.Size = new System.Drawing.Size(129, 22);
            this.Tb_price.TabIndex = 8;
            // 
            // Tb_year
            // 
            this.Tb_year.Location = new System.Drawing.Point(65, 84);
            this.Tb_year.Name = "Tb_year";
            this.Tb_year.Size = new System.Drawing.Size(129, 22);
            this.Tb_year.TabIndex = 7;
            // 
            // Tb_model
            // 
            this.Tb_model.Location = new System.Drawing.Point(65, 56);
            this.Tb_model.Name = "Tb_model";
            this.Tb_model.Size = new System.Drawing.Size(129, 22);
            this.Tb_model.TabIndex = 6;
            // 
            // Tb_make
            // 
            this.Tb_make.Location = new System.Drawing.Point(65, 27);
            this.Tb_make.Name = "Tb_make";
            this.Tb_make.Size = new System.Drawing.Size(129, 22);
            this.Tb_make.TabIndex = 5;
            // 
            // Lb_price
            // 
            this.Lb_price.AutoSize = true;
            this.Lb_price.Location = new System.Drawing.Point(6, 117);
            this.Lb_price.Name = "Lb_price";
            this.Lb_price.Size = new System.Drawing.Size(40, 17);
            this.Lb_price.TabIndex = 4;
            this.Lb_price.Text = "Price";
            // 
            // Lb_year
            // 
            this.Lb_year.AutoSize = true;
            this.Lb_year.Location = new System.Drawing.Point(6, 89);
            this.Lb_year.Name = "Lb_year";
            this.Lb_year.Size = new System.Drawing.Size(38, 17);
            this.Lb_year.TabIndex = 3;
            this.Lb_year.Text = "Year";
            // 
            // Lb_make
            // 
            this.Lb_make.AutoSize = true;
            this.Lb_make.Location = new System.Drawing.Point(6, 32);
            this.Lb_make.Name = "Lb_make";
            this.Lb_make.Size = new System.Drawing.Size(42, 17);
            this.Lb_make.TabIndex = 1;
            this.Lb_make.Text = "Make";
            // 
            // Lb_model
            // 
            this.Lb_model.AutoSize = true;
            this.Lb_model.Location = new System.Drawing.Point(6, 61);
            this.Lb_model.Name = "Lb_model";
            this.Lb_model.Size = new System.Drawing.Size(46, 17);
            this.Lb_model.TabIndex = 2;
            this.Lb_model.Text = "Model";
            // 
            // gb_carinventory
            // 
            this.gb_carinventory.Controls.Add(this.list_inventory);
            this.gb_carinventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_carinventory.ForeColor = System.Drawing.SystemColors.Control;
            this.gb_carinventory.Location = new System.Drawing.Point(218, 12);
            this.gb_carinventory.Name = "gb_carinventory";
            this.gb_carinventory.Size = new System.Drawing.Size(1000, 250);
            this.gb_carinventory.TabIndex = 1;
            this.gb_carinventory.TabStop = false;
            this.gb_carinventory.Text = "Car Inventory";
            // 
            // list_inventory
            // 
            this.list_inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.list_inventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_inventory.ForeColor = System.Drawing.SystemColors.Menu;
            this.list_inventory.FormattingEnabled = true;
            this.list_inventory.ItemHeight = 16;
            this.list_inventory.Location = new System.Drawing.Point(3, 18);
            this.list_inventory.Name = "list_inventory";
            this.list_inventory.Size = new System.Drawing.Size(994, 229);
            this.list_inventory.TabIndex = 6;
            this.list_inventory.DoubleClick += new System.EventHandler(this.AddCart_Click);
            // 
            // gb_shoppingcart
            // 
            this.gb_shoppingcart.Controls.Add(this.list_shopping);
            this.gb_shoppingcart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_shoppingcart.ForeColor = System.Drawing.SystemColors.Control;
            this.gb_shoppingcart.Location = new System.Drawing.Point(218, 307);
            this.gb_shoppingcart.Name = "gb_shoppingcart";
            this.gb_shoppingcart.Size = new System.Drawing.Size(1000, 172);
            this.gb_shoppingcart.TabIndex = 2;
            this.gb_shoppingcart.TabStop = false;
            this.gb_shoppingcart.Text = "Shopping Cart";
            // 
            // list_shopping
            // 
            this.list_shopping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.list_shopping.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_shopping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_shopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_shopping.ForeColor = System.Drawing.SystemColors.Menu;
            this.list_shopping.FormattingEnabled = true;
            this.list_shopping.ItemHeight = 16;
            this.list_shopping.Location = new System.Drawing.Point(3, 18);
            this.list_shopping.Name = "list_shopping";
            this.list_shopping.Size = new System.Drawing.Size(994, 151);
            this.list_shopping.TabIndex = 5;
            // 
            // bn_addCart
            // 
            this.bn_addCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.bn_addCart.FlatAppearance.BorderSize = 0;
            this.bn_addCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bn_addCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_addCart.ForeColor = System.Drawing.Color.Gainsboro;
            this.bn_addCart.Location = new System.Drawing.Point(550, 265);
            this.bn_addCart.Name = "bn_addCart";
            this.bn_addCart.Size = new System.Drawing.Size(250, 45);
            this.bn_addCart.TabIndex = 3;
            this.bn_addCart.Text = "Add to Cart";
            this.bn_addCart.UseVisualStyleBackColor = false;
            this.bn_addCart.Click += new System.EventHandler(this.AddCart_Click);
            // 
            // lb_costlabel
            // 
            this.lb_costlabel.AutoSize = true;
            this.lb_costlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_costlabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb_costlabel.Location = new System.Drawing.Point(837, 482);
            this.lb_costlabel.Name = "lb_costlabel";
            this.lb_costlabel.Size = new System.Drawing.Size(91, 20);
            this.lb_costlabel.TabIndex = 4;
            this.lb_costlabel.Text = "Total Cost:";
            // 
            // lb_costtotal
            // 
            this.lb_costtotal.AutoSize = true;
            this.lb_costtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_costtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.lb_costtotal.Location = new System.Drawing.Point(934, 482);
            this.lb_costtotal.Name = "lb_costtotal";
            this.lb_costtotal.Size = new System.Drawing.Size(118, 29);
            this.lb_costtotal.TabIndex = 5;
            this.lb_costtotal.Text = "#######";
            // 
            // bn_checkout
            // 
            this.bn_checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.bn_checkout.FlatAppearance.BorderSize = 0;
            this.bn_checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bn_checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_checkout.ForeColor = System.Drawing.Color.Gainsboro;
            this.bn_checkout.Location = new System.Drawing.Point(841, 521);
            this.bn_checkout.Name = "bn_checkout";
            this.bn_checkout.Size = new System.Drawing.Size(377, 55);
            this.bn_checkout.TabIndex = 6;
            this.bn_checkout.Text = "Checkout";
            this.bn_checkout.UseVisualStyleBackColor = false;
            // 
            // gb_generate
            // 
            this.gb_generate.Controls.Add(this.tb_amount);
            this.gb_generate.Controls.Add(this.lb_gamount);
            this.gb_generate.Controls.Add(this.bn_generate);
            this.gb_generate.ForeColor = System.Drawing.SystemColors.Control;
            this.gb_generate.Location = new System.Drawing.Point(12, 307);
            this.gb_generate.Name = "gb_generate";
            this.gb_generate.Size = new System.Drawing.Size(200, 112);
            this.gb_generate.TabIndex = 7;
            this.gb_generate.TabStop = false;
            this.gb_generate.Text = "Generate Car";
            // 
            // tb_amount
            // 
            this.tb_amount.Location = new System.Drawing.Point(64, 30);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(129, 22);
            this.tb_amount.TabIndex = 9;
            this.tb_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Generate_KeyDown);
            // 
            // lb_gamount
            // 
            this.lb_gamount.AutoSize = true;
            this.lb_gamount.Location = new System.Drawing.Point(5, 35);
            this.lb_gamount.Name = "lb_gamount";
            this.lb_gamount.Size = new System.Drawing.Size(56, 17);
            this.lb_gamount.TabIndex = 9;
            this.lb_gamount.Text = "Amount";
            // 
            // bn_generate
            // 
            this.bn_generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.bn_generate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_generate.FlatAppearance.BorderSize = 0;
            this.bn_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bn_generate.ForeColor = System.Drawing.Color.Gainsboro;
            this.bn_generate.Location = new System.Drawing.Point(3, 69);
            this.bn_generate.Name = "bn_generate";
            this.bn_generate.Size = new System.Drawing.Size(194, 40);
            this.bn_generate.TabIndex = 9;
            this.bn_generate.Text = "Create";
            this.bn_generate.UseVisualStyleBackColor = false;
            this.bn_generate.Click += new System.EventHandler(this.GenerateCar_Click);
            // 
            // bn_Error
            // 
            this.bn_Error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.bn_Error.FlatAppearance.BorderSize = 0;
            this.bn_Error.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bn_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_Error.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bn_Error.Location = new System.Drawing.Point(12, 425);
            this.bn_Error.Name = "bn_Error";
            this.bn_Error.Size = new System.Drawing.Size(200, 54);
            this.bn_Error.TabIndex = 10;
            this.bn_Error.Text = "Please, fix entered parameters";
            this.bn_Error.UseVisualStyleBackColor = false;
            this.bn_Error.Visible = false;
            // 
            // bn_remove
            // 
            this.bn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.bn_remove.FlatAppearance.BorderSize = 0;
            this.bn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_remove.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bn_remove.Location = new System.Drawing.Point(550, 485);
            this.bn_remove.Name = "bn_remove";
            this.bn_remove.Size = new System.Drawing.Size(250, 45);
            this.bn_remove.TabIndex = 11;
            this.bn_remove.Text = "Remove from Cart";
            this.bn_remove.UseVisualStyleBackColor = false;
            this.bn_remove.Click += new System.EventHandler(this.RemoveCart_Click);
            // 
            // tb_Range
            // 
            this.tb_Range.Location = new System.Drawing.Point(64, 168);
            this.tb_Range.Name = "tb_Range";
            this.tb_Range.Size = new System.Drawing.Size(129, 22);
            this.tb_Range.TabIndex = 10;
            // 
            // lb_Range
            // 
            this.lb_Range.AutoSize = true;
            this.lb_Range.Location = new System.Drawing.Point(6, 171);
            this.lb_Range.Name = "lb_Range";
            this.lb_Range.Size = new System.Drawing.Size(50, 17);
            this.lb_Range.TabIndex = 12;
            this.lb_Range.Text = "Range";
            // 
            // CB_electric
            // 
            this.CB_electric.AutoSize = true;
            this.CB_electric.Location = new System.Drawing.Point(4, 141);
            this.CB_electric.Name = "CB_electric";
            this.CB_electric.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CB_electric.Size = new System.Drawing.Size(76, 21);
            this.CB_electric.TabIndex = 9;
            this.CB_electric.Text = "Electric";
            this.CB_electric.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1232, 588);
            this.Controls.Add(this.bn_remove);
            this.Controls.Add(this.bn_Error);
            this.Controls.Add(this.gb_generate);
            this.Controls.Add(this.bn_checkout);
            this.Controls.Add(this.lb_costtotal);
            this.Controls.Add(this.lb_costlabel);
            this.Controls.Add(this.bn_addCart);
            this.Controls.Add(this.gb_shoppingcart);
            this.Controls.Add(this.gb_carinventory);
            this.Controls.Add(this.gb_createcar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_createcar.ResumeLayout(false);
            this.gb_createcar.PerformLayout();
            this.gb_carinventory.ResumeLayout(false);
            this.gb_shoppingcart.ResumeLayout(false);
            this.gb_generate.ResumeLayout(false);
            this.gb_generate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_createcar;
        private System.Windows.Forms.Button bn_create;
        private System.Windows.Forms.TextBox Tb_price;
        private System.Windows.Forms.TextBox Tb_year;
        private System.Windows.Forms.TextBox Tb_model;
        private System.Windows.Forms.TextBox Tb_make;
        private System.Windows.Forms.Label Lb_price;
        private System.Windows.Forms.Label Lb_year;
        private System.Windows.Forms.Label Lb_make;
        private System.Windows.Forms.Label Lb_model;
        private System.Windows.Forms.GroupBox gb_carinventory;
        private System.Windows.Forms.GroupBox gb_shoppingcart;
        private System.Windows.Forms.Button bn_addCart;
        private System.Windows.Forms.Label lb_costlabel;
        private System.Windows.Forms.Label lb_costtotal;
        private System.Windows.Forms.Button bn_checkout;
        private System.Windows.Forms.GroupBox gb_generate;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.Label lb_gamount;
        private System.Windows.Forms.Button bn_generate;
        private System.Windows.Forms.Button bn_Error;
        private System.Windows.Forms.ListBox list_shopping;
        private System.Windows.Forms.ListBox list_inventory;
        private System.Windows.Forms.Button bn_remove;
        private System.Windows.Forms.CheckBox CB_electric;
        private System.Windows.Forms.Label lb_Range;
        private System.Windows.Forms.TextBox tb_Range;
    }
}

