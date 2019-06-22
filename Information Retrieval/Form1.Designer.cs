namespace Information_Retrieval
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
            this.btns = new System.Windows.Forms.Button();
            this.btnlang = new System.Windows.Forms.Button();
            this.lblslang = new System.Windows.Forms.Label();
            this.lbllang = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnfiles = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btns
            // 
            this.btns.Location = new System.Drawing.Point(374, 241);
            this.btns.Name = "btns";
            this.btns.Size = new System.Drawing.Size(133, 44);
            this.btns.TabIndex = 0;
            this.btns.Text = "Search";
            this.btns.UseVisualStyleBackColor = true;
            this.btns.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlang
            // 
            this.btnlang.Location = new System.Drawing.Point(235, 241);
            this.btnlang.Name = "btnlang";
            this.btnlang.Size = new System.Drawing.Size(133, 44);
            this.btnlang.TabIndex = 4;
            this.btnlang.Text = "Change Language";
            this.btnlang.UseVisualStyleBackColor = true;
            this.btnlang.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblslang
            // 
            this.lblslang.AutoSize = true;
            this.lblslang.BackColor = System.Drawing.Color.White;
            this.lblslang.Location = new System.Drawing.Point(356, 308);
            this.lblslang.Name = "lblslang";
            this.lblslang.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblslang.Size = new System.Drawing.Size(92, 13);
            this.lblslang.TabIndex = 5;
            this.lblslang.Text = "Search Language";
            // 
            // lbllang
            // 
            this.lbllang.AutoSize = true;
            this.lbllang.BackColor = System.Drawing.Color.White;
            this.lbllang.ForeColor = System.Drawing.Color.Blue;
            this.lbllang.Location = new System.Drawing.Point(309, 308);
            this.lbllang.Name = "lbllang";
            this.lbllang.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbllang.Size = new System.Drawing.Size(41, 13);
            this.lbllang.TabIndex = 6;
            this.lbllang.Text = "English";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(97, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(549, 29);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnfiles
            // 
            this.btnfiles.BackColor = System.Drawing.Color.Blue;
            this.btnfiles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfiles.Location = new System.Drawing.Point(12, 24);
            this.btnfiles.Name = "btnfiles";
            this.btnfiles.Size = new System.Drawing.Size(75, 23);
            this.btnfiles.TabIndex = 8;
            this.btnfiles.Text = "Add Files";
            this.btnfiles.UseVisualStyleBackColor = false;
            this.btnfiles.Click += new System.EventHandler(this.btnfiles_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Information_Retrieval.Properties.Resources.Screenshot__66_;
            this.button1.Location = new System.Drawing.Point(700, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Information_Retrieval.Properties.Resources.Screenshot__3_1;
            this.ClientSize = new System.Drawing.Size(750, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnfiles);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbllang);
            this.Controls.Add(this.lblslang);
            this.Controls.Add(this.btnlang);
            this.Controls.Add(this.btns);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btns;
        private System.Windows.Forms.Button btnlang;
        private System.Windows.Forms.Label lblslang;
        private System.Windows.Forms.Label lbllang;
        private System.Windows.Forms.Button btnfiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

