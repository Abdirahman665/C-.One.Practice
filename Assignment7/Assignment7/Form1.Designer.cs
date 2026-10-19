namespace Assignment7
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonhight = new System.Windows.Forms.RadioButton();
            this.radioButtonnormal = new System.Windows.Forms.RadioButton();
            this.radioButtonstandard = new System.Windows.Forms.RadioButton();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxage = new System.Windows.Forms.TextBox();
            this.textBoxnights = new System.Windows.Forms.TextBox();
            this.textBoxnumberguest = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxbreackfast = new System.Windows.Forms.CheckBox();
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.Booking_details = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1390, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Room Booking System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(0, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1390, 755);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personal Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Guest Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Guest Age :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Number of Nights :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Number of Guest :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.radioButtonhight);
            this.groupBox1.Controls.Add(this.radioButtonnormal);
            this.groupBox1.Controls.Add(this.radioButtonstandard);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 478);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 75);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Type";
            // 
            // radioButtonhight
            // 
            this.radioButtonhight.AutoSize = true;
            this.radioButtonhight.Location = new System.Drawing.Point(625, 31);
            this.radioButtonhight.Name = "radioButtonhight";
            this.radioButtonhight.Size = new System.Drawing.Size(99, 33);
            this.radioButtonhight.TabIndex = 2;
            this.radioButtonhight.TabStop = true;
            this.radioButtonhight.Text = "Hight";
            this.radioButtonhight.UseVisualStyleBackColor = true;
            // 
            // radioButtonnormal
            // 
            this.radioButtonnormal.AutoSize = true;
            this.radioButtonnormal.Location = new System.Drawing.Point(348, 31);
            this.radioButtonnormal.Name = "radioButtonnormal";
            this.radioButtonnormal.Size = new System.Drawing.Size(123, 33);
            this.radioButtonnormal.TabIndex = 1;
            this.radioButtonnormal.TabStop = true;
            this.radioButtonnormal.Text = "Normal";
            this.radioButtonnormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonstandard
            // 
            this.radioButtonstandard.AutoSize = true;
            this.radioButtonstandard.Location = new System.Drawing.Point(63, 31);
            this.radioButtonstandard.Name = "radioButtonstandard";
            this.radioButtonstandard.Size = new System.Drawing.Size(143, 33);
            this.radioButtonstandard.TabIndex = 0;
            this.radioButtonstandard.TabStop = true;
            this.radioButtonstandard.Text = "Standard";
            this.radioButtonstandard.UseVisualStyleBackColor = true;
            this.radioButtonstandard.UseWaitCursor = true;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(460, 144);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(325, 26);
            this.textBoxname.TabIndex = 8;
            // 
            // textBoxage
            // 
            this.textBoxage.Location = new System.Drawing.Point(460, 229);
            this.textBoxage.Name = "textBoxage";
            this.textBoxage.Size = new System.Drawing.Size(325, 26);
            this.textBoxage.TabIndex = 9;
            // 
            // textBoxnights
            // 
            this.textBoxnights.Location = new System.Drawing.Point(460, 309);
            this.textBoxnights.Name = "textBoxnights";
            this.textBoxnights.Size = new System.Drawing.Size(325, 26);
            this.textBoxnights.TabIndex = 10;
            // 
            // textBoxnumberguest
            // 
            this.textBoxnumberguest.Location = new System.Drawing.Point(460, 399);
            this.textBoxnumberguest.Name = "textBoxnumberguest";
            this.textBoxnumberguest.Size = new System.Drawing.Size(325, 26);
            this.textBoxnumberguest.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.checkBoxbreackfast);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 587);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(854, 75);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aditional Optipns";
            // 
            // checkBoxbreackfast
            // 
            this.checkBoxbreackfast.AutoSize = true;
            this.checkBoxbreackfast.Location = new System.Drawing.Point(241, 34);
            this.checkBoxbreackfast.Name = "checkBoxbreackfast";
            this.checkBoxbreackfast.Size = new System.Drawing.Size(476, 33);
            this.checkBoxbreackfast.TabIndex = 12;
            this.checkBoxbreackfast.Text = "Breack Fast (10 Per Guest per nights)";
            this.checkBoxbreackfast.UseVisualStyleBackColor = true;
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(83, 708);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(228, 73);
            this.calculate.TabIndex = 12;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(359, 708);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(228, 73);
            this.clear.TabIndex = 13;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(632, 708);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(228, 73);
            this.exit.TabIndex = 14;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // Booking_details
            // 
            this.Booking_details.FormattingEnabled = true;
            this.Booking_details.ItemHeight = 20;
            this.Booking_details.Location = new System.Drawing.Point(929, 99);
            this.Booking_details.Name = "Booking_details";
            this.Booking_details.Size = new System.Drawing.Size(430, 664);
            this.Booking_details.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 806);
            this.Controls.Add(this.Booking_details);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxnumberguest);
            this.Controls.Add(this.textBoxnights);
            this.Controls.Add(this.textBoxage);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonhight;
        private System.Windows.Forms.RadioButton radioButtonnormal;
        private System.Windows.Forms.RadioButton radioButtonstandard;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxage;
        private System.Windows.Forms.TextBox textBoxnights;
        private System.Windows.Forms.TextBox textBoxnumberguest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxbreackfast;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ListBox Booking_details;
    }
}

