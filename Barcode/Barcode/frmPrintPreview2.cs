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
    public partial class frmPrintPreview2 : Form
    {
        private PrintDocument m_PrintingDocument;
        private int m_iTotalPageCount = 0;
        private int m_iStartPage = 1;
        int m_pageGroupCount = 1;

        public PrintDocument PrintingDocument
        {
            get
            {
                return m_PrintingDocument;
            }
            set
            {
                m_PrintingDocument = value;
                m_PrintingDocument.PrinterSettings.FromPage = 1;
                m_PrintingDocument.PrinterSettings.ToPage = 1;

                m_PrintingDocument.BeginPrint += new PrintEventHandler(m_PrintingDocument_BeginPrint);
                m_PrintingDocument.PrintPage += new PrintPageEventHandler(m_PrintingDocument_PrintPage);
                m_PrintingDocument.EndPrint += new PrintEventHandler(Document_EndPrint);

                printPreviewControl1.UseAntiAlias = true;
                printPreviewControl1.Document = m_PrintingDocument;
            }

        }

        public frmPrintPreview2()
        {
            InitializeComponent();

        }

        private void frmPrintPreview_Load(object sender, EventArgs e)
        {
            //printPreviewControl1.Zoom = 0.75d;
            //tcboZoom.Text = Math.Round(printPreviewControl1.Zoom * 100, 3).ToString();
            printPreviewControl1.UseAntiAlias = true;
            tbtnSinglePage.Checked = true;
            printPreviewControl1.Document = m_PrintingDocument;
            printPreviewControl1.MouseWheel += new MouseEventHandler(printPreviewControl1_MouseWheel);

            //m_PrintingDocument.PrintPreviewControle = printPreviewControl1;


        }

        void printPreviewControl1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                if (e.Delta > 0)
                    ZoomIn();
                else
                    ZoomOut();
            }
        }

        void m_PrintingDocument_BeginPrint(object sender, PrintEventArgs e)
        {
           
            m_iTotalPageCount = m_PrintingDocument.PrinterSettings.MaximumPage;
        }

        void m_PrintingDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            //if (m_enmPrintAction == PrintAction.PrintToPreview)
            //    m_iPageCount++;
        }

        void Document_EndPrint(object sender, PrintEventArgs e)
        {
            if (e.PrintAction == PrintAction.PrintToPreview)
            {
                ttextPageCounter.Text = m_iStartPage.ToString()
                + " / " + m_iTotalPageCount.ToString();
                ChangeNavigationButtons();
                if (m_iTotalPageCount >= 2)
                {
                    tbtnTowPages.Enabled = true;
                }
                if (m_iTotalPageCount > 2)
                {
                    tbtnMultiPage.Enabled = true;
                }
            }
        }



        private void printPreviewControl1_StartPageChanged(object sender, EventArgs e)
        {
            //ttextPageCounter.Text = (printPreviewControl1.StartPage + 1).ToString() + " / " + m_iTotalPageCount.ToString();
            //ChangeNavigationButtons();
        }

        private void ChangeNavigationButtons()
        {
            if (m_iStartPage == 1)
            {
                tbtnFirstPage.Enabled = false;
                tbtnPreviousPage.Enabled = false;
                if (m_iTotalPageCount == 1)
                {
                    tbtnNextPage.Enabled = false;
                    tbtnLastPage.Enabled = false;
                }
                else
                {
                    tbtnNextPage.Enabled = true;
                    tbtnLastPage.Enabled = true;
                }
            }
            else if (m_iStartPage > 1 && m_iStartPage == m_iTotalPageCount - m_pageGroupCount + 1)
            {
                tbtnFirstPage.Enabled = true;
                tbtnPreviousPage.Enabled = true;
                tbtnNextPage.Enabled = false;
                tbtnLastPage.Enabled = false;
            }
            else if (m_iStartPage > 1 && m_iStartPage < m_iTotalPageCount)
            {
                tbtnFirstPage.Enabled = true;
                tbtnPreviousPage.Enabled = true;
                tbtnNextPage.Enabled = true;
                tbtnLastPage.Enabled = true;
            }
        }

        private void SetZoom(double value)
        {
            printPreviewControl1.Zoom = value;
            tcboZoom.Text = Math.Round(value * 100d, 0).ToString();
        }


        private void InvalidateLayout()
        {
            if ((m_iStartPage + m_pageGroupCount - 1) > m_iTotalPageCount)
            {
                m_iStartPage -= m_pageGroupCount - 1;
                m_PrintingDocument.PrinterSettings.FromPage = m_iStartPage;
                m_PrintingDocument.PrinterSettings.ToPage = m_iTotalPageCount;
            }
            else
            {
                m_PrintingDocument.PrinterSettings.FromPage = m_iStartPage;
                m_PrintingDocument.PrinterSettings.ToPage = m_iStartPage + m_pageGroupCount - 1;
            }
            printPreviewControl1.InvalidatePreview();
        }

        private void ttextPageCounter_Click(object sender, EventArgs e)
        {
            ttextPageCounter.Text = "";
        }

        private void ttextPageCounter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int value;
                bool result = int.TryParse(ttextPageCounter.Text, out value);
                if (result == false || value < 1 || value > m_iTotalPageCount)
                {
                    MessageBox.Show("The value must be From (1) To ("
                        + m_iTotalPageCount.ToString() + ")"
                        , "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    m_iStartPage = int.Parse(ttextPageCounter.Text);
                    ChangeNavigationButtons();
                    printPreviewControl1.Focus();
                    InvalidateLayout();
                }
            }

        }

        private void ttextPageCounter_Validating(object sender, CancelEventArgs e)
        {
            int value;
            bool result = int.TryParse(ttextPageCounter.Text, out value);
            if (result == false || value < 1 || value > m_iTotalPageCount)
            {
                ttextPageCounter.Text = (m_iStartPage).ToString()
                    + " / " + m_iTotalPageCount.ToString();
            }
        }

        private void tcboZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            printPreviewControl1.Zoom = double.Parse(tcboZoom.Text) / 100d;
            printPreviewControl1.Focus();
        }

        private void tcboZoom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                printPreviewControl1.Zoom = double.Parse(tcboZoom.Text) / 100d;
                tcboZoom.SelectedText = "";
                printPreviewControl1.Focus();
            }
        }



        private void ZoomIn()
        {
            printPreviewControl1.Zoom += 0.25d;
            tcboZoom.Text = Math.Round(printPreviewControl1.Zoom * 100d, 0).ToString();
        }



        private void ZoomOut()
        {
            if ((printPreviewControl1.Zoom - 0.25d) > 0)
            {
                printPreviewControl1.Zoom -= 0.25d;
            }
            tcboZoom.Text = Math.Round(printPreviewControl1.Zoom * 100d, 0).ToString();
        }

        private void frmPrintPreview_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    tbtnPreviousPage.PerformClick();
                    break;
                case Keys.Right:
                    tbtnNextPage.PerformClick();
                    break;
                case Keys.Home:
                    tbtnFirstPage.PerformClick();
                    break;
                case Keys.End:
                    tbtnLastPage.PerformClick();
                    break;
                case Keys.P:
                    if (e.Control) btnPrint.PerformClick();
                    break;
                case Keys.Oemplus:
                    ZoomIn();
                    break;
                case Keys.OemMinus:
                    ZoomOut();
                    break;
                case Keys.D1:
                    tbtnSinglePage.PerformClick();
                    break;
                case Keys.D2:
                    tbtnTowPages.PerformClick();
                    break;
                case Keys.D3:
                    tbtnMultiPage.PerformClick();
                    break;
                case Keys.F2:
                    tbtnFitWidth.PerformClick();
                    break;

            }
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {
            printPreviewControl1.Focus();
        }


        #region ToolPar Button's Click events

        private void NavigationButtons_Click(object sender, EventArgs e)
        {
            ToolStripButton btn = (ToolStripButton)sender;
            int PagesCount = printPreviewControl1.Rows * printPreviewControl1.Columns;
            switch (btn.Name)
            {
                case "tbtnFirstPage":
                    m_iStartPage = 1;
                    break;
                case "tbtnPreviousPage":
                    m_iStartPage -= PagesCount;
                    break;
                case "tbtnNextPage":
                    m_iStartPage += PagesCount;
                    break;
                case "tbtnLastPage":
                    m_iStartPage = m_iTotalPageCount - m_pageGroupCount + 1;
                    break;
                default:
                    break;
            }
            InvalidateLayout();
        }

        private void tbtnSinglePage_Click(object sender, EventArgs e)
        {
            m_pageGroupCount = 1;
            printPreviewControl1.Columns = 1;
            printPreviewControl1.Rows = 1;
            tbtnSinglePage.Checked = true;
            tbtnTowPages.Checked = false;
            tbtnMultiPage.Checked = false;
            float paperHeight = printPreviewControl1.Document.DefaultPageSettings.PaperSize.Height;
            float zoomAmount = printPreviewControl1.Height / paperHeight;
            SetZoom(zoomAmount);
            InvalidateLayout();
        }

        private void tbtnTowPages_Click(object sender, EventArgs e)
        {
            m_pageGroupCount = 2;
            printPreviewControl1.Columns = 2;
            printPreviewControl1.Rows = 1;
            tbtnSinglePage.Checked = false;
            tbtnTowPages.Checked = true;
            tbtnMultiPage.Checked = false;
            float paperHeight = printPreviewControl1.Document.DefaultPageSettings.PaperSize.Height;
            float zoomAmount = printPreviewControl1.Height / paperHeight;
            SetZoom(zoomAmount);
            InvalidateLayout();
        }

        private void tbtnMultiPage_Click(object sender, EventArgs e)
        {
            m_pageGroupCount = 4;
            printPreviewControl1.Columns = 2;
            printPreviewControl1.Rows = 4;
            tbtnSinglePage.Checked = false;
            tbtnTowPages.Checked = false;
            tbtnMultiPage.Checked = true;
            float paperHeight = (printPreviewControl1.Document.DefaultPageSettings.PaperSize.Height + 5) * 2;
            float zoomAmount = printPreviewControl1.Height / paperHeight;
            SetZoom(zoomAmount);
            InvalidateLayout();
        }

        private void tbtnFitWidth_Click(object sender, EventArgs e)
        {
            float paperWidth;
            if (tbtnSinglePage.Checked)
                paperWidth = m_PrintingDocument.DefaultPageSettings.PaperSize.Width;
            else
                paperWidth = (m_PrintingDocument.DefaultPageSettings.PaperSize.Width + 5) * 2;
            SetZoom(printPreviewControl1.ClientRectangle.Width / paperWidth);
        }

        private void tbtnZoomIn_Click(object sender, EventArgs e)
        {
            ZoomIn();
        }

        private void tbtnZoomOut_Click(object sender, EventArgs e)
        {
            ZoomOut();
        }

        private void pDFFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void tbtnPrint_Click(object sender, EventArgs e)
        {
            printDialog1.AllowCurrentPage = true;
            if (m_iTotalPageCount > 1)
            {
                printDialog1.AllowSomePages = true;
                if (printPreviewControl1.Rows > 1 || printPreviewControl1.Columns > 1)
                {
                    printDialog1.AllowSelection = true;
                    printDialog1.AllowCurrentPage = false;
                }
            }
            printDialog1.Document = m_PrintingDocument;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                int startPage = m_iStartPage;
                int lastPage = m_iStartPage + printPreviewControl1.Rows * printPreviewControl1.Columns - 1;
                if (lastPage > m_iTotalPageCount)
                {
                    lastPage = m_iTotalPageCount;
                }
                if (printDialog1.PrinterSettings.PrintRange == PrintRange.AllPages)
                {
                    printDialog1.PrinterSettings.FromPage = 1;
                    printDialog1.PrinterSettings.ToPage = m_iTotalPageCount;
                }
                else if (printDialog1.PrinterSettings.PrintRange == PrintRange.CurrentPage
                    || printDialog1.PrinterSettings.PrintRange == PrintRange.Selection)
                {
                    printDialog1.PrinterSettings.FromPage = startPage;
                    printDialog1.PrinterSettings.ToPage = lastPage;
                }
                m_PrintingDocument.Print();
            }
        }

        private void tbtnPageSetup_Click(object sender, EventArgs e)
        {
            //PageSetupDialog pgDialog = new PageSetupDialog();
            pgDialog.Document = m_PrintingDocument;
            RectangleF printableArea = pgDialog.PageSettings.PrintableArea;
            if (pgDialog.PageSettings.Landscape)
            {
                printableArea.Size = new SizeF(printableArea.Height, printableArea.Width);
            }
            Rectangle printArea = Rectangle.Truncate(printableArea);
            pgDialog.MinMargins.Left = printArea.Left;
            pgDialog.MinMargins.Top = printArea.Top;
            pgDialog.MinMargins.Right = pgDialog.PageSettings.Bounds.Right - printArea.Right;
            pgDialog.MinMargins.Bottom = pgDialog.PageSettings.Bounds.Bottom - printArea.Bottom;
            if (pgDialog.ShowDialog() == DialogResult.OK)
            {
                printPreviewControl1.InvalidatePreview();
            }
        }
        #endregion

        private void highQualityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewControl1.UseAntiAlias = true;
        }

        private void lowQualityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewControl1.UseAntiAlias = false;
        }

        private void frmPrintPreview_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_PrintingDocument.Dispose();
            m_PrintingDocument = null;
        }

        
    }
}