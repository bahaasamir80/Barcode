using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Barcode
{
    public partial class frmPrintPreview : Form
    {
        private int m_LeftMargin = 0;
        private int m_TopMargin = 0;

        private DataTable m_DataSource;

        public int LeftMargin
        {
            get { return m_LeftMargin; }
            set { m_LeftMargin = value; }
        }

        public int TopMargin
        {
            get { return m_TopMargin; }
            set { m_TopMargin = value; }
        }



        public DataTable DataSource
        {
            get { return m_DataSource; }
            set { m_DataSource = value; }
        }

        public frmPrintPreview()
        {
            InitializeComponent();
        }

        private void frmPrintPreview_Load(object sender, EventArgs e)
        {
            iPrintColCount = m_DataSource.Columns.Count;
            iPrintRowCount = m_DataSource.Rows.Count;
        }

        private void btnPageSet_Click(object sender, EventArgs e)
        {
            try
            {
                PDoc.PrinterSettings.PrinterName = "CutePDF Writer";
                PDoc.Print();
            }
            catch (Exception ex)
            {
                TMain.ErrorMessage(ex);
            }
        }

        private void PDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (printSet.ShowDialog() == DialogResult.OK)
                {
                    PDoc.PrinterSettings = printSet.PrinterSettings;
                    pv.InvalidatePreview();
                    PDoc.Print();
                }
            }
            catch (Exception ex)
            {
                TMain.ErrorMessage(ex);
            }
        }

        #region Print

        private int iPrintColCount = 0;
        private int iPrintRowCount = 0;
        private float iWidth = 151;
        private float iHeight = 113;
        private int iPageCount = 1;
        private int iRowIndex = 0;
        private RectangleF rec = new RectangleF();

        private void PDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            float X = m_LeftMargin;
            float Y = m_TopMargin;
           

            for (int iRowLoop = 0; iRowLoop < 9; iRowLoop++)
            {
                for (int iColLoop = 0; iColLoop <= iPrintColCount; iColLoop++)
                {
                    rec = new RectangleF((float)X, (float)Y, iWidth, iHeight);
                    e.Graphics.DrawImage((Image)m_DataSource.Rows[i][iColLoop], rec);

                    X += iWidth;
                }
                i++;
                if (i == m_DataSource.Rows.Count)
                {
                    Y = m_TopMargin;
                    X = m_LeftMargin;
                    iPageCount = 1;
                    iPrintRowCount = m_DataSource.Rows.Count - 1;
                    i = 0;
                    return;
                }
                X = m_LeftMargin;
                Y += iHeight;
                iPrintRowCount--;
            }
            if (iPrintRowCount > 0)
            {
                e.HasMorePages = true;
                Y = m_TopMargin;
                iPageCount++;
            }
            else
            {
                e.HasMorePages = false;
            }
        }


        #endregion

        private void PDoc_EndPrint(object sender, PrintEventArgs e)
        {
            txtPageCount.Text = iPageCount.ToString();
        }

        private void PrintToPrinter_Click(object sender, EventArgs e)
        {
            PDoc.Print();
        }

        private void PDoc_BeginPrint(object sender, PrintEventArgs e)
        {
            // iPageCount = 1;
        }

        int i = 0;
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            i = pv.StartPage;
            pv.StartPage = i++;
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pv.StartPage = iPageCount + 1;
        }

        private void btnFistPage_Click(object sender, EventArgs e)
        {
            pv.StartPage = 0;
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            i = pv.StartPage;
            pv.StartPage = i--;
        }
    }
}