namespace purgeoldfiles
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
            this.resulttext = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.directorytext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.purgeresult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.expireday = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maxsize = new System.Windows.Forms.TextBox();
            this.waitinglist = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resulttext
            // 
            this.resulttext.Location = new System.Drawing.Point(133, 77);
            this.resulttext.Name = "resulttext";
            this.resulttext.Size = new System.Drawing.Size(776, 96);
            this.resulttext.TabIndex = 0;
            this.resulttext.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(851, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "input directory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // directorytext
            // 
            this.directorytext.Location = new System.Drawing.Point(133, 9);
            this.directorytext.Multiline = true;
            this.directorytext.Name = "directorytext";
            this.directorytext.Size = new System.Drawing.Size(636, 33);
            this.directorytext.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "AllFiles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(926, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "TotalSize";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(723, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "purge";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "PurgeResult";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // purgeresult
            // 
            this.purgeresult.Location = new System.Drawing.Point(133, 349);
            this.purgeresult.Multiline = true;
            this.purgeresult.Name = "purgeresult";
            this.purgeresult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.purgeresult.Size = new System.Drawing.Size(776, 115);
            this.purgeresult.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1071, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Past Days";
            // 
            // expireday
            // 
            this.expireday.Location = new System.Drawing.Point(965, 6);
            this.expireday.Name = "expireday";
            this.expireday.Size = new System.Drawing.Size(100, 26);
            this.expireday.TabIndex = 10;
            this.expireday.Text = "8888";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1071, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "M.Reserve Size";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // maxsize
            // 
            this.maxsize.Location = new System.Drawing.Point(965, 43);
            this.maxsize.Name = "maxsize";
            this.maxsize.Size = new System.Drawing.Size(100, 26);
            this.maxsize.TabIndex = 12;
            this.maxsize.Text = "9999";
            // 
            // waitinglist
            // 
            this.waitinglist.Location = new System.Drawing.Point(133, 195);
            this.waitinglist.Name = "waitinglist";
            this.waitinglist.Size = new System.Drawing.Size(776, 96);
            this.waitinglist.TabIndex = 13;
            this.waitinglist.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "WaitingList";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(926, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sum";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(926, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Purged Sum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 508);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.waitinglist);
            this.Controls.Add(this.maxsize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.expireday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.purgeresult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.directorytext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resulttext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox resulttext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox directorytext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox purgeresult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox expireday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maxsize;
        private System.Windows.Forms.RichTextBox waitinglist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

