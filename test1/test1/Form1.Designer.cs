namespace test1
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
            this.GuestName = new System.Windows.Forms.Label();
            this.roomtype = new System.Windows.Forms.Label();
            this.NumberNight = new System.Windows.Forms.Label();
            this.prices = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.room = new System.Windows.Forms.TextBox();
            this.NumberNights = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.tax = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GuestName
            // 
            this.GuestName.AutoSize = true;
            this.GuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestName.Location = new System.Drawing.Point(69, 104);
            this.GuestName.Name = "GuestName";
            this.GuestName.Size = new System.Drawing.Size(200, 26);
            this.GuestName.TabIndex = 0;
            this.GuestName.Text = "Enter guest name";
            // 
            // roomtype
            // 
            this.roomtype.AutoSize = true;
            this.roomtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomtype.Location = new System.Drawing.Point(69, 171);
            this.roomtype.Name = "roomtype";
            this.roomtype.Size = new System.Drawing.Size(182, 26);
            this.roomtype.TabIndex = 1;
            this.roomtype.Text = "Enter room type";
            // 
            // NumberNight
            // 
            this.NumberNight.AutoSize = true;
            this.NumberNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberNight.Location = new System.Drawing.Point(69, 245);
            this.NumberNight.Name = "NumberNight";
            this.NumberNight.Size = new System.Drawing.Size(254, 26);
            this.NumberNight.TabIndex = 2;
            this.NumberNight.Text = "Enter number of nights";
            // 
            // prices
            // 
            this.prices.AutoSize = true;
            this.prices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prices.Location = new System.Drawing.Point(69, 317);
            this.prices.Name = "prices";
            this.prices.Size = new System.Drawing.Size(228, 26);
            this.prices.TabIndex = 3;
            this.prices.Text = "Enter price per night";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(365, 101);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(274, 26);
            this.name.TabIndex = 4;
            // 
            // room
            // 
            this.room.Location = new System.Drawing.Point(365, 165);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(274, 26);
            this.room.TabIndex = 5;
            // 
            // NumberNights
            // 
            this.NumberNights.Location = new System.Drawing.Point(365, 242);
            this.NumberNights.Name = "NumberNights";
            this.NumberNights.Size = new System.Drawing.Size(274, 26);
            this.NumberNights.TabIndex = 6;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(365, 311);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(274, 26);
            this.price.TabIndex = 7;
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(252, 390);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(276, 119);
            this.calculate.TabIndex = 10;
            this.calculate.Text = "Calculate Booking";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.display_Click);
            // 
            // tax
            // 
            this.tax.AutoSize = true;
            this.tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax.Location = new System.Drawing.Point(70, 571);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(227, 29);
            this.tax.TabIndex = 11;
            this.tax.Text = "Service Tax (10%)";
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount.Location = new System.Drawing.Point(70, 636);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(184, 29);
            this.Discount.TabIndex = 12;
            this.Discount.Text = "Descount (5%)";
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.Location = new System.Drawing.Point(70, 697);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(167, 29);
            this.TotalAmount.TabIndex = 13;
            this.TotalAmount.Text = "Total Amount";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(355, 577);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(325, 26);
            this.textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(355, 636);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(325, 26);
            this.textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(355, 697);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(325, 26);
            this.textBox7.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 769);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.TotalAmount);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.price);
            this.Controls.Add(this.NumberNights);
            this.Controls.Add(this.room);
            this.Controls.Add(this.name);
            this.Controls.Add(this.prices);
            this.Controls.Add(this.NumberNight);
            this.Controls.Add(this.roomtype);
            this.Controls.Add(this.GuestName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GuestName;
        private System.Windows.Forms.Label roomtype;
        private System.Windows.Forms.Label NumberNight;
        private System.Windows.Forms.Label prices;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox room;
        private System.Windows.Forms.TextBox NumberNights;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label tax;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Label TotalAmount;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
    }
}

