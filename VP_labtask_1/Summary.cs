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
    public partial class Summary : Form
    {
       
        public Summary()
        {
            InitializeComponent();
        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {
            
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            name.Text = Form1.fname;
            ecity.Text = Form1.to;
            Dcity.Text = Form1.from;
            Document.Text = Form1.document_no;
            DocumentExp.Text = Form1.date_expiry;
            Weight.Text = Form1.baggage;
            Tdate.Text = Form1.mon + " to "+ Form1.mon2;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
