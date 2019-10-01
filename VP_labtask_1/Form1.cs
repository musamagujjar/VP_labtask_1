using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_labtask_1
{
    public partial class Form1 : Form
    {
        public static string fname;
        public static string from;
        public static string to;
        public static string travel_doc;
        public static string document_no;
        public static string date_issue;
        public static string date_expiry;
        public static string baggage;
        public static string date;
        public static string mon, mon2;
        

        public Form1()
        {
            InitializeComponent();
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void MonthCalendar1_DateChanged (object sender, EventArgs e)
        {

        }
        private void Label4_Click (object sender, EventArgs e)
        {

        }

        private void Weight_ValueChanged (object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd MMM,yyyy";
            dct_exp.Format = DateTimePickerFormat.Custom;
            dct_exp.CustomFormat = "dd MMM,yyyy";
            weight.Increment = 5;
            weight.ReadOnly = true;

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dat_no.Text = "Passport Number";
                dat_iss.Text = "Passport Issue Date";
                dat_exp.Text = "Passport Expiry Date";
            }

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                dat_no.Text = "ID Number";
                dat_iss.Text = "ID card Issue Date";
                dat_exp.Text = "ID cardExpiry Date";
            }
        }

       

        private void Btn_book_Click(object sender, EventArgs e)
        {
            fname = txt_FN.Text + " " + txt_LN.Text;
            to = txt_to.Text;
            from = txt_fr.Text;
            document_no = txt_DN.Text;
            date_issue = dateTimePicker1.Value.ToString("dd MMM,yyyy");
            date_expiry = dct_exp.Value.ToString("dd MMM,yyyy") + " to " + dateTimePicker1.Value.ToString("dd MMM,yyyy");
            date_expiry = dct_exp.Value.ToString("dd MMM,yyyy") + " to " + dateTimePicker1.Value.ToString("dd MMM,yyyy");
            baggage = weight.Value.ToString();
                            if (dateTimePicker1.Value >= dct_exp.Value)
                            {
                                MessageBox.Show("Please enter the valid date");
               
                            }
                            if (radioButton1.Checked)
                            {
                             travel_doc = radioButton1.Text;
                            }
                             else if (radioButton2.Checked)
                             {
                             travel_doc = radioButton2.Text;
                             }
            mon = month.SelectionStart.ToString("dd MMM,yyyy");
            mon2 = month.SelectionEnd.ToString("dd MMM,yyyy");




            Form summary = new Summary();
            summary.Show();
        }

        
    }
}
