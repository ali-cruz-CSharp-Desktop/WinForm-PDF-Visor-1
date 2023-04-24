using PdfiumViewer;
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
    public partial class frmReporteClientes : Form
    {
        public frmReporteClientes(string pathFile)
        {
            InitializeComponent();

            //MessageBox.Show("val: " + pathFile);

            OpenFile(pathFile);            
        }

        private void OpenFile(string pathFile)
        {
            //pdfViewer1.Document?.Dispose();
            pdfViewer1.Document = LoadFile(pathFile);            
        }

        private PdfDocument LoadFile(string pathFile)
        {
            try
            {
                return PdfDocument.Load(pathFile);
            } catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                return null;
            }
        }

        private void regresarAlMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
