using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;



namespace PDFiumViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void openPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectFile();
        }

        private PdfDocument OpenDocument(string fileName)
        {
            try
            {
                return PdfDocument.Load(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void SelectFile()
        {
            using (OpenFileDialog openFD = new OpenFileDialog())
            {
                openFD.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                openFD.RestoreDirectory = true;
                openFD.Title = "Open PDF File";

                if (openFD.ShowDialog(this) != DialogResult.OK)
                {
                    Dispose();
                    return;
                }

                pdfViewer2.Document?.Dispose();
                pdfViewer2.Document = OpenDocument(openFD.FileName);
            }
        }

        private void generadorReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneraReportes formGeneraRep = new frmGeneraReportes();
            this.Hide();
            formGeneraRep.Show();
        }
    }
}
