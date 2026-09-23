namespace Assigment_1
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
            this.lbldayoftheweek = new System.Windows.Forms.Label();
            this.lblnameofthemonth = new System.Windows.Forms.Label();
            this.lblnemoricofthempnth = new System.Windows.Forms.Label();
            this.lblnameoftheyear = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.textdhyoftheweek = new System.Windows.Forms.TextBox();
            this.textmonth = new System.Windows.Forms.TextBox();
            this.textnemoricofthemonth = new System.Windows.Forms.TextBox();
            this.textoftheyear = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldayoftheweek
            // 
            this.lbldayoftheweek.AutoSize = true;
            this.lbldayoftheweek.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldayoftheweek.Location = new System.Drawing.Point(30, 78);
            this.lbldayoftheweek.Name = "lbldayoftheweek";
            this.lbldayoftheweek.Size = new System.Drawing.Size(261, 31);
            this.lbldayoftheweek.TabIndex = 0;
            this.lbldayoftheweek.Text = "Enter day of the week";
            // 
            // lblnameofthemonth
            // 
            this.lblnameofthemonth.AutoSize = true;
            this.lblnameofthemonth.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameofthemonth.Location = new System.Drawing.Point(30, 124);
            this.lblnameofthemonth.Name = "lblnameofthemonth";
            this.lblnameofthemonth.Size = new System.Drawing.Size(300, 31);
            this.lblnameofthemonth.TabIndex = 1;
            this.lblnameofthemonth.Text = "Enter name of the month";
            // 
            // lblnemoricofthempnth
            // 
            this.lblnemoricofthempnth.AutoSize = true;
            this.lblnemoricofthempnth.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnemoricofthempnth.Location = new System.Drawing.Point(30, 176);
            this.lblnemoricofthempnth.Name = "lblnemoricofthempnth";
            this.lblnemoricofthempnth.Size = new System.Drawing.Size(320, 31);
            this.lblnemoricofthempnth.TabIndex = 2;
            this.lblnemoricofthempnth.Text = "Enter numoric of th month";
            // 
            // lblnameoftheyear
            // 
            this.lblnameoftheyear.AutoSize = true;
            this.lblnameoftheyear.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameoftheyear.Location = new System.Drawing.Point(30, 223);
            this.lblnameoftheyear.Name = "lblnameoftheyear";
            this.lblnameoftheyear.Size = new System.Drawing.Size(173, 31);
            this.lblnameoftheyear.TabIndex = 3;
            this.lblnameoftheyear.Text = "Enter the year";
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.Location = new System.Drawing.Point(36, 324);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(761, 100);
            this.lbloutput.TabIndex = 4;
            // 
            // textdhyoftheweek
            // 
            this.textdhyoftheweek.Location = new System.Drawing.Point(458, 78);
            this.textdhyoftheweek.Name = "textdhyoftheweek";
            this.textdhyoftheweek.Size = new System.Drawing.Size(337, 26);
            this.textdhyoftheweek.TabIndex = 5;
            // 
            // textmonth
            // 
            this.textmonth.Location = new System.Drawing.Point(458, 127);
            this.textmonth.Name = "textmonth";
            this.textmonth.Size = new System.Drawing.Size(337, 26);
            this.textmonth.TabIndex = 6;
            // 
            // textnemoricofthemonth
            // 
            this.textnemoricofthemonth.Location = new System.Drawing.Point(458, 181);
            this.textnemoricofthemonth.Name = "textnemoricofthemonth";
            this.textnemoricofthemonth.Size = new System.Drawing.Size(337, 26);
            this.textnemoricofthemonth.TabIndex = 7;
            // 
            // textoftheyear
            // 
            this.textoftheyear.Location = new System.Drawing.Point(458, 228);
            this.textoftheyear.Name = "textoftheyear";
            this.textoftheyear.Size = new System.Drawing.Size(337, 26);
            this.textoftheyear.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 80);
            this.button1.TabIndex = 9;
            this.button1.Text = "Show Day";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 80);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(532, 492);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 80);
            this.button3.TabIndex = 11;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 657);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textoftheyear);
            this.Controls.Add(this.textnemoricofthemonth);
            this.Controls.Add(this.textmonth);
            this.Controls.Add(this.textdhyoftheweek);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblnameoftheyear);
            this.Controls.Add(this.lblnemoricofthempnth);
            this.Controls.Add(this.lblnameofthemonth);
            this.Controls.Add(this.lbldayoftheweek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldayoftheweek;
        private System.Windows.Forms.Label lblnameofthemonth;
        private System.Windows.Forms.Label lblnemoricofthempnth;
        private System.Windows.Forms.Label lblnameoftheyear;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox textdhyoftheweek;
        private System.Windows.Forms.TextBox textmonth;
        private System.Windows.Forms.TextBox textnemoricofthemonth;
        private System.Windows.Forms.TextBox textoftheyear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

