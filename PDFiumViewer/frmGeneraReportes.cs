using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFiumViewer
{
    public partial class frmGeneraReportes : Form
    {
        public frmGeneraReportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\userone\Downloads\copyy.pdf";

            frmReporteClientes frmReportecliente = new frmReporteClientes(filePath);
            this.Hide();
            frmReportecliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
