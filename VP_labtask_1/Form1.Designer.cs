namespace VP_labtask_1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fr = new System.Windows.Forms.TextBox();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.MonthCalendar();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_FN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_LN = new System.Windows.Forms.TextBox();
            this.tra_dct = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dat_no = new System.Windows.Forms.Label();
            this.txt_DN = new System.Windows.Forms.TextBox();
            this.dat_iss = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dat_exp = new System.Windows.Forms.Label();
            this.dct_exp = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.NumericUpDown();
            this.btn_book = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "To:";
            // 
            // txt_fr
            // 
            this.txt_fr.Location = new System.Drawing.Point(140, 33);
            this.txt_fr.Name = "txt_fr";
            this.txt_fr.Size = new System.Drawing.Size(100, 22);
            this.txt_fr.TabIndex = 1;
            this.txt_fr.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(375, 30);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(100, 22);
            this.txt_to.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choose your schedule ( Scroll to select range or use SHift key)";
            // 
            // month
            // 
            this.month.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.month.Location = new System.Drawing.Point(131, 101);
            this.month.Name = "month";
            this.month.TabIndex = 2;
            this.month.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1_DateChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(96, 334);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(76, 17);
            this.label.TabIndex = 0;
            this.label.Text = "First Name";
            this.label.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 630);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "label1";
            this.label5.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txt_FN
            // 
            this.txt_FN.Location = new System.Drawing.Point(184, 331);
            this.txt_FN.Name = "txt_FN";
            this.txt_FN.Size = new System.Drawing.Size(100, 22);
            this.txt_FN.TabIndex = 1;
            this.txt_FN.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Last Name";
            this.label6.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txt_LN
            // 
            this.txt_LN.Location = new System.Drawing.Point(584, 320);
            this.txt_LN.Name = "txt_LN";
            this.txt_LN.Size = new System.Drawing.Size(100, 22);
            this.txt_LN.TabIndex = 1;
            this.txt_LN.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // tra_dct
            // 
            this.tra_dct.AutoSize = true;
            this.tra_dct.Location = new System.Drawing.Point(56, 371);
            this.tra_dct.Name = "tra_dct";
            this.tra_dct.Size = new System.Drawing.Size(116, 17);
            this.tra_dct.TabIndex = 0;
            this.tra_dct.Text = "Travel Document";
            this.tra_dct.Click += new System.EventHandler(this.Label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(178, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 31);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(97, 7);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(142, 21);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Identification Card";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 7);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Passport";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // dat_no
            // 
            this.dat_no.AutoSize = true;
            this.dat_no.Location = new System.Drawing.Point(433, 362);
            this.dat_no.Name = "dat_no";
            this.dat_no.Size = new System.Drawing.Size(126, 17);
            this.dat_no.TabIndex = 0;
            this.dat_no.Text = "Document Number";
            this.dat_no.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txt_DN
            // 
            this.txt_DN.Location = new System.Drawing.Point(584, 357);
            this.txt_DN.Name = "txt_DN";
            this.txt_DN.Size = new System.Drawing.Size(100, 22);
            this.txt_DN.TabIndex = 1;
            this.txt_DN.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // dat_iss
            // 
            this.dat_iss.AutoSize = true;
            this.dat_iss.Location = new System.Drawing.Point(56, 410);
            this.dat_iss.Name = "dat_iss";
            this.dat_iss.Size = new System.Drawing.Size(143, 17);
            this.dat_iss.TabIndex = 0;
            this.dat_iss.Text = "Document Issue Date";
            this.dat_iss.Click += new System.EventHandler(this.Label4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 410);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dat_exp
            // 
            this.dat_exp.AutoSize = true;
            this.dat_exp.Location = new System.Drawing.Point(417, 410);
            this.dat_exp.Name = "dat_exp";
            this.dat_exp.Size = new System.Drawing.Size(148, 17);
            this.dat_exp.TabIndex = 0;
            this.dat_exp.Text = "Document Expiry Date";
            this.dat_exp.Click += new System.EventHandler(this.Label4_Click);
            // 
            // dct_exp
            // 
            this.dct_exp.Location = new System.Drawing.Point(571, 405);
            this.dct_exp.Name = "dct_exp";
            this.dct_exp.Size = new System.Drawing.Size(200, 22);
            this.dct_exp.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Baggage (Provide an Estimate)";
            this.label11.Click += new System.EventHandler(this.Label4_Click);
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(266, 445);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(120, 22);
            this.weight.TabIndex = 5;
            this.weight.ValueChanged += new System.EventHandler(this.Weight_ValueChanged);
            // 
            // btn_book
            // 
            this.btn_book.Location = new System.Drawing.Point(12, 473);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(776, 41);
            this.btn_book.TabIndex = 6;
            this.btn_book.Text = "Book(Without Paying)";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Click += new System.EventHandler(this.Btn_book_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.btn_book);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.dct_exp);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.month);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.txt_LN);
            this.Controls.Add(this.txt_DN);
            this.Controls.Add(this.txt_FN);
            this.Controls.Add(this.txt_fr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dat_exp);
            this.Controls.Add(this.dat_no);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dat_iss);
            this.Controls.Add(this.tra_dct);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_fr;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar month;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_FN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_LN;
        private System.Windows.Forms.Label tra_dct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label dat_no;
        private System.Windows.Forms.TextBox txt_DN;
        private System.Windows.Forms.Label dat_iss;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dat_exp;
        private System.Windows.Forms.DateTimePicker dct_exp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown weight;
        private System.Windows.Forms.Button btn_book;
    }
}

