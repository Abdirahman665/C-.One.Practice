namespace Assignment9_files
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
            this.btnreading = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnreading
            // 
            this.btnreading.BackColor = System.Drawing.Color.DarkCyan;
            this.btnreading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreading.Location = new System.Drawing.Point(57, 41);
            this.btnreading.Name = "btnreading";
            this.btnreading.Size = new System.Drawing.Size(367, 205);
            this.btnreading.TabIndex = 0;
            this.btnreading.Text = "Function Using Reading";
            this.btnreading.UseVisualStyleBackColor = false;
            this.btnreading.Click += new System.EventHandler(this.btnreading_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.LimeGreen;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(57, 277);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(367, 205);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "Delete Items Files";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(482, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(398, 444);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 544);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnreading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnreading;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ListBox listBox1;
    }
}

